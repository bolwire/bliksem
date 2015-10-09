namespace Bliksem
{
	partial class ScheduleManager
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
			this.btn_New = new System.Windows.Forms.Button();
			this.btn_Apply = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_ScheduleName = new System.Windows.Forms.TextBox();
			this.cb_Schedule = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_Outputs = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.labelDuration = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dateEndTime = new System.Windows.Forms.DateTimePicker();
			this.dateStartTime = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkSaturday = new System.Windows.Forms.CheckBox();
			this.checkSunday = new System.Windows.Forms.CheckBox();
			this.checkMonday = new System.Windows.Forms.CheckBox();
			this.checkFriday = new System.Windows.Forms.CheckBox();
			this.checkTuesday = new System.Windows.Forms.CheckBox();
			this.checkWednesday = new System.Windows.Forms.CheckBox();
			this.checkThursday = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateStop = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dateStart = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.checkEnabled = new System.Windows.Forms.CheckBox();
			this.btn_OK = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_New
			// 
			this.btn_New.Location = new System.Drawing.Point(237, 10);
			this.btn_New.Name = "btn_New";
			this.btn_New.Size = new System.Drawing.Size(75, 23);
			this.btn_New.TabIndex = 0;
			this.btn_New.Text = "New";
			this.btn_New.UseVisualStyleBackColor = true;
			this.btn_New.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// btn_Apply
			// 
			this.btn_Apply.Location = new System.Drawing.Point(237, 64);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(75, 23);
			this.btn_Apply.TabIndex = 1;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.UseVisualStyleBackColor = true;
			this.btn_Apply.Visible = false;
			this.btn_Apply.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Schedule Name";
			// 
			// txt_ScheduleName
			// 
			this.txt_ScheduleName.Location = new System.Drawing.Point(101, 67);
			this.txt_ScheduleName.Name = "txt_ScheduleName";
			this.txt_ScheduleName.Size = new System.Drawing.Size(121, 20);
			this.txt_ScheduleName.TabIndex = 5;
			this.txt_ScheduleName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ScheduleName_KeyUp);
			// 
			// cb_Schedule
			// 
			this.cb_Schedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Schedule.FormattingEnabled = true;
			this.cb_Schedule.Location = new System.Drawing.Point(101, 12);
			this.cb_Schedule.Name = "cb_Schedule";
			this.cb_Schedule.Size = new System.Drawing.Size(121, 21);
			this.cb_Schedule.TabIndex = 6;
			this.cb_Schedule.SelectedIndexChanged += new System.EventHandler(this.cb_Schedule_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Schedule";
			// 
			// cb_Outputs
			// 
			this.cb_Outputs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Outputs.FormattingEnabled = true;
			this.cb_Outputs.Location = new System.Drawing.Point(101, 39);
			this.cb_Outputs.Name = "cb_Outputs";
			this.cb_Outputs.Size = new System.Drawing.Size(121, 21);
			this.cb_Outputs.TabIndex = 8;
			this.cb_Outputs.SelectedIndexChanged += new System.EventHandler(this.cb_Outputs_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Output";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.labelDuration);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.dateEndTime);
			this.groupBox3.Controls.Add(this.dateStartTime);
			this.groupBox3.Location = new System.Drawing.Point(12, 276);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(308, 69);
			this.groupBox3.TabIndex = 67;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Time:";
			// 
			// labelDuration
			// 
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(62, 47);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(39, 13);
			this.labelDuration.TabIndex = 72;
			this.labelDuration.Text = "(hours)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(157, 28);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 13);
			this.label9.TabIndex = 71;
			this.label9.Text = "End Time:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 70;
			this.label5.Text = "Start Time:";
			// 
			// dateEndTime
			// 
			this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateEndTime.Location = new System.Drawing.Point(214, 24);
			this.dateEndTime.Name = "dateEndTime";
			this.dateEndTime.ShowUpDown = true;
			this.dateEndTime.Size = new System.Drawing.Size(86, 20);
			this.dateEndTime.TabIndex = 69;
			this.dateEndTime.ValueChanged += new System.EventHandler(this.dateEndTime_ValueChanged);
			// 
			// dateStartTime
			// 
			this.dateStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateStartTime.Location = new System.Drawing.Point(65, 24);
			this.dateStartTime.Name = "dateStartTime";
			this.dateStartTime.ShowUpDown = true;
			this.dateStartTime.Size = new System.Drawing.Size(86, 20);
			this.dateStartTime.TabIndex = 68;
			this.dateStartTime.ValueChanged += new System.EventHandler(this.dateStartTime_ValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkSaturday);
			this.groupBox2.Controls.Add(this.checkSunday);
			this.groupBox2.Controls.Add(this.checkMonday);
			this.groupBox2.Controls.Add(this.checkFriday);
			this.groupBox2.Controls.Add(this.checkTuesday);
			this.groupBox2.Controls.Add(this.checkWednesday);
			this.groupBox2.Controls.Add(this.checkThursday);
			this.groupBox2.Location = new System.Drawing.Point(12, 199);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(308, 71);
			this.groupBox2.TabIndex = 66;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Days:";
			// 
			// checkSaturday
			// 
			this.checkSaturday.AutoSize = true;
			this.checkSaturday.Location = new System.Drawing.Point(150, 44);
			this.checkSaturday.Name = "checkSaturday";
			this.checkSaturday.Size = new System.Drawing.Size(68, 17);
			this.checkSaturday.TabIndex = 12;
			this.checkSaturday.Text = "Saturday";
			this.checkSaturday.UseVisualStyleBackColor = true;
			this.checkSaturday.CheckedChanged += new System.EventHandler(this.checkSaturday_CheckedChanged);
			// 
			// checkSunday
			// 
			this.checkSunday.AutoSize = true;
			this.checkSunday.Location = new System.Drawing.Point(9, 21);
			this.checkSunday.Name = "checkSunday";
			this.checkSunday.Size = new System.Drawing.Size(62, 17);
			this.checkSunday.TabIndex = 6;
			this.checkSunday.Text = "Sunday";
			this.checkSunday.UseVisualStyleBackColor = true;
			this.checkSunday.CheckedChanged += new System.EventHandler(this.checkSunday_CheckedChanged);
			// 
			// checkMonday
			// 
			this.checkMonday.AutoSize = true;
			this.checkMonday.Location = new System.Drawing.Point(80, 21);
			this.checkMonday.Name = "checkMonday";
			this.checkMonday.Size = new System.Drawing.Size(64, 17);
			this.checkMonday.TabIndex = 7;
			this.checkMonday.Text = "Monday";
			this.checkMonday.UseVisualStyleBackColor = true;
			this.checkMonday.CheckedChanged += new System.EventHandler(this.checkMonday_CheckedChanged);
			// 
			// checkFriday
			// 
			this.checkFriday.AutoSize = true;
			this.checkFriday.Location = new System.Drawing.Point(80, 44);
			this.checkFriday.Name = "checkFriday";
			this.checkFriday.Size = new System.Drawing.Size(54, 17);
			this.checkFriday.TabIndex = 11;
			this.checkFriday.Text = "Friday";
			this.checkFriday.UseVisualStyleBackColor = true;
			this.checkFriday.CheckedChanged += new System.EventHandler(this.checkFriday_CheckedChanged);
			// 
			// checkTuesday
			// 
			this.checkTuesday.AutoSize = true;
			this.checkTuesday.Location = new System.Drawing.Point(150, 21);
			this.checkTuesday.Name = "checkTuesday";
			this.checkTuesday.Size = new System.Drawing.Size(67, 17);
			this.checkTuesday.TabIndex = 8;
			this.checkTuesday.Text = "Tuesday";
			this.checkTuesday.UseVisualStyleBackColor = true;
			this.checkTuesday.CheckedChanged += new System.EventHandler(this.checkTuesday_CheckedChanged);
			// 
			// checkWednesday
			// 
			this.checkWednesday.AutoSize = true;
			this.checkWednesday.Location = new System.Drawing.Point(221, 21);
			this.checkWednesday.Name = "checkWednesday";
			this.checkWednesday.Size = new System.Drawing.Size(83, 17);
			this.checkWednesday.TabIndex = 9;
			this.checkWednesday.Text = "Wednesday";
			this.checkWednesday.UseVisualStyleBackColor = true;
			this.checkWednesday.CheckedChanged += new System.EventHandler(this.checkWednesday_CheckedChanged);
			// 
			// checkThursday
			// 
			this.checkThursday.AutoSize = true;
			this.checkThursday.Location = new System.Drawing.Point(9, 44);
			this.checkThursday.Name = "checkThursday";
			this.checkThursday.Size = new System.Drawing.Size(70, 17);
			this.checkThursday.TabIndex = 10;
			this.checkThursday.Text = "Thursday";
			this.checkThursday.UseVisualStyleBackColor = true;
			this.checkThursday.CheckedChanged += new System.EventHandler(this.checkThursday_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateStop);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dateStart);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(12, 116);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(308, 77);
			this.groupBox1.TabIndex = 65;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dates:";
			// 
			// dateStop
			// 
			this.dateStop.Location = new System.Drawing.Point(44, 47);
			this.dateStop.Name = "dateStop";
			this.dateStop.Size = new System.Drawing.Size(200, 20);
			this.dateStop.TabIndex = 8;
			this.dateStop.CloseUp += new System.EventHandler(this.dateStop_CloseUp);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Stop:";
			// 
			// dateStart
			// 
			this.dateStart.CustomFormat = "";
			this.dateStart.Location = new System.Drawing.Point(44, 22);
			this.dateStart.Name = "dateStart";
			this.dateStart.Size = new System.Drawing.Size(200, 20);
			this.dateStart.TabIndex = 6;
			this.dateStart.CloseUp += new System.EventHandler(this.dateStart_CloseUp);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Start:";
			// 
			// checkEnabled
			// 
			this.checkEnabled.AutoSize = true;
			this.checkEnabled.Location = new System.Drawing.Point(101, 93);
			this.checkEnabled.Name = "checkEnabled";
			this.checkEnabled.Size = new System.Drawing.Size(113, 17);
			this.checkEnabled.TabIndex = 68;
			this.checkEnabled.Text = "Schedule Enabled";
			this.checkEnabled.UseVisualStyleBackColor = true;
			this.checkEnabled.CheckedChanged += new System.EventHandler(this.checkEnabled_CheckedChanged);
			// 
			// btn_OK
			// 
			this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_OK.Location = new System.Drawing.Point(245, 351);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(75, 23);
			this.btn_OK.TabIndex = 69;
			this.btn_OK.Text = "OK";
			this.btn_OK.UseVisualStyleBackColor = true;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(164, 351);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 70;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(237, 37);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 71;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// ScheduleManager
			// 
			this.AcceptButton = this.btn_OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(329, 382);
			this.ControlBox = false;
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.checkEnabled);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cb_Outputs);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cb_Schedule);
			this.Controls.Add(this.txt_ScheduleName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_New);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ScheduleManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Schedule Manager";
			this.Load += new System.EventHandler(this.ScheduleManager_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_New;
		private System.Windows.Forms.Button btn_Apply;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_ScheduleName;
		private System.Windows.Forms.ComboBox cb_Schedule;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cb_Outputs;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label labelDuration;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateEndTime;
		private System.Windows.Forms.DateTimePicker dateStartTime;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkSaturday;
		private System.Windows.Forms.CheckBox checkSunday;
		private System.Windows.Forms.CheckBox checkMonday;
		private System.Windows.Forms.CheckBox checkFriday;
		private System.Windows.Forms.CheckBox checkTuesday;
		private System.Windows.Forms.CheckBox checkWednesday;
		private System.Windows.Forms.CheckBox checkThursday;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateStop;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateStart;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkEnabled;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_delete;

	}
}