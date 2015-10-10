using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;
using System.Runtime.Serialization;
using System.IO;
using Bliksem.Properties;

namespace Bliksem
{
	public partial class Form1 : Form
	{
		#region Private Members

		#region File paths

		private readonly string _dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem";
		private readonly string _dataFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem\\Bliksem.xml";
		private readonly string _scheduleFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem\\Schedule.xml";
		private readonly string _serialportFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem\\SerialPort.xml";
		
		//Not used at this time
		//private readonly string _logFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem_log.txt";

		#endregion File paths

		#region Control Arrays

		//private readonly Label[] _outputLabels;
		private readonly Label[] _nameLabels;
		private readonly Label[] _stateLabels;
		private readonly Button[] _onoffButtons;

		#endregion Control Arrays

		private LogWindow _logwindow = new LogWindow();
		private List<Channels> _outputs = new List<Channels>();
		private List<Schedule> _schedules = new List<Schedule>();
		private SerialPort _port = new SerialPort();
		private SerialPortSettings _portSettings = new SerialPortSettings();
		private readonly string[] _outputStates = new String[16];
		private readonly string[] _myPackets = new String[18];
		private string _currentPacket;
		private string _lastPacket;

		#endregion Private Members

		#region Initialization

		public Form1()
		{
			InitializeComponent();

			notifyIcon.Icon = Resources.bliksemIcon;

			if (Settings.Default.LogWindowAtStart)
			{
				_logwindow.Show();
			}

			//test_form testForm = new test_form();
			//testForm.Show();

			_logwindow.AddLog("Populating arrays");

			//_outputLabels = new[] { lbl_output1, lbl_output2, lbl_output3, lbl_output4, lbl_output5, lbl_output6, lbl_output7, lbl_output8,
			//								lbl_output9, lbl_output10, lbl_output11, lbl_output12, lbl_output13, lbl_output14, lbl_output15, lbl_output16};
			
			_nameLabels = new[] { lbl_name1, lbl_name2, lbl_name3, lbl_name4, lbl_name5, lbl_name6, lbl_name7, lbl_name8,
											lbl_name9, lbl_name10, lbl_name11, lbl_name12, lbl_name13, lbl_name14, lbl_name15, lbl_name16};
			_stateLabels = new[] { lbl_state1, lbl_state2, lbl_state3, lbl_state4, lbl_state5, lbl_state6, lbl_state7, lbl_state8,
											lbl_state9, lbl_state10, lbl_state11, lbl_state12, lbl_state13, lbl_state14, lbl_state15, lbl_state16};
			_onoffButtons = new[] { btn_onoff1, btn_onoff2, btn_onoff3, btn_onoff4, btn_onoff5, btn_onoff6, btn_onoff7, btn_onoff8,
											btn_onoff9, btn_onoff10, btn_onoff11, btn_onoff12, btn_onoff13, btn_onoff14, btn_onoff15, btn_onoff16};
			Button[] enableButtons = { btn_enable1, btn_enable2, btn_enable3, btn_enable4, btn_enable5, btn_enable6, btn_enable7, btn_enable8,
				btn_enable9, btn_enable10, btn_enable11, btn_enable12, btn_enable13, btn_enable14, btn_enable15, btn_enable16};

			
			//Do we have a dataFolder ?
			_logwindow.AddLog("Checking for data folder");
			if (!Directory.Exists(_dataFolder)) // NO
			{
				_logwindow.AddLog("Not found, attempting to create");
				Directory.CreateDirectory(_dataFolder); // Make it!
				_logwindow.AddLog("Data folder created");
			}
			else
			{
				_logwindow.AddLog("Data folder found");
			}

			if (!File.Exists(_dataFile))
			{
				_logwindow.AddLog("Creating generic file for outputs");
				for (int i = 0; i < 16; i++)
					_outputs.Add(new Channels((i + 1).ToString(CultureInfo.InvariantCulture), "CH" + (i + 1)));
				//Now that we've created generic data, save it
				SaveSettings();
			}
			else
			{
				_logwindow.AddLog("Loading output configuration file");
				LoadSettings();
				//Was setting buttons here
			}

			_logwindow.AddLog("Populating output control information");
			for (int i = 0; i < 16; i++)
			{
				_outputStates[i] = "00"; //Outputs are off
				_nameLabels[i].Text = _outputs[i].ChannelName;
				_onoffButtons[i].Tag = i;
				enableButtons[i].Tag = i;
				_onoffButtons[i].Click += onoffButton_Click;
				enableButtons[i].Click += enableButton_Click;
			}

			_logwindow.AddLog("Initialization Completed");
			_logwindow.AddLog("Ready");
		}

		#endregion Initialization

		#region Private Methods

		#region Settings loading & saving

		private void SaveSettings()
		{
			var xmlsettings = new XmlWriterSettings
			{
				Indent = true,
				IndentChars = "\t",
			};

			DataContractSerializer dataSer = new DataContractSerializer(typeof(List<Channels>));
			var dataWriter = XmlWriter.Create(_dataFile, xmlsettings);
			dataSer.WriteObject(dataWriter, _outputs);
			dataWriter.Close();

			DataContractSerializer scheduleSer = new DataContractSerializer(typeof(List<Schedule>));
			var scheduleWriter = XmlWriter.Create(_scheduleFile, xmlsettings);
			scheduleSer.WriteObject(scheduleWriter, _schedules);
			scheduleWriter.Close();

			DataContractSerializer serialportSer = new DataContractSerializer(typeof(SerialPortSettings));
			var serialportWriter = XmlWriter.Create(_serialportFile, xmlsettings);
			serialportSer.WriteObject(serialportWriter, _portSettings);
			serialportWriter.Close();
		
			//Settings may have changed, we need to repopulate the user defineable fields
			PopulateNameLabels();
			UpdateStates();

		}

		private void LoadSettings()
		{
			Text = @"Bliksem Control Center (2015)" + (Settings.Default.WindowCaption != "" ? " - " + Settings.Default.WindowCaption : "");

			using (FileStream reader = new FileStream(_dataFile, FileMode.Open, FileAccess.Read))
			{
				DataContractSerializer ser = new DataContractSerializer(typeof(List<Channels>));
				_outputs = (List<Channels>)ser.ReadObject(reader);
			}

			if (File.Exists(_scheduleFile))
			{
				using (FileStream reader = new FileStream(_scheduleFile, FileMode.Open, FileAccess.Read))
				{
					DataContractSerializer ser = new DataContractSerializer(typeof(List<Schedule>));
					_schedules = (List<Schedule>)ser.ReadObject(reader);
				}
			}

			if (!File.Exists(_serialportFile)) return;

			using (FileStream reader = new FileStream(_serialportFile, FileMode.Open, FileAccess.Read))
			{
				DataContractSerializer ser = new DataContractSerializer(typeof(SerialPortSettings));
				_portSettings = (SerialPortSettings)ser.ReadObject(reader);
			}
			_port.PortName = _portSettings.PortName ?? _port.PortName;
			_port.BaudRate = _portSettings.BaudRate == 0 ? 9600 : _portSettings.BaudRate;
			_port.Parity = _portSettings.Parity;
			_port.DataBits = _portSettings.DataBits == 0 ? 8 : _portSettings.DataBits;
			_port.StopBits = _portSettings.StopBits == StopBits.None ? StopBits.One : _portSettings.StopBits;
		}

		#endregion Settings loading & saving

		private void UpdateStates()
		{
			_currentPacket = "";
			for (int i = 0; i < 16; i++)
			{
				_nameLabels[i].Text = _outputs[i].ChannelName;
				_currentPacket = _currentPacket + _outputStates[i];
				if (_outputs[i].ChannelEnabled)
				{
					if (_outputStates[i] == "00")
					{
						_stateLabels[i].BackColor = Color.Lime;
						_stateLabels[i].Text = @"OFF";
						_onoffButtons[i].Text = @"Turn On";
						_onoffButtons[i].BackColor = Color.Lime;
					}
					if (_outputStates[i] == "FF")
					{
						_stateLabels[i].BackColor = Color.Red;
						_stateLabels[i].Text = @"ON";
						_onoffButtons[i].Text = @"Turn Off";
						_onoffButtons[i].BackColor = Color.Red;
					}
				}
				if (!_outputs[i].ChannelEnabled)
				{
					_stateLabels[i].BackColor = Color.Gray;
					_onoffButtons[i].BackColor = Color.Gray;
					_outputStates[i] = "00"; //It's disabled, lets just make sure its off as well
				}
			}

			//Check for updates, if there are none get outta here, we don't want to just send data out when its not needed
			if (_currentPacket == _lastPacket)
				return;
			_lastPacket = _currentPacket;

			_myPackets[0] = "7E";
			_myPackets[1] = "80";

			for (int i = 2; i < 18; i++)
			{
				_myPackets[i] = _outputStates[i - 2];
			}

			byte[] myPackets = _myPackets.Select(s => Convert.ToByte(s, 16)).ToArray();

			if (_port != null)
			{
				using (SerialPort port = new SerialPort(_port.PortName, _port.BaudRate, _port.Parity, _port.DataBits, _port.StopBits))
				{
					try
					{
						port.Handshake = Handshake.None;
						port.Encoding = Encoding.UTF8;
						port.RtsEnable = true;
						port.DtrEnable = true;
						port.Open();
						port.Write(myPackets, 0, myPackets.Length);
						port.Close();
					}
					catch (IOException)
					{
						tmr_UpdateStateButtons.Enabled = false;
						tmr_CheckSchedule.Enabled = false;
						MessageBox.Show(String.Format("The configured COM port: {0} could not be accessed, please verify setup and restart the application.", port.PortName), @"IO Exception", MessageBoxButtons.OK);
						_logwindow.AddLog("IO Exception: " + port.PortName);

					}
					catch (Exception e)
					{
						tmr_UpdateStateButtons.Enabled = false;
						tmr_CheckSchedule.Enabled = false;
						MessageBox.Show(String.Format("Error: {0}", e));
						_logwindow.AddLog("Exception: " + e);

					}
				}
			}
			else
			{
				tmr_UpdateStateButtons.Enabled = false;
				MessageBox.Show(@"Please configure serial port");
			}
		}

		/*
		 * This isn't used anymore ?
		private IEnumerable<byte> GetBytesFromByteString(string s)
		{
			for (int index = 0; index < s.Length; index += 2)
			{
				yield return Convert.ToByte(s.Substring(index, 2), 16);
			}
		}
		 */

		private void CheckSchedules()
		{
			for (int i = 0; i < _schedules.Count(); i++)
			{
				if (_schedules[i].Start())
				{
					if (_outputs[int.Parse(_schedules[i].Channel) - 1].ChannelEnabled)
					{
						_logwindow.AddLog("Starting Schedule: " + _schedules[i].Name);
						_outputStates[int.Parse(_schedules[i].Channel) - 1] = "FF";
					}
					else
					{
						_logwindow.AddLog("Schedule: " + _schedules[i].Name + ", ignored because the output channel is disabled");
					}
				}

				if (_schedules[i].Stop())
				{
					_logwindow.AddLog("Stopping Schedule: " + _schedules[i].Name);
					_outputStates[int.Parse(_schedules[i].Channel) - 1] = "00";
				}
			}
		}

		private void PopulateNameLabels()
		{
			int i = 0;
			foreach (Label nameLabel in _nameLabels)
			{
				nameLabel.Text = _outputs[i].ChannelName;
				i++;
			}
		}

		#endregion Private Methods

		#region Event Handlers

		private void enableButton_Click(object sender, EventArgs e)
		{
			if (_outputs[(int)((Button)sender).Tag].ChannelEnabled)
			{
				_outputs[(int)((Button)sender).Tag].ChannelEnabled = false;
				((Button)sender).Text = @"Enable";
				_logwindow.AddLog("Disable: " + _outputs[(int)((Button)sender).Tag].ChannelNumber + "." + _outputs[(int)((Button)sender).Tag].ChannelName);
			}
			else
			{
				_outputs[(int)((Button)sender).Tag].ChannelEnabled = true;
				((Button)sender).Text = @"Disable";
				_logwindow.AddLog("Enable: " + _outputs[(int)((Button)sender).Tag].ChannelNumber + "." + _outputs[(int)((Button)sender).Tag].ChannelName);
			}
			UpdateStates();
		}

		private void onoffButton_Click(object sender, EventArgs e)
		{
			if (_outputs[(int)((Button)sender).Tag].ChannelEnabled)
			{
				((Button)sender).BackColor = Color.HotPink;
				if (_outputStates[(int)((Button)sender).Tag] == "FF")
				{
					_outputStates[(int)((Button)sender).Tag] = "00"; //Output off
					_logwindow.AddLog("Toggle Off: " + _outputs[(int)((Button)sender).Tag].ChannelNumber + "." + _outputs[(int)((Button)sender).Tag].ChannelName);
				}
				else
				{
					_outputStates[(int)((Button)sender).Tag] = "FF"; //Output on
					_logwindow.AddLog("Toggle On: " + _outputs[(int)((Button)sender).Tag].ChannelNumber + "." + _outputs[(int)((Button)sender).Tag].ChannelName);
				}
				UpdateStates();
			}
		}

		private void tmr_UpdateStateButtons_Tick(object sender, EventArgs e)
		{
			UpdateStates();
		}

		private void serialPortSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SerialPortSetup serialPortConfig = new SerialPortSetup(_port))
			{
				if (serialPortConfig.ShowDialog() == DialogResult.OK)
				{
					_port = serialPortConfig.SelectedPort;
					//This is some wierd shit that it has to be done this way, DataContractSerializer SUCKS! Cannot serialize typeof(SerialPort) because it tries to open the damn port!
					//So we'll ultize a custom type to save and load the settings into, then pop them into the proper place, this keeps the formatting and style of saving the xml files
					//the same across the board.
					_portSettings.PortName = _port.PortName;
					_portSettings.BaudRate = _port.BaudRate;
					_portSettings.Parity = _port.Parity;
					_portSettings.DataBits = _port.DataBits;
					_portSettings.StopBits = _port.StopBits;
					SaveSettings();
				}
				else
				{
					LoadSettings();
				}
			}
		}

		private void Bliksem_OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if (Settings.Default.ConfirmAppClose)
			{
				if (MessageBox.Show(@"Are you sure you wish to close Bliksem", @"Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== DialogResult.No)
					e.Cancel = true;
			}

			SaveSettings();
		}

		private void tmr_CheckSchedule_Tick(object sender, EventArgs e)
		{
			CheckSchedules();
		}

		private void editSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ScheduleManager smanager = new ScheduleManager(_outputs, _schedules))
			{
				smanager.ShowDialog();
				if (smanager.DialogResult == DialogResult.OK)
				{
					_schedules = smanager.Schedules;
					_outputs = smanager.Channels;
					SaveSettings();
				}
				else
				{
					LoadSettings();
				}
			}
		}

		private void editOutputsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OutputManager omanager = new OutputManager(_outputs))
			{
				omanager.ShowDialog();
				if (omanager.DialogResult == DialogResult.OK)
				{
					_outputs = omanager.Outputs;
					SaveSettings();
				}
				else
				{
					LoadSettings();
				}
			}
		}

		private void logWindowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_logwindow.IsDisposed)
				_logwindow = new LogWindow();
			_logwindow.Show();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormSettings settingsForm = new FormSettings();
			if (settingsForm.ShowDialog() == DialogResult.OK)
				Settings.Default.Save();
			else
			{
				Settings.Default.Reload();
			}

			LoadSettings();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Minimized || !Settings.Default.MinimizeToTray) return;
			notifyIcon.BalloonTipText = @"Minimized to system tray";
			notifyIcon.BalloonTipTitle = @"[Bliksem 2015]";
			notifyIcon.Visible = true;
			notifyIcon.ShowBalloonTip(3000);
			ShowInTaskbar = false;
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
			notifyIcon.Visible = false;
		}

		private void showCalendarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCalendar calendar = new FormCalendar(_schedules, _outputs);
			calendar.ShowDialog();
		}

		#endregion Event Handlers

		#region Overrides

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Color c1 = Color.FromArgb(190, Color.LightBlue);
			Color c2 = Color.FromArgb(190, Color.DarkBlue);

			Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, 90);
			e.Graphics.FillRectangle(b, ClientRectangle);
		}

		#endregion Overrides
	}
}
