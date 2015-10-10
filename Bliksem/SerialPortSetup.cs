using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Bliksem
{
	public partial class SerialPortSetup : Form
	{
		public SerialPortSetup(SerialPort serialPort)
		{
			InitializeComponent();
			foreach (string s in SerialPort.GetPortNames())
			{
				try
				{
					using (SerialPort checkPort = new SerialPort(s))
					{
						checkPort.Open();
						checkPort.Close();
					}
					comboBoxPortName.Items.Add(s);
				}
				//catch the exception in case we want to use it
				//or log it.
				catch (UnauthorizedAccessException)
				{
					comboBoxPortName.Items.Add(s + " (IN USE)");
				}
			}
			comboBoxPortName.Items.Add("COM1");

			comboBoxParity.Items.AddRange(Enum.GetValues(typeof(Parity)).Cast<object>().ToArray());
			comboBoxStopBits.Items.AddRange(Enum.GetValues(typeof(StopBits)).Cast<object>().ToArray());
			comboBoxStopBits.Items.Remove(StopBits.None);

			//set our text value
			configuredPortValueLabel.Text = serialPort != null ? serialPort.PortName : "None";

			if (serialPort == null && SerialPort.GetPortNames().Any())
			{
				serialPort = new SerialPort(SerialPort.GetPortNames().FirstOrDefault(), 57600, Parity.None, 8, StopBits.One);
			}

			SelectedPort = serialPort;

			//set our first item in the combobox if we have one
			if (comboBoxPortName.Items.Count > 0)
			{
				comboBoxPortName.SelectedIndex = 0;
			}
		}

		public SerialPort SelectedPort
		{
			get
			{
				if (HavePorts)
				{
					return new SerialPort(PortName, BaudRate, Parity, DataBits, StopBits);
				}
				return null;
			}
			set
			{
				if (value != null)
				{
					HavePorts = true;
					PortName = value.PortName;
					BaudRate = value.BaudRate;
					Parity = value.Parity;
					DataBits = value.DataBits;
					StopBits = value.StopBits;
				}
				else
				{
					HavePorts = false;
				}
			}
		}

		private bool HavePorts
		{
			get { return groupBox.Enabled; }
			set { groupBox.Enabled = value; }
		}

		private string PortName
		{
			get
			{
				if (comboBoxPortName.SelectedItem != null)
				{
					//if the portname has (IN USE) we need to strip it so we have
					//a valid serial port name.
					string port = comboBoxPortName.SelectedItem as string;
					if (port == null || !port.Contains("(IN USE)")) return comboBoxPortName.SelectedItem as string;
					string value = port.Replace("(IN USE)", string.Empty).Trim();
					return value;
				}
				return null;
			}
			set { comboBoxPortName.SelectedItem = value; }
		}

		private int BaudRate
		{
			get
			{
				int value;
				if (int.TryParse(comboBoxBaudRate.SelectedItem as string, out value))
				{
					return value;
				}
				return -1;
			}
			set { comboBoxBaudRate.SelectedItem = value.ToString(CultureInfo.InvariantCulture); }
		}

		private Parity Parity
		{
			get { return (Parity)comboBoxParity.SelectedItem; }
			set { comboBoxParity.SelectedItem = value; }
		}

		private int DataBits
		{
			get
			{
				int value;
				if (int.TryParse(textBoxDataBits.Text, out value))
				{
					return value;
				}
				return -1;
			}
			set { textBoxDataBits.Text = value.ToString(CultureInfo.InvariantCulture); }
		}

		private StopBits StopBits
		{
			get { return (StopBits)comboBoxStopBits.SelectedItem; }
			set { comboBoxStopBits.SelectedItem = value; }
		}

		private bool _Validate()
		{
			if (HavePorts)
			{
				StringBuilder sb = new StringBuilder();

				if (string.IsNullOrWhiteSpace(PortName))
				{
					sb.AppendLine("* Port name has not been selected.");
				}
				if (BaudRate == -1)
				{
					sb.AppendLine("* Baud rate has not been selected.");
				}
				if (DataBits == -1)
				{
					sb.AppendLine("* Invalid value for data bits.");
				}

				if (sb.Length > 0)
				{
					MessageBox.Show(string.Format("The following items need to be resolved:{0}{0}{1}", Environment.NewLine, sb),
									@"Serial Port", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return false;
				}
				return true;
			}

			return false;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (!_Validate())
			{
				DialogResult = DialogResult.None;
			}
			else
			{
				//Since we strip out the (IN USE) in the getter/setter
				//we need to go ahead and pull from the combo box to check
				//if we have an in use port.  If we do, just let the user know
				//and allow them to continue.  We will handle the access violations
				//in the module classes
				string port = comboBoxPortName.SelectedItem as string;
				if (port == null || !port.Contains("(IN USE)")) return;
				DialogResult result = MessageBox.Show(@"Serial Port may be in use, do you wish to continue?", @"Warning",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.No)
				{
					DialogResult = DialogResult.None;
				}
			}
		}
	}
}
