using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Bliksem
{
	public partial class Form1 : Form
	{
		private string dataFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem";
		private string dataFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem\\Bliksem.xml";
		private string scheduleFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem\\Schedule.xml";
		private string serialportFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem\\SerialPort.xml";
		private string logFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bliksem_log.txt";

		private Label[] outputLabels;
		private Label[] nameLabels;
		private Label[] stateLabels;
		private Button[] onoffButtons;
		private Button[] enableButtons;


		List<Channels> Outputs = new List<Channels>();
		List<Schedule> Schedules = new List<Schedule>();
		SerialPort _Port = new SerialPort();
		SerialPortSettings PortSettings = new SerialPortSettings();
		string[] outputStates = new String[16];
		LogWindow _logwindow = new LogWindow();
		string[] myPacket = new String[18];
		string currentPacket;
		string lastPacket;


		public Form1()
		{
			InitializeComponent();
			outputLabels = new Label[] { lbl_output1, lbl_output2, lbl_output3, lbl_output4, lbl_output5, lbl_output6, lbl_output7, lbl_output8,
											lbl_output9, lbl_output10, lbl_output11, lbl_output12, lbl_output13, lbl_output14, lbl_output15, lbl_output16};
			nameLabels = new Label[] { lbl_name1, lbl_name2, lbl_name3, lbl_name4, lbl_name5, lbl_name6, lbl_name7, lbl_name8,
											lbl_name9, lbl_name10, lbl_name11, lbl_name12, lbl_name13, lbl_name14, lbl_name15, lbl_name16};
			stateLabels = new Label[] { lbl_state1, lbl_state2, lbl_state3, lbl_state4, lbl_state5, lbl_state6, lbl_state7, lbl_state8,
											lbl_state9, lbl_state10, lbl_state11, lbl_state12, lbl_state13, lbl_state14, lbl_state15, lbl_state16};
			onoffButtons = new Button[] { btn_onoff1, btn_onoff2, btn_onoff3, btn_onoff4, btn_onoff5, btn_onoff6, btn_onoff7, btn_onoff8,
											btn_onoff9, btn_onoff10, btn_onoff11, btn_onoff12, btn_onoff13, btn_onoff14, btn_onoff15, btn_onoff16};
			enableButtons = new Button[] { btn_enable1, btn_enable2, btn_enable3, btn_enable4, btn_enable5, btn_enable6, btn_enable7, btn_enable8,
											btn_enable9, btn_enable10, btn_enable11, btn_enable12, btn_enable13, btn_enable14, btn_enable15, btn_enable16};

			//Do we have a dataFolder ?
			if (!System.IO.Directory.Exists(dataFolder)) // NO
				System.IO.Directory.CreateDirectory(dataFolder); // Make it!

			if (!System.IO.File.Exists(dataFile))
			{
				for (int i = 0; i < 16; i++)
					Outputs.Add(new Channels((i + 1).ToString(), "CH" + (i + 1)));
				//Now that we've created generic data, save it
				SaveSettings();
			}
			else
			{
				LoadSettings();
				//Was setting buttons here
			}
			for (int i = 0; i < 16; i++)
			{
				outputStates[i] = "00"; //Outputs are off
				nameLabels[i].Text = Outputs[i].ChannelName;
				onoffButtons[i].Tag = i;
				enableButtons[i].Tag = i;
				onoffButtons[i].Click += new System.EventHandler(this.onoffButton_Click);
				enableButtons[i].Click += new System.EventHandler(this.enableButton_Click);
			}
			_logwindow.Show();
			_logwindow.AddLog("Ready");
		}

		public void SaveSettings()
		{
			var xmlsettings = new XmlWriterSettings()
			{
				Indent = true,
				IndentChars = "\t",
			};

			DataContractSerializer dataSer = new DataContractSerializer(typeof(List<Channels>));
			var dataWriter = XmlWriter.Create(dataFile, xmlsettings);
			dataSer.WriteObject(dataWriter, Outputs);
			dataWriter.Close();

			DataContractSerializer scheduleSer = new DataContractSerializer(typeof(List<Schedule>));
			var scheduleWriter = XmlWriter.Create(scheduleFile, xmlsettings);
			scheduleSer.WriteObject(scheduleWriter, Schedules);
			scheduleWriter.Close();

			DataContractSerializer serialportSer = new DataContractSerializer(typeof(SerialPortSettings));
			var serialportWriter = XmlWriter.Create(serialportFile, xmlsettings);
			serialportSer.WriteObject(serialportWriter, PortSettings);
			serialportWriter.Close();
		}

		private void LoadSettings()
		{
			using (FileStream reader = new FileStream(dataFile, FileMode.Open, FileAccess.Read))
			{
				DataContractSerializer ser = new DataContractSerializer(typeof(List<Channels>));
				Outputs = (List<Channels>)ser.ReadObject(reader);
			}

			if (System.IO.File.Exists(scheduleFile))
			{
				using (FileStream reader = new FileStream(scheduleFile, FileMode.Open, FileAccess.Read))
				{
					DataContractSerializer ser = new DataContractSerializer(typeof(List<Schedule>));
					Schedules = (List<Schedule>)ser.ReadObject(reader);
				}
			}

			if (System.IO.File.Exists(serialportFile))
			{
				using (FileStream reader = new FileStream(serialportFile, FileMode.Open, FileAccess.Read))
				{
					DataContractSerializer ser = new DataContractSerializer(typeof(SerialPortSettings));
					PortSettings = (SerialPortSettings)ser.ReadObject(reader);
				}
				_Port.PortName = PortSettings.PortName;
				_Port.BaudRate = PortSettings.BaudRate;
				_Port.Parity = PortSettings.Parity;
				_Port.DataBits = PortSettings.DataBits;
				_Port.StopBits = PortSettings.StopBits;
			}
		}

		private void enableButton_Click(object sender, EventArgs e)
		{
			if (Outputs[(int)((Button)sender).Tag].ChannelEnabled)
			{
				Outputs[(int)((Button)sender).Tag].ChannelEnabled = false;
				((Button)sender).Text = "Enable";
				_logwindow.AddLog("Disable: " + Outputs[(int)((Button)sender).Tag].ChannelNumber + "." + Outputs[(int)((Button)sender).Tag].ChannelName);
			}
			else
			{
				Outputs[(int)((Button)sender).Tag].ChannelEnabled = true;
				((Button)sender).Text = "Disable";
				_logwindow.AddLog("Enable: " + Outputs[(int)((Button)sender).Tag].ChannelNumber + "." + Outputs[(int)((Button)sender).Tag].ChannelName);
			}
			UpdateStates();
		}

		private void editButton_Click(object sender, EventArgs e)
		{


		}

		private void onoffButton_Click(object sender, EventArgs e)
		{
			if (Outputs[(int)((Button)sender).Tag].ChannelEnabled)
			{
				((Button)sender).BackColor = Color.HotPink;
				if (outputStates[(int)((Button)sender).Tag] == "FF")
				{
					outputStates[(int)((Button)sender).Tag] = "00"; //Output off
					_logwindow.AddLog("Toggle Off: " + Outputs[(int)((Button)sender).Tag].ChannelNumber + "." + Outputs[(int)((Button)sender).Tag].ChannelName);
				}
				else
				{
					outputStates[(int)((Button)sender).Tag] = "FF"; //Output on
					_logwindow.AddLog("Toggle On: " + Outputs[(int)((Button)sender).Tag].ChannelNumber + "." + Outputs[(int)((Button)sender).Tag].ChannelName);
				}
				UpdateStates();
			}
		}

		private void outputsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OutputManager manager = new OutputManager(new List<Channels>(Outputs));
			manager.ShowDialog();
		}

		private void tmr_UpdateStateButtons_Tick(object sender, EventArgs e)
		{
			UpdateStates();
		}

		private void UpdateStates()
		{
			currentPacket = "";
			for (int i = 0; i < 16; i++)
			{
				nameLabels[i].Text = Outputs[i].ChannelName;
				currentPacket = currentPacket + outputStates[i];
				if (Outputs[i].ChannelEnabled)
				{
					if (outputStates[i] == "00")
					{
						stateLabels[i].BackColor = Color.Lime;
						stateLabels[i].Text = "OFF";
						onoffButtons[i].Text = "Turn On";
						onoffButtons[i].BackColor = Color.Lime;
					}
					if (outputStates[i] == "FF")
					{
						stateLabels[i].BackColor = Color.Red;
						stateLabels[i].Text = "ON";
						onoffButtons[i].Text = "Turn Off";
						onoffButtons[i].BackColor = Color.Red;
					}
				}
				if (!Outputs[i].ChannelEnabled)
				{
					stateLabels[i].BackColor = Color.Gray;
					onoffButtons[i].BackColor = Color.Gray;
					outputStates[i] = "00"; //It's disabled, lets just make sure its off as well
				}
			}

			//Check for updates, if there are none get outta here, we don't want to just send data out when its not needed
			if (currentPacket == lastPacket)
				return;
			lastPacket = currentPacket;

			myPacket[0] = "7E";
			myPacket[1] = "80";

			for (int i = 2; i < 18; i++)
			{
				myPacket[i] = outputStates[i - 2];
			}

			byte[] _myPacket = myPacket.Select(s => Convert.ToByte(s, 16)).ToArray();

			if (_Port != null)
			{
				using (SerialPort Port = new SerialPort(_Port.PortName, _Port.BaudRate, _Port.Parity, _Port.DataBits, _Port.StopBits))
				{
					try
					{
						Port.Handshake = Handshake.None;
						Port.Encoding = Encoding.UTF8;
						Port.RtsEnable = true;
						Port.DtrEnable = true;
						Port.Open();
						Port.Write(_myPacket, 0, _myPacket.Length);
						Port.Close();
					}
					catch (IOException)
					{
						tmr_UpdateStateButtons.Enabled = false;
						tmr_CheckSchedule.Enabled = false;
						MessageBox.Show(String.Format("The configured COM port: {0} could not be accessed, please verify setup and restart the application.", Port.PortName), "IO Exception", MessageBoxButtons.OK);

					}
					catch (Exception e)
					{
						tmr_UpdateStateButtons.Enabled = false;
						tmr_CheckSchedule.Enabled = false;
						MessageBox.Show(String.Format("Error: {0}", e));

					}
				}
			}
			else
			{
				tmr_UpdateStateButtons.Enabled = false;
				MessageBox.Show("Please configure serial port");
			}
		}

		public IEnumerable<byte> GetBytesFromByteString(string s)
		{

			for (int index = 0; index < s.Length; index += 2)
			{
				yield return Convert.ToByte(s.Substring(index, 2), 16);
			}
		}

		private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(string.Format("{0}", Schedules[1].Name));
		}

		private void serialPortSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SerialPortSetup serialPortConfig = new SerialPortSetup(_Port))
			{
				if (serialPortConfig.ShowDialog() == DialogResult.OK)
				{
					_Port = serialPortConfig.SelectedPort;
					//This is some wierd shit that it has to be done this way, DataContractSerializer SUCKS! Cannot serialize typeof(SerialPort) because it tries to open the damn port!
					//So we'll ultize a custom type to save and load the settings into, then pop them into the proper place, this keeps the formatting and style of saving the xml files
					//the same across the board.
					PortSettings.PortName = _Port.PortName;
					PortSettings.BaudRate = _Port.BaudRate;
					PortSettings.Parity = _Port.Parity;
					PortSettings.DataBits = _Port.DataBits;
					PortSettings.StopBits = _Port.StopBits;
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
			SaveSettings();
		}

		private void tmr_CheckSchedule_Tick(object sender, EventArgs e)
		{
			CheckSchedules();
		}

		private void CheckSchedules()
		{
			for (int i = 0; i < Schedules.Count(); i++)
			{
				if (Schedules[i].Start)
				{
					if (Outputs[int.Parse(Schedules[i].Channel) - 1].ChannelEnabled)
					{
						_logwindow.AddLog("Starting Schedule: " + Schedules[i].Name);
						outputStates[int.Parse(Schedules[i].Channel) - 1] = "FF";
					}
					else
					{
						_logwindow.AddLog("Schedule: " + Schedules[i].Name + ", ignored because the output channel is disabled");
					}
				}

				if (Schedules[i].Stop)
				{
					_logwindow.AddLog("Stopping Schedule: " + Schedules[i].Name);
					outputStates[int.Parse(Schedules[i].Channel) - 1] = "00";
				}
			}
		}
		
		private void editSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ScheduleManager smanager = new ScheduleManager(Outputs, Schedules))
			{
				smanager.ShowDialog();
				if (smanager.DialogResult == DialogResult.OK)
				{
					Schedules = smanager.Schedules;
					Outputs = smanager.Channels;
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
			using (OutputManager omanager = new OutputManager(Outputs))
			{
				omanager.ShowDialog();
				if (omanager.DialogResult == DialogResult.OK)
				{
					Outputs = omanager.Outputs;
					SaveSettings();
				}
				else
				{
					LoadSettings();
				}
			}
		}
	}
}
