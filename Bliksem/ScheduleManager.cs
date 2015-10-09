using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bliksem
{
	public partial class ScheduleManager : Form
	{
		public List<Schedule> Schedules = new List<Schedule>();
		public List<Channels> Channels = new List<Channels>();
		private Schedule _currentSchedule;
		private Channels _currentChannel;

		public ScheduleManager(IEnumerable<Channels> channels, IEnumerable<Schedule> schedules)
		{
			InitializeComponent();

			Channels = new List<Channels>(channels);
			Schedules = new List<Schedule>(schedules);

			foreach (Channels cc in Channels)
			{
				cb_Outputs.Items.Add(cc);
			}

			PopulateSchedules();
		}

		private void PopulateSchedules(int reselect)
		{
			foreach (Schedule sc in Schedules)
			{
				cb_Schedule.Items.Add(sc);
			}
			cb_Schedule.SelectedIndex = reselect;
		}

		private void PopulateSchedules()
		{
			foreach (Schedule sc in Schedules)
			{
				cb_Schedule.Items.Add(sc);
			}
		}
		private void ScheduleManager_Load(object sender, EventArgs e)
		{

		}

		private void cb_Outputs_SelectedIndexChanged(object sender, EventArgs e)
		{
			//TODO: Change this so that the output channel member is set to the selectedindex of the combobox - 1
			Channels citem = cb_Outputs.SelectedItem as Channels;
			if (citem != null)
			{
				_currentChannel = citem;
				if (_currentSchedule != null)
				{
					_currentSchedule.Channel = citem.ChannelNumber;
				}
			}
			
		}
		
		private void cb_Schedule_SelectedIndexChanged(object sender, EventArgs e)
		{
			Schedule sitem = cb_Schedule.SelectedItem as Schedule;
			if (sitem != null)
			{
				_currentSchedule = sitem;

				//TODO: change this so that the selctedindex of the combobox is set to the output channel value - 1

				int i = 0;
				foreach (Channels cc in cb_Outputs.Items)
				{

					if (cc.ChannelNumber == sitem.Channel)
						cb_Outputs.SelectedIndex = i;
					i++;
				}


				txt_ScheduleName.Text = sitem.Name;
				checkEnabled.Checked = sitem.Enabled;
				dateStartTime.Value = sitem.StartTime;
				dateEndTime.Value = sitem.EndTime;
				dateStart.Value = sitem.StartDate;
				dateStop.Value = sitem.EndDate;
				checkSunday.Checked = sitem.Sunday;
				checkMonday.Checked = sitem.Monday;
				checkTuesday.Checked = sitem.Tuesday;
				checkWednesday.Checked = sitem.Wednesday;
				checkThursday.Checked = sitem.Thursday;
				checkFriday.Checked = sitem.Friday;
				checkSaturday.Checked = sitem.Saturday;
			}
		}

		private void btn_new_Click(object sender, EventArgs e)
		{
			//TODO:Update this after fixing the method of selection to make sure
			//TODO: the combobox selectedindex is valid
			if (_currentChannel == null)
			{
				MessageBox.Show(@"Please select an output before creating a new schedule.");
				return;
			}

			Schedule sitem = new Schedule();
			
			if (txt_ScheduleName.Text.Length > 0)
			{
				sitem.Name = txt_ScheduleName.Text;
			}
			else
			{
				sitem.Name = "New Schedule";
				txt_ScheduleName.Text = sitem.Name;
			}

			if (Schedules.Contains(sitem))
			{
				MessageBox.Show(@"There is already a schedule with that name.");
				return;
			}

			sitem.Enabled = checkEnabled.Checked;
			//TODO: this should be the combobox selectedindex + 1
			sitem.Channel = _currentChannel.ChannelNumber;
			sitem.StartTime = dateStartTime.Value;
			sitem.EndTime = dateEndTime.Value;
			sitem.StartDate = dateStart.Value;
			sitem.EndDate = dateStop.Value;
			sitem.Sunday = checkSunday.Checked;
			sitem.Monday = checkMonday.Checked;
			sitem.Tuesday = checkTuesday.Checked;
			sitem.Wednesday = checkWednesday.Checked;
			sitem.Thursday = checkThursday.Checked;
			sitem.Friday = checkFriday.Checked;
			sitem.Saturday = checkSaturday.Checked;
			_currentSchedule = sitem;
			Schedules.Add(sitem);
			cb_Schedule.Items.Clear();
			PopulateSchedules();
			cb_Schedule.Text = _currentSchedule.Name;
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Name = txt_ScheduleName.Text;
				_currentSchedule.Enabled = checkEnabled.Checked;
				//TODO: this should be the combobox selectedindex + 1
				_currentSchedule.Channel = _currentChannel.ChannelNumber;
				_currentSchedule.StartTime = dateStartTime.Value;
				_currentSchedule.EndTime = dateEndTime.Value;
				_currentSchedule.StartDate = dateStart.Value;
				_currentSchedule.EndDate = dateStop.Value;
				_currentSchedule.Sunday = checkSunday.Checked;
				_currentSchedule.Monday = checkMonday.Checked;
				_currentSchedule.Tuesday = checkTuesday.Checked;
				_currentSchedule.Wednesday = checkWednesday.Checked;
				_currentSchedule.Thursday = checkThursday.Checked;
				_currentSchedule.Friday = checkFriday.Checked;
				_currentSchedule.Saturday = checkSaturday.Checked;
				
				int i = cb_Schedule.SelectedIndex;
				cb_Schedule.Items.Clear();
				PopulateSchedules(i);
			}
			else
				MessageBox.Show(@"You must create a new schedule prior to clicking save.");
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				if (MessageBox.Show(String.Format("You are about to delete the schedule named: {0}", _currentSchedule.Name), @"Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
				Schedules.Remove(_currentSchedule);
				_currentSchedule = null;
				cb_Schedule.Items.Clear();
				cb_Schedule.ResetText();
				PopulateSchedules();
			
			}
			else
			{
				MessageBox.Show(@"There is no schedule seleted for this operation.");
			}
		}

		private void dateStartTime_ValueChanged(object sender, EventArgs e)
		{
			SetTime();
			if (_currentSchedule != null)
			{
				_currentSchedule.StartTime = dateStartTime.Value;
			}
		}

		private void dateEndTime_ValueChanged(object sender, EventArgs e)
		{
			SetTime();
			if (_currentSchedule != null)
			{
				_currentSchedule.EndTime = dateEndTime.Value;
			}
		}

		public void SetTime()
		{
			TimeSpan t;

			if (dateEndTime.Value < dateStartTime.Value)
			{
				DateTime newEndDate = new DateTime(dateEndTime.Value.Ticks);
				newEndDate = newEndDate.AddDays(1);
				t = newEndDate - dateStartTime.Value;
			}
			else
			{
				t = dateEndTime.Value - dateStartTime.Value;
			}

			labelDuration.Text = @"(" + t.Hours + @" hours and " + t.Minutes + @" minutes)";
		}

		private void checkSunday_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Sunday = checkSunday.Checked;
			}
		}

		private void checkMonday_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Monday = checkMonday.Checked;
			}
		}

		private void checkTuesday_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Tuesday = checkTuesday.Checked;
			}
		}

		private void checkWednesday_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Wednesday = checkWednesday.Checked;
			}
		}

		private void checkThursday_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Thursday = checkThursday.Checked;
			}
		}

		private void checkFriday_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Friday = checkFriday.Checked;
			}
		}

		private void checkSaturday_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Saturday = checkSaturday.Checked;
			}
		}

		private void checkEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Enabled = checkEnabled.Checked;
			}
		}

		private void txt_ScheduleName_KeyUp(object sender, KeyEventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.Name = txt_ScheduleName.Text;
			}
		}


		private void dateStart_CloseUp(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.StartDate = dateStart.Value;
			}
		}

		private void dateStop_CloseUp(object sender, EventArgs e)
		{
			if (_currentSchedule != null)
			{
				_currentSchedule.EndDate = dateStop.Value;
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(@"You will lose any changes, save them now?", @"Save any changes ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
				DialogResult = DialogResult.OK;
			if (result == DialogResult.No)
				DialogResult = DialogResult.Cancel;
			if (result == DialogResult.Cancel)
				DialogResult = DialogResult.None;
		}
	}
}
