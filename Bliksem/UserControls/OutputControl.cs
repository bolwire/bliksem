using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bliksem.Properties;
using Timer = System.Windows.Forms.Timer;

namespace Bliksem.UserControls
{
	public enum OutputState
	{
		Enabled,
		Disabled,
		On
	}

	public partial class OutputControl : UserControl
	{
		private Timer timerHideButtons = new Timer();

		private string _outputName;
		private int _outputNumber;

		private OutputState _state;

		public string OutputName
		{
			get { return _outputName; }

			set
			{
				_outputName = value;
				labelOutputName.Text = _outputName;
				
			}
		}

		public int OutputNumber
		{
			get { return _outputNumber; }
			set 
			{ 
				_outputNumber = value;
				labelOutputNumber.Text = _outputNumber.ToString(CultureInfo.InvariantCulture);
			}
		}

		/// <summary>
		/// Returns the OutputNumber property - 1 for use in an array index
		/// </summary>
		public int ArrayIndex
		{
			get { return _outputNumber - 1; }
		}

		public OutputState State
		{
			get { return _state; }
			set
			{
				_state = value;
				UpdateState();
			}
		}

		public delegate void ToggleOutputEnableDelegate(object sender, EventArgs e);
		public static event ToggleOutputEnableDelegate ToggleOutputEnable;

		public delegate void ToggleOutputOnDelegate(object sender, EventArgs e);
		public static event ToggleOutputOnDelegate ToggleOutputOn;

		private static int _instanceCount;

		//There is so much wrong with this, but it works for me
		public OutputControl()
		{
			Interlocked.Increment(ref _instanceCount);
			InitializeComponent();
			State = OutputState.Enabled;
			//OutputNumber = 1;
			//OutputName = "OUTPUT 1";
			OutputNumber = _instanceCount;
			OutputName = "OUTPUT " + _instanceCount;
			buttonToggleEnable.Visible = buttonToggleOn.Visible = false;

			SetupHideButtonTimer();

		}

		~OutputControl()
		{
			Interlocked.Decrement(ref _instanceCount);
			//Take out the trash
			GC.Collect();
		}

		private void SetupHideButtonTimer()
		{
			timerHideButtons.Enabled = false;
			timerHideButtons.Interval = 30000;
			timerHideButtons.Tick += (sender, e) =>
			{
				buttonToggleEnable.Visible = buttonToggleOn.Visible = false;
				timerHideButtons.Enabled = false;
			};
		}

		private void UpdateState()
		{
			switch (_state)
			{
				case OutputState.Enabled:
					pictureBoxState.Image = Resources.green_LL;
					break;
				case OutputState.Disabled:
					pictureBoxState.Image = Resources.yellow_LL;
					break;
				case OutputState.On:
					pictureBoxState.Image = Resources.red_LL;
					break;
			}
		}

		private void pictureBoxOutputControl_Click(object sender, EventArgs e)
		{
			buttonToggleEnable.Visible = buttonToggleOn.Visible = !buttonToggleEnable.Visible;

			timerHideButtons.Enabled = buttonToggleEnable.Visible || buttonToggleOn.Visible;
		}

		public void SetEnableToggleText(string text)
		{
			buttonToggleEnable.Text = text;
		}

		public void SetOnToggleText(string text)
		{
			buttonToggleOn.Text = text;
		}

		private void buttonToggleOn_Click(object sender, EventArgs e)
		{
			ToggleOutputOn(this, e);
			timerHideButtons.Reset();
		}

		private void buttonToggleEnable_Click(object sender, EventArgs e)
		{
			ToggleOutputEnable(this, e);
			timerHideButtons.Reset();
		}

		private void labelOutputNumber_Click(object sender, EventArgs e)
		{

		}

	}
	
	public static class Extensions
	{
		/// <summary>
		/// Starts the timer interval over
		/// </summary>
		public static void Reset(this Timer tmr)
		{
			if (!tmr.Enabled)
			{
				throw new Exception("Timer not running. Invalid call to Reset()");
			}

			tmr.Enabled = false;
			tmr.Enabled = true;
		}
	}
}
