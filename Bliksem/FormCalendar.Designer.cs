namespace Bliksem
{
	partial class FormCalendar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxScheduleName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxSunday = new System.Windows.Forms.CheckBox();
			this.checkBoxMonday = new System.Windows.Forms.CheckBox();
			this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
			this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
			this.checkBoxThursday = new System.Windows.Forms.CheckBox();
			this.checkBoxFriday = new System.Windows.Forms.CheckBox();
			this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
			this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonUpdateSchedule = new System.Windows.Forms.Button();
			this.comboBoxChannel = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBoxScheduleEnabled = new System.Windows.Forms.CheckBox();
			this.scheduleCalendar1 = new Bliksem.UserControls.ScheduleCalendar();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "MMMM yyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(820, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Schedule:";
			// 
			// textBoxScheduleName
			// 
			this.textBoxScheduleName.Location = new System.Drawing.Point(881, 44);
			this.textBoxScheduleName.Name = "textBoxScheduleName";
			this.textBoxScheduleName.Size = new System.Drawing.Size(190, 20);
			this.textBoxScheduleName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(820, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Start Time:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(820, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "End Time:";
			// 
			// checkBoxSunday
			// 
			this.checkBoxSunday.AutoSize = true;
			this.checkBoxSunday.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxSunday.Location = new System.Drawing.Point(881, 202);
			this.checkBoxSunday.Name = "checkBoxSunday";
			this.checkBoxSunday.Size = new System.Drawing.Size(62, 17);
			this.checkBoxSunday.TabIndex = 5;
			this.checkBoxSunday.Text = "Sunday";
			this.checkBoxSunday.UseVisualStyleBackColor = false;
			// 
			// checkBoxMonday
			// 
			this.checkBoxMonday.AutoSize = true;
			this.checkBoxMonday.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxMonday.Location = new System.Drawing.Point(881, 225);
			this.checkBoxMonday.Name = "checkBoxMonday";
			this.checkBoxMonday.Size = new System.Drawing.Size(64, 17);
			this.checkBoxMonday.TabIndex = 5;
			this.checkBoxMonday.Text = "Monday";
			this.checkBoxMonday.UseVisualStyleBackColor = false;
			// 
			// checkBoxTuesday
			// 
			this.checkBoxTuesday.AutoSize = true;
			this.checkBoxTuesday.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxTuesday.Location = new System.Drawing.Point(881, 248);
			this.checkBoxTuesday.Name = "checkBoxTuesday";
			this.checkBoxTuesday.Size = new System.Drawing.Size(67, 17);
			this.checkBoxTuesday.TabIndex = 5;
			this.checkBoxTuesday.Text = "Tuesday";
			this.checkBoxTuesday.UseVisualStyleBackColor = false;
			// 
			// checkBoxWednesday
			// 
			this.checkBoxWednesday.AutoSize = true;
			this.checkBoxWednesday.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxWednesday.Location = new System.Drawing.Point(881, 271);
			this.checkBoxWednesday.Name = "checkBoxWednesday";
			this.checkBoxWednesday.Size = new System.Drawing.Size(83, 17);
			this.checkBoxWednesday.TabIndex = 5;
			this.checkBoxWednesday.Text = "Wednesday";
			this.checkBoxWednesday.UseVisualStyleBackColor = false;
			// 
			// checkBoxThursday
			// 
			this.checkBoxThursday.AutoSize = true;
			this.checkBoxThursday.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxThursday.Location = new System.Drawing.Point(881, 294);
			this.checkBoxThursday.Name = "checkBoxThursday";
			this.checkBoxThursday.Size = new System.Drawing.Size(70, 17);
			this.checkBoxThursday.TabIndex = 5;
			this.checkBoxThursday.Text = "Thursday";
			this.checkBoxThursday.UseVisualStyleBackColor = false;
			// 
			// checkBoxFriday
			// 
			this.checkBoxFriday.AutoSize = true;
			this.checkBoxFriday.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxFriday.Location = new System.Drawing.Point(881, 317);
			this.checkBoxFriday.Name = "checkBoxFriday";
			this.checkBoxFriday.Size = new System.Drawing.Size(54, 17);
			this.checkBoxFriday.TabIndex = 5;
			this.checkBoxFriday.Text = "Friday";
			this.checkBoxFriday.UseVisualStyleBackColor = false;
			// 
			// checkBoxSaturday
			// 
			this.checkBoxSaturday.AutoSize = true;
			this.checkBoxSaturday.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxSaturday.Location = new System.Drawing.Point(881, 340);
			this.checkBoxSaturday.Name = "checkBoxSaturday";
			this.checkBoxSaturday.Size = new System.Drawing.Size(68, 17);
			this.checkBoxSaturday.TabIndex = 5;
			this.checkBoxSaturday.Text = "Saturday";
			this.checkBoxSaturday.UseVisualStyleBackColor = false;
			// 
			// dateTimePickerStartTime
			// 
			this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerStartTime.Location = new System.Drawing.Point(881, 98);
			this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
			this.dateTimePickerStartTime.ShowUpDown = true;
			this.dateTimePickerStartTime.Size = new System.Drawing.Size(190, 20);
			this.dateTimePickerStartTime.TabIndex = 6;
			// 
			// dateTimePickerEndTime
			// 
			this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerEndTime.Location = new System.Drawing.Point(881, 124);
			this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
			this.dateTimePickerEndTime.ShowUpDown = true;
			this.dateTimePickerEndTime.Size = new System.Drawing.Size(190, 20);
			this.dateTimePickerEndTime.TabIndex = 6;
			// 
			// dateTimePickerStartDate
			// 
			this.dateTimePickerStartDate.Location = new System.Drawing.Point(881, 150);
			this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
			this.dateTimePickerStartDate.Size = new System.Drawing.Size(190, 20);
			this.dateTimePickerStartDate.TabIndex = 6;
			// 
			// dateTimePickerEndDate
			// 
			this.dateTimePickerEndDate.Location = new System.Drawing.Point(881, 176);
			this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
			this.dateTimePickerEndDate.Size = new System.Drawing.Size(190, 20);
			this.dateTimePickerEndDate.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(820, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Start Date:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(820, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "End Date:";
			// 
			// buttonUpdateSchedule
			// 
			this.buttonUpdateSchedule.Location = new System.Drawing.Point(881, 364);
			this.buttonUpdateSchedule.Name = "buttonUpdateSchedule";
			this.buttonUpdateSchedule.Size = new System.Drawing.Size(190, 23);
			this.buttonUpdateSchedule.TabIndex = 7;
			this.buttonUpdateSchedule.Text = "Update Schedule";
			this.buttonUpdateSchedule.UseVisualStyleBackColor = true;
			this.buttonUpdateSchedule.Click += new System.EventHandler(this.buttonUpdateSchedule_Click);
			// 
			// comboBoxChannel
			// 
			this.comboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChannel.FormattingEnabled = true;
			this.comboBoxChannel.Location = new System.Drawing.Point(881, 71);
			this.comboBoxChannel.Name = "comboBoxChannel";
			this.comboBoxChannel.Size = new System.Drawing.Size(190, 21);
			this.comboBoxChannel.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(820, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Channel:";
			// 
			// checkBoxScheduleEnabled
			// 
			this.checkBoxScheduleEnabled.AutoSize = true;
			this.checkBoxScheduleEnabled.BackColor = System.Drawing.Color.Transparent;
			this.checkBoxScheduleEnabled.Location = new System.Drawing.Point(881, 21);
			this.checkBoxScheduleEnabled.Name = "checkBoxScheduleEnabled";
			this.checkBoxScheduleEnabled.Size = new System.Drawing.Size(65, 17);
			this.checkBoxScheduleEnabled.TabIndex = 9;
			this.checkBoxScheduleEnabled.Text = "Enabled";
			this.checkBoxScheduleEnabled.UseVisualStyleBackColor = false;
			// 
			// scheduleCalendar1
			// 
			this.scheduleCalendar1.BackColor = System.Drawing.Color.RoyalBlue;
			this.scheduleCalendar1.Location = new System.Drawing.Point(12, 47);
			this.scheduleCalendar1.Month = new System.DateTime(((long)(0)));
			this.scheduleCalendar1.Name = "scheduleCalendar1";
			this.scheduleCalendar1.Size = new System.Drawing.Size(801, 549);
			this.scheduleCalendar1.TabIndex = 0;
			// 
			// FormCalendar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 608);
			this.Controls.Add(this.checkBoxScheduleEnabled);
			this.Controls.Add(this.comboBoxChannel);
			this.Controls.Add(this.buttonUpdateSchedule);
			this.Controls.Add(this.dateTimePickerEndDate);
			this.Controls.Add(this.dateTimePickerEndTime);
			this.Controls.Add(this.dateTimePickerStartDate);
			this.Controls.Add(this.dateTimePickerStartTime);
			this.Controls.Add(this.checkBoxSaturday);
			this.Controls.Add(this.checkBoxFriday);
			this.Controls.Add(this.checkBoxThursday);
			this.Controls.Add(this.checkBoxWednesday);
			this.Controls.Add(this.checkBoxTuesday);
			this.Controls.Add(this.checkBoxMonday);
			this.Controls.Add(this.checkBoxSunday);
			this.Controls.Add(this.textBoxScheduleName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.scheduleCalendar1);
			this.Name = "FormCalendar";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormCalendar";
			this.Load += new System.EventHandler(this.FormCalendar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UserControls.ScheduleCalendar scheduleCalendar1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxScheduleName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxSunday;
		private System.Windows.Forms.CheckBox checkBoxMonday;
		private System.Windows.Forms.CheckBox checkBoxTuesday;
		private System.Windows.Forms.CheckBox checkBoxWednesday;
		private System.Windows.Forms.CheckBox checkBoxThursday;
		private System.Windows.Forms.CheckBox checkBoxFriday;
		private System.Windows.Forms.CheckBox checkBoxSaturday;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonUpdateSchedule;
		private System.Windows.Forms.ComboBox comboBoxChannel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxScheduleEnabled;





	}
}