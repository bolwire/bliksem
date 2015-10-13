namespace Bliksem
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.serialPortSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editSchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editOutputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tmr_UpdateStateButtons = new System.Windows.Forms.Timer(this.components);
			this.tmr_CheckSchedule = new System.Windows.Forms.Timer(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.outputControl9 = new Bliksem.UserControls.OutputControl();
			this.outputControl8 = new Bliksem.UserControls.OutputControl();
			this.outputControl7 = new Bliksem.UserControls.OutputControl();
			this.outputControl6 = new Bliksem.UserControls.OutputControl();
			this.outputControl5 = new Bliksem.UserControls.OutputControl();
			this.outputControl4 = new Bliksem.UserControls.OutputControl();
			this.outputControl3 = new Bliksem.UserControls.OutputControl();
			this.outputControl2 = new Bliksem.UserControls.OutputControl();
			this.outputControl1 = new Bliksem.UserControls.OutputControl();
			this.outputControl10 = new Bliksem.UserControls.OutputControl();
			this.outputControl11 = new Bliksem.UserControls.OutputControl();
			this.outputControl12 = new Bliksem.UserControls.OutputControl();
			this.outputControl13 = new Bliksem.UserControls.OutputControl();
			this.outputControl14 = new Bliksem.UserControls.OutputControl();
			this.outputControl15 = new Bliksem.UserControls.OutputControl();
			this.outputControl16 = new Bliksem.UserControls.OutputControl();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortSetupToolStripMenuItem,
            this.editSchedulesToolStripMenuItem,
            this.editOutputsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logWindowToolStripMenuItem,
            this.showCalendarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(543, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// serialPortSetupToolStripMenuItem
			// 
			this.serialPortSetupToolStripMenuItem.Name = "serialPortSetupToolStripMenuItem";
			this.serialPortSetupToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.serialPortSetupToolStripMenuItem.Text = "Serial Port Setup";
			this.serialPortSetupToolStripMenuItem.Click += new System.EventHandler(this.serialPortSetupToolStripMenuItem_Click);
			// 
			// editSchedulesToolStripMenuItem
			// 
			this.editSchedulesToolStripMenuItem.Name = "editSchedulesToolStripMenuItem";
			this.editSchedulesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			this.editSchedulesToolStripMenuItem.Text = "Edit Schedules";
			this.editSchedulesToolStripMenuItem.Click += new System.EventHandler(this.editSchedulesToolStripMenuItem_Click);
			// 
			// editOutputsToolStripMenuItem
			// 
			this.editOutputsToolStripMenuItem.Name = "editOutputsToolStripMenuItem";
			this.editOutputsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.editOutputsToolStripMenuItem.Text = "Edit Outputs";
			this.editOutputsToolStripMenuItem.Click += new System.EventHandler(this.editOutputsToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// logWindowToolStripMenuItem
			// 
			this.logWindowToolStripMenuItem.Name = "logWindowToolStripMenuItem";
			this.logWindowToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.logWindowToolStripMenuItem.Text = "Log Window";
			this.logWindowToolStripMenuItem.Click += new System.EventHandler(this.logWindowToolStripMenuItem_Click);
			// 
			// showCalendarToolStripMenuItem
			// 
			this.showCalendarToolStripMenuItem.Name = "showCalendarToolStripMenuItem";
			this.showCalendarToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.showCalendarToolStripMenuItem.Text = "Show Calendar";
			this.showCalendarToolStripMenuItem.Click += new System.EventHandler(this.showCalendarToolStripMenuItem_Click);
			// 
			// tmr_UpdateStateButtons
			// 
			this.tmr_UpdateStateButtons.Enabled = true;
			this.tmr_UpdateStateButtons.Interval = 1000;
			this.tmr_UpdateStateButtons.Tick += new System.EventHandler(this.tmr_UpdateStateButtons_Tick);
			// 
			// tmr_CheckSchedule
			// 
			this.tmr_CheckSchedule.Enabled = true;
			this.tmr_CheckSchedule.Interval = 1000;
			this.tmr_CheckSchedule.Tick += new System.EventHandler(this.tmr_CheckSchedule_Tick);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Text = "Blikesem 2015";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// outputControl9
			// 
			this.outputControl9.Location = new System.Drawing.Point(289, 27);
			this.outputControl9.Name = "outputControl9";
			this.outputControl9.OutputName = "OUTPUT 9";
			this.outputControl9.OutputNumber = 9;
			this.outputControl9.Size = new System.Drawing.Size(242, 30);
			this.outputControl9.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl9.TabIndex = 37;
			// 
			// outputControl8
			// 
			this.outputControl8.Location = new System.Drawing.Point(12, 279);
			this.outputControl8.Name = "outputControl8";
			this.outputControl8.OutputName = "OUTPUT 8";
			this.outputControl8.OutputNumber = 8;
			this.outputControl8.Size = new System.Drawing.Size(242, 30);
			this.outputControl8.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl8.TabIndex = 36;
			// 
			// outputControl7
			// 
			this.outputControl7.Location = new System.Drawing.Point(12, 243);
			this.outputControl7.Name = "outputControl7";
			this.outputControl7.OutputName = "OUTPUT 7";
			this.outputControl7.OutputNumber = 7;
			this.outputControl7.Size = new System.Drawing.Size(242, 30);
			this.outputControl7.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl7.TabIndex = 35;
			// 
			// outputControl6
			// 
			this.outputControl6.Location = new System.Drawing.Point(12, 207);
			this.outputControl6.Name = "outputControl6";
			this.outputControl6.OutputName = "OUTPUT 6";
			this.outputControl6.OutputNumber = 6;
			this.outputControl6.Size = new System.Drawing.Size(242, 30);
			this.outputControl6.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl6.TabIndex = 34;
			// 
			// outputControl5
			// 
			this.outputControl5.Location = new System.Drawing.Point(12, 171);
			this.outputControl5.Name = "outputControl5";
			this.outputControl5.OutputName = "OUTPUT 5";
			this.outputControl5.OutputNumber = 5;
			this.outputControl5.Size = new System.Drawing.Size(242, 30);
			this.outputControl5.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl5.TabIndex = 34;
			// 
			// outputControl4
			// 
			this.outputControl4.Location = new System.Drawing.Point(12, 135);
			this.outputControl4.Name = "outputControl4";
			this.outputControl4.OutputName = "OUTPUT 4";
			this.outputControl4.OutputNumber = 4;
			this.outputControl4.Size = new System.Drawing.Size(242, 30);
			this.outputControl4.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl4.TabIndex = 34;
			// 
			// outputControl3
			// 
			this.outputControl3.Location = new System.Drawing.Point(12, 99);
			this.outputControl3.Name = "outputControl3";
			this.outputControl3.OutputName = "OUTPUT 3";
			this.outputControl3.OutputNumber = 3;
			this.outputControl3.Size = new System.Drawing.Size(242, 30);
			this.outputControl3.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl3.TabIndex = 34;
			// 
			// outputControl2
			// 
			this.outputControl2.Location = new System.Drawing.Point(12, 63);
			this.outputControl2.Name = "outputControl2";
			this.outputControl2.OutputName = "OUTPUT 2";
			this.outputControl2.OutputNumber = 2;
			this.outputControl2.Size = new System.Drawing.Size(242, 30);
			this.outputControl2.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl2.TabIndex = 34;
			// 
			// outputControl1
			// 
			this.outputControl1.Location = new System.Drawing.Point(12, 27);
			this.outputControl1.Name = "outputControl1";
			this.outputControl1.OutputName = "OUTPUT 1";
			this.outputControl1.OutputNumber = 1;
			this.outputControl1.Size = new System.Drawing.Size(242, 30);
			this.outputControl1.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl1.TabIndex = 34;
			// 
			// outputControl10
			// 
			this.outputControl10.Location = new System.Drawing.Point(289, 63);
			this.outputControl10.Name = "outputControl10";
			this.outputControl10.OutputName = "OUTPUT 10";
			this.outputControl10.OutputNumber = 10;
			this.outputControl10.Size = new System.Drawing.Size(242, 30);
			this.outputControl10.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl10.TabIndex = 38;
			// 
			// outputControl11
			// 
			this.outputControl11.Location = new System.Drawing.Point(289, 99);
			this.outputControl11.Name = "outputControl11";
			this.outputControl11.OutputName = "OUTPUT 11";
			this.outputControl11.OutputNumber = 11;
			this.outputControl11.Size = new System.Drawing.Size(242, 30);
			this.outputControl11.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl11.TabIndex = 39;
			// 
			// outputControl12
			// 
			this.outputControl12.Location = new System.Drawing.Point(289, 135);
			this.outputControl12.Name = "outputControl12";
			this.outputControl12.OutputName = "OUTPUT 12";
			this.outputControl12.OutputNumber = 12;
			this.outputControl12.Size = new System.Drawing.Size(242, 30);
			this.outputControl12.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl12.TabIndex = 40;
			// 
			// outputControl13
			// 
			this.outputControl13.Location = new System.Drawing.Point(289, 171);
			this.outputControl13.Name = "outputControl13";
			this.outputControl13.OutputName = "OUTPUT 13";
			this.outputControl13.OutputNumber = 13;
			this.outputControl13.Size = new System.Drawing.Size(242, 30);
			this.outputControl13.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl13.TabIndex = 41;
			// 
			// outputControl14
			// 
			this.outputControl14.Location = new System.Drawing.Point(289, 207);
			this.outputControl14.Name = "outputControl14";
			this.outputControl14.OutputName = "OUTPUT 14";
			this.outputControl14.OutputNumber = 14;
			this.outputControl14.Size = new System.Drawing.Size(242, 30);
			this.outputControl14.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl14.TabIndex = 42;
			// 
			// outputControl15
			// 
			this.outputControl15.Location = new System.Drawing.Point(289, 243);
			this.outputControl15.Name = "outputControl15";
			this.outputControl15.OutputName = "OUTPUT 15";
			this.outputControl15.OutputNumber = 15;
			this.outputControl15.Size = new System.Drawing.Size(242, 30);
			this.outputControl15.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl15.TabIndex = 43;
			// 
			// outputControl16
			// 
			this.outputControl16.Location = new System.Drawing.Point(289, 279);
			this.outputControl16.Name = "outputControl16";
			this.outputControl16.OutputName = "OUTPUT 16";
			this.outputControl16.OutputNumber = 16;
			this.outputControl16.Size = new System.Drawing.Size(242, 30);
			this.outputControl16.State = Bliksem.UserControls.OutputState.Enabled;
			this.outputControl16.TabIndex = 44;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 314);
			this.Controls.Add(this.outputControl16);
			this.Controls.Add(this.outputControl15);
			this.Controls.Add(this.outputControl14);
			this.Controls.Add(this.outputControl13);
			this.Controls.Add(this.outputControl12);
			this.Controls.Add(this.outputControl11);
			this.Controls.Add(this.outputControl10);
			this.Controls.Add(this.outputControl9);
			this.Controls.Add(this.outputControl8);
			this.Controls.Add(this.outputControl7);
			this.Controls.Add(this.outputControl6);
			this.Controls.Add(this.outputControl5);
			this.Controls.Add(this.outputControl4);
			this.Controls.Add(this.outputControl3);
			this.Controls.Add(this.outputControl2);
			this.Controls.Add(this.outputControl1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bliksem Control Center (2015)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bliksem_OnFormClosing);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Timer tmr_UpdateStateButtons;
		private System.Windows.Forms.ToolStripMenuItem serialPortSetupToolStripMenuItem;
		private System.Windows.Forms.Timer tmr_CheckSchedule;
		private System.Windows.Forms.ToolStripMenuItem editSchedulesToolStripMenuItem;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.ToolStripMenuItem editOutputsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logWindowToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolStripMenuItem showCalendarToolStripMenuItem;
		private UserControls.OutputControl outputControl1;
		private UserControls.OutputControl outputControl2;
		private UserControls.OutputControl outputControl3;
		private UserControls.OutputControl outputControl4;
		private UserControls.OutputControl outputControl5;
		private UserControls.OutputControl outputControl6;
		private UserControls.OutputControl outputControl7;
		private UserControls.OutputControl outputControl8;
		private UserControls.OutputControl outputControl9;
		private UserControls.OutputControl outputControl10;
		private UserControls.OutputControl outputControl11;
		private UserControls.OutputControl outputControl12;
		private UserControls.OutputControl outputControl13;
		private UserControls.OutputControl outputControl14;
		private UserControls.OutputControl outputControl15;
		private UserControls.OutputControl outputControl16;
	}
}

