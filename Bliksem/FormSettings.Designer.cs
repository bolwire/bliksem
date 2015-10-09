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
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(15, 120);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(65, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(86, 120);
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
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(173, 147);
			this.ControlBox = false;
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
	}
}