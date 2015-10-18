namespace Bliksem
{
	partial class FormSettings
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.checkBoxLogWindowAtStart = new System.Windows.Forms.CheckBox();
			this.checkBoxConfirmExit = new System.Windows.Forms.CheckBox();
			this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxWindowCaption = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxDataFolder = new System.Windows.Forms.TextBox();
			this.buttonBrowseFolder = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(384, 196);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(65, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(455, 196);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// checkBoxLogWindowAtStart
			// 
			this.checkBoxLogWindowAtStart.AutoSize = true;
			this.checkBoxLogWindowAtStart.Checked = global::Bliksem.Properties.Settings.Default.LogWindowAtStart;
			this.checkBoxLogWindowAtStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Bliksem.Properties.Settings.Default, "LogWindowAtStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxLogWindowAtStart.Location = new System.Drawing.Point(12, 58);
			this.checkBoxLogWindowAtStart.Name = "checkBoxLogWindowAtStart";
			this.checkBoxLogWindowAtStart.Size = new System.Drawing.Size(158, 17);
			this.checkBoxLogWindowAtStart.TabIndex = 2;
			this.checkBoxLogWindowAtStart.Text = "Open log winodw on startup";
			this.checkBoxLogWindowAtStart.UseVisualStyleBackColor = true;
			// 
			// checkBoxConfirmExit
			// 
			this.checkBoxConfirmExit.AutoSize = true;
			this.checkBoxConfirmExit.Checked = global::Bliksem.Properties.Settings.Default.ConfirmAppClose;
			this.checkBoxConfirmExit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Bliksem.Properties.Settings.Default, "ConfirmAppClose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxConfirmExit.Location = new System.Drawing.Point(12, 35);
			this.checkBoxConfirmExit.Name = "checkBoxConfirmExit";
			this.checkBoxConfirmExit.Size = new System.Drawing.Size(143, 17);
			this.checkBoxConfirmExit.TabIndex = 1;
			this.checkBoxConfirmExit.Text = "Confirm application close";
			this.checkBoxConfirmExit.UseVisualStyleBackColor = true;
			// 
			// checkBoxMinimizeToTray
			// 
			this.checkBoxMinimizeToTray.AutoSize = true;
			this.checkBoxMinimizeToTray.Checked = global::Bliksem.Properties.Settings.Default.MinimizeToTray;
			this.checkBoxMinimizeToTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Bliksem.Properties.Settings.Default, "MinimizeToTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(12, 12);
			this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
			this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(133, 17);
			this.checkBoxMinimizeToTray.TabIndex = 0;
			this.checkBoxMinimizeToTray.Text = "Minimize to system tray";
			this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Main Window Caption";
			// 
			// textBoxWindowCaption
			// 
			this.textBoxWindowCaption.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Bliksem.Properties.Settings.Default, "WindowCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxWindowCaption.Location = new System.Drawing.Point(15, 94);
			this.textBoxWindowCaption.Name = "textBoxWindowCaption";
			this.textBoxWindowCaption.Size = new System.Drawing.Size(146, 20);
			this.textBoxWindowCaption.TabIndex = 5;
			this.textBoxWindowCaption.Text = global::Bliksem.Properties.Settings.Default.WindowCaption;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.buttonBrowseFolder);
			this.groupBox1.Controls.Add(this.textBoxDataFolder);
			this.groupBox1.Location = new System.Drawing.Point(12, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(518, 70);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Save Folder";
			// 
			// textBoxDataFolder
			// 
			this.textBoxDataFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Bliksem.Properties.Settings.Default, "DataPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxDataFolder.Location = new System.Drawing.Point(6, 43);
			this.textBoxDataFolder.Name = "textBoxDataFolder";
			this.textBoxDataFolder.Size = new System.Drawing.Size(431, 20);
			this.textBoxDataFolder.TabIndex = 0;
			this.textBoxDataFolder.Text = global::Bliksem.Properties.Settings.Default.DataPath;
			// 
			// buttonBrowseFolder
			// 
			this.buttonBrowseFolder.Location = new System.Drawing.Point(443, 41);
			this.buttonBrowseFolder.Name = "buttonBrowseFolder";
			this.buttonBrowseFolder.Size = new System.Drawing.Size(69, 23);
			this.buttonBrowseFolder.TabIndex = 7;
			this.buttonBrowseFolder.Text = "Browse";
			this.buttonBrowseFolder.UseVisualStyleBackColor = true;
			this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(310, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "If blank, default location of My Documents\\Bliksem\\ will be used";
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 227);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxWindowCaption);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.checkBoxLogWindowAtStart);
			this.Controls.Add(this.checkBoxConfirmExit);
			this.Controls.Add(this.checkBoxMinimizeToTray);
			this.Name = "FormSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
		private System.Windows.Forms.CheckBox checkBoxConfirmExit;
		private System.Windows.Forms.CheckBox checkBoxLogWindowAtStart;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxWindowCaption;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonBrowseFolder;
		private System.Windows.Forms.TextBox textBoxDataFolder;
		private System.Windows.Forms.Label label2;
	}
}