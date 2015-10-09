namespace Bliksem
{
	partial class OutputUserControl
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
			this.labelOutputState = new System.Windows.Forms.Label();
			this.buttonOutputStateToggle = new System.Windows.Forms.Button();
			this.buttonOutputEnableToggle = new System.Windows.Forms.Button();
			this.labelOutputName = new System.Windows.Forms.Label();
			this.labelOutputNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelOutputState
			// 
			this.labelOutputState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.labelOutputState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOutputState.Location = new System.Drawing.Point(3, 35);
			this.labelOutputState.Name = "labelOutputState";
			this.labelOutputState.Size = new System.Drawing.Size(108, 83);
			this.labelOutputState.TabIndex = 20;
			this.labelOutputState.Text = "OFF";
			this.labelOutputState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonOutputStateToggle
			// 
			this.buttonOutputStateToggle.Location = new System.Drawing.Point(3, 121);
			this.buttonOutputStateToggle.Name = "buttonOutputStateToggle";
			this.buttonOutputStateToggle.Size = new System.Drawing.Size(108, 23);
			this.buttonOutputStateToggle.TabIndex = 21;
			this.buttonOutputStateToggle.Text = "Turn On";
			this.buttonOutputStateToggle.UseVisualStyleBackColor = true;
			// 
			// buttonOutputEnableToggle
			// 
			this.buttonOutputEnableToggle.Location = new System.Drawing.Point(3, 150);
			this.buttonOutputEnableToggle.Name = "buttonOutputEnableToggle";
			this.buttonOutputEnableToggle.Size = new System.Drawing.Size(108, 23);
			this.buttonOutputEnableToggle.TabIndex = 20;
			this.buttonOutputEnableToggle.Text = "Disable";
			this.buttonOutputEnableToggle.UseVisualStyleBackColor = true;
			// 
			// labelOutputName
			// 
			this.labelOutputName.Location = new System.Drawing.Point(3, 22);
			this.labelOutputName.Name = "labelOutputName";
			this.labelOutputName.Size = new System.Drawing.Size(108, 13);
			this.labelOutputName.TabIndex = 19;
			this.labelOutputName.Text = "Tune to sign";
			this.labelOutputName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelOutputNumber
			// 
			this.labelOutputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOutputNumber.Location = new System.Drawing.Point(3, 0);
			this.labelOutputNumber.Name = "labelOutputNumber";
			this.labelOutputNumber.Size = new System.Drawing.Size(108, 22);
			this.labelOutputNumber.TabIndex = 0;
			this.labelOutputNumber.Text = "1";
			this.labelOutputNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// OutputUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.labelOutputState);
			this.Controls.Add(this.buttonOutputStateToggle);
			this.Controls.Add(this.buttonOutputEnableToggle);
			this.Controls.Add(this.labelOutputNumber);
			this.Controls.Add(this.labelOutputName);
			this.Name = "OutputUserControl";
			this.Size = new System.Drawing.Size(116, 183);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelOutputState;
		private System.Windows.Forms.Button buttonOutputStateToggle;
		private System.Windows.Forms.Button buttonOutputEnableToggle;
		private System.Windows.Forms.Label labelOutputName;
		private System.Windows.Forms.Label labelOutputNumber;
	}
}
