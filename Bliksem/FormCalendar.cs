using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Bliksem.CustomControls;

namespace Bliksem
{
	public partial class FormCalendar : Form
	{
		#region Private Members
		
		private readonly List<Schedule> _schedules = new List<Schedule>();
		private Schedule _schedule;		
		
		#endregion Private Members

		#region Initialization

		public FormCalendar(List<Schedule> schedules, IEnumerable<Channels> channels)
		{
			InitializeComponent();
			_schedules = schedules;
			CustomFlowLayoutPanel.ScheduleClicked += ScheduleItem_OnClick;

			foreach (Channels channel in channels)
			{
				comboBoxChannel.Items.Add(channel);
			}
		}

		#endregion Initialization

		#region Private Methods

		private void ScheduleItem_OnClick(Schedule scheduleItem)
		{
			_schedule = scheduleItem;
			
			//Enabled
			checkBoxScheduleEnabled.Checked = _schedule.Enabled;

			//Channel
			comboBoxChannel.SelectedIndex = Convert.ToInt16(_schedule.Channel) - 1;

			//Schedule name
			textBoxScheduleName.Text = _schedule.Name;

			//output channel
			
			//Start and end time
			dateTimePickerStartTime.Value = _schedule.StartTime;
			dateTimePickerEndTime.Value = _schedule.EndTime;

			//Start and end date
			dateTimePickerStartDate.Value = _schedule.StartDate;
			dateTimePickerEndDate.Value = _schedule.EndDate;

			//Enabled days of the week
			checkBoxSunday.Checked = _schedule.Sunday;
			checkBoxMonday.Checked = _schedule.Monday;
			checkBoxTuesday.Checked = _schedule.Tuesday;
			checkBoxWednesday.Checked = _schedule.Wednesday;
			checkBoxThursday.Checked = _schedule.Thursday;
			checkBoxFriday.Checked = _schedule.Friday;
			checkBoxSaturday.Checked = _schedule.Saturday;
		}

		private void FormCalendar_Load(object sender, EventArgs e)
		{
			PopulateCalendar();
		}

		private void AddItem(DateTime date, Schedule schedule)
		{
			scheduleCalendar1.AddItemByDate(date, schedule);
		}

		private void PopulateCalendar()
		{
			scheduleCalendar1.ClearPanels();

			foreach (Schedule schedule in _schedules)
			{
				for (DateTime dt = schedule.StartDate; dt < schedule.EndDate.AddDays(1); dt = dt.AddDays(1))
				{
					bool addThis = false;

					switch (dt.DayOfWeek)
					{
						case DayOfWeek.Sunday:
							if (schedule.Sunday) addThis = true;
							break;
						case DayOfWeek.Monday:
							if (schedule.Monday) addThis = true;
							break;
						case DayOfWeek.Tuesday:
							if (schedule.Tuesday) addThis = true;
							break;
						case DayOfWeek.Wednesday:
							if (schedule.Wednesday) addThis = true;
							break;
						case DayOfWeek.Thursday:
							if (schedule.Thursday) addThis = true;
							break;
						case DayOfWeek.Friday:
							if (schedule.Friday) addThis = true;
							break;
						case DayOfWeek.Saturday:
							if (schedule.Saturday) addThis = true;
							break;
					}

					if (addThis)
					{
						//TODO: Reduce this so that it only passes the dt variable and schedule object, the recieving member can make
						//the determination of color to be passed
						//the color should probably be decided when the item is added in the customflowlayout class

						AddItem(dt, schedule);
					}

				}
			}
		}

		#endregion Private Methods

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

		#region Event Handlers

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			scheduleCalendar1.Month = dateTimePicker1.Value;
			PopulateCalendar();
		}

		private void buttonUpdateSchedule_Click(object sender, EventArgs e)
		{
			//Endabled
			_schedule.Enabled = checkBoxScheduleEnabled.Checked;

			//Channel
			_schedule.Channel = (comboBoxChannel.SelectedIndex + 1).ToString(CultureInfo.InvariantCulture);

			//Start and end date
			_schedule.StartDate = dateTimePickerStartDate.Value;
			_schedule.EndDate = dateTimePickerEndDate.Value;

			//Start and end time
			_schedule.StartTime = dateTimePickerStartTime.Value;
			_schedule.EndTime = dateTimePickerEndTime.Value;

			//Enabled days of the week
			_schedule.Sunday = checkBoxSunday.Checked;
			_schedule.Monday = checkBoxMonday.Checked;
			_schedule.Tuesday = checkBoxTuesday.Checked;
			_schedule.Wednesday = checkBoxWednesday.Checked;
			_schedule.Thursday = checkBoxThursday.Checked;
			_schedule.Friday = checkBoxFriday.Checked;
			_schedule.Saturday = checkBoxSaturday.Checked;

			PopulateCalendar();
		}

		#endregion Event Handlers
	}
}
