namespace Bliksem.UserControls
{
	partial class OutputControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelOutputName = new System.Windows.Forms.Label();
			this.pictureBoxOutputControl = new System.Windows.Forms.PictureBox();
			this.pictureBoxState = new System.Windows.Forms.PictureBox();
			this.buttonToggleEnable = new System.Windows.Forms.Button();
			this.buttonToggleOn = new System.Windows.Forms.Button();
			this.labelOutputNumber = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutputControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxState)).BeginInit();
			this.SuspendLayout();
			// 
			// labelOutputName
			// 
			this.labelOutputName.AutoSize = true;
			this.labelOutputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOutputName.Location = new System.Drawing.Point(66, 4);
			this.labelOutputName.Name = "labelOutputName";
			this.labelOutputName.Size = new System.Drawing.Size(86, 20);
			this.labelOutputName.TabIndex = 1;
			this.labelOutputName.Text = "OUTPUT 1";
			// 
			// pictureBoxOutputControl
			// 
			this.pictureBoxOutputControl.Image = global::Bliksem.Properties.Resources.settings;
			this.pictureBoxOutputControl.Location = new System.Drawing.Point(213, 3);
			this.pictureBoxOutputControl.Name = "pictureBoxOutputControl";
			this.pictureBoxOutputControl.Size = new System.Drawing.Size(24, 24);
			this.pictureBoxOutputControl.TabIndex = 2;
			this.pictureBoxOutputControl.TabStop = false;
			this.pictureBoxOutputControl.Click += new System.EventHandler(this.pictureBoxOutputControl_Click);
			// 
			// pictureBoxState
			// 
			this.pictureBoxState.Image = global::Bliksem.Properties.Resources.yellow_LL;
			this.pictureBoxState.Location = new System.Drawing.Point(36, 3);
			this.pictureBoxState.Name = "pictureBoxState";
			this.pictureBoxState.Size = new System.Drawing.Size(24, 24);
			this.pictureBoxState.TabIndex = 0;
			this.pictureBoxState.TabStop = false;
			// 
			// buttonToggleEnable
			// 
			this.buttonToggleEnable.Location = new System.Drawing.Point(66, 4);
			this.buttonToggleEnable.Name = "buttonToggleEnable";
			this.buttonToggleEnable.Size = new System.Drawing.Size(64, 23);
			this.buttonToggleEnable.TabIndex = 3;
			this.buttonToggleEnable.Text = "Disable";
			this.buttonToggleEnable.UseVisualStyleBackColor = true;
			this.buttonToggleEnable.Click += new System.EventHandler(this.buttonToggleEnable_Click);
			// 
			// buttonToggleOn
			// 
			this.buttonToggleOn.Location = new System.Drawing.Point(143, 4);
			this.buttonToggleOn.Name = "buttonToggleOn";
			this.buttonToggleOn.Size = new System.Drawing.Size(64, 23);
			this.buttonToggleOn.TabIndex = 4;
			this.buttonToggleOn.Text = "Turn On";
			this.buttonToggleOn.UseVisualStyleBackColor = true;
			this.buttonToggleOn.Click += new System.EventHandler(this.buttonToggleOn_Click);
			// 
			// labelOutputNumber
			// 
			this.labelOutputNumber.AutoSize = true;
			this.labelOutputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOutputNumber.Location = new System.Drawing.Point(3, 4);
			this.labelOutputNumber.Name = "labelOutputNumber";
			this.labelOutputNumber.Size = new System.Drawing.Size(18, 20);
			this.labelOutputNumber.TabIndex = 1;
			this.labelOutputNumber.Text = "1";
			this.labelOutputNumber.Click += new System.EventHandler(this.labelOutputNumber_Click);
			// 
			// OutputControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonToggleOn);
			this.Controls.Add(this.buttonToggleEnable);
			this.Controls.Add(this.pictureBoxOutputControl);
			this.Controls.Add(this.labelOutputNumber);
			this.Controls.Add(this.labelOutputName);
			this.Controls.Add(this.pictureBoxState);
			this.Name = "OutputControl";
			this.Size = new System.Drawing.Size(242, 30);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutputControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxState)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxState;
		private System.Windows.Forms.Label labelOutputName;
		private System.Windows.Forms.PictureBox pictureBoxOutputControl;
		private System.Windows.Forms.Button buttonToggleEnable;
		private System.Windows.Forms.Button buttonToggleOn;
		private System.Windows.Forms.Label labelOutputNumber;
	}
}
