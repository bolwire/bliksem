using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Bliksem
{
	public partial class OutputUserControl : UserControl
	{
		private int _outputNumber;
		public int OutputNumber
		{
			get { return _outputNumber; }
			set
			{
				_outputNumber = value;
				labelOutputNumber.Text = value.ToString(CultureInfo.InvariantCulture);
			}
		}

		private string _outputName;
		public string OutputName
		{
			get { return _outputName; }
			set
			{
				_outputName = value;
				labelOutputName.Text = value;
			}
		}


		public bool OutputState
		{
			get { return labelOutputState.BackColor == Color.Red; }
			set { labelOutputState.BackColor = value ? Color.Red : Color.Green; }
		}


		public bool OutputEnable
		{
			get { return buttonOutputEnableToggle.Text == @"Disable"; }
			set
			{
				buttonOutputEnableToggle.Text = value ? @"Disable" : @"Enable";
				
			}
		}

		public OutputUserControl()
		{
			InitializeComponent();
		}
	}
}
