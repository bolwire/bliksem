namespace Bliksem
{
	partial class OutputManager
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
			this.cb_Outputs = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_OutputName = new System.Windows.Forms.TextBox();
			this.cb_OutputEnabled = new System.Windows.Forms.CheckBox();
			this.btn_Apply = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_OK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cb_Outputs
			// 
			this.cb_Outputs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Outputs.FormattingEnabled = true;
			this.cb_Outputs.Location = new System.Drawing.Point(64, 12);
			this.cb_Outputs.Name = "cb_Outputs";
			this.cb_Outputs.Size = new System.Drawing.Size(192, 21);
			this.cb_Outputs.TabIndex = 0;
			this.cb_Outputs.SelectedIndexChanged += new System.EventHandler(this.cb_Outputs_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Channel";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// tb_OutputName
			// 
			this.tb_OutputName.Location = new System.Drawing.Point(64, 39);
			this.tb_OutputName.Name = "tb_OutputName";
			this.tb_OutputName.Size = new System.Drawing.Size(192, 20);
			this.tb_OutputName.TabIndex = 3;
			this.tb_OutputName.TextChanged += new System.EventHandler(this.tb_OutputName_TextChanged);
			// 
			// cb_OutputEnabled
			// 
			this.cb_OutputEnabled.AutoSize = true;
			this.cb_OutputEnabled.Location = new System.Drawing.Point(64, 65);
			this.cb_OutputEnabled.Name = "cb_OutputEnabled";
			this.cb_OutputEnabled.Size = new System.Drawing.Size(65, 17);
			this.cb_OutputEnabled.TabIndex = 4;
			this.cb_OutputEnabled.Text = "Enabled";
			this.cb_OutputEnabled.UseVisualStyleBackColor = true;
			this.cb_OutputEnabled.CheckedChanged += new System.EventHandler(this.cb_OutputEnabled_CheckedChanged);
			// 
			// btn_Apply
			// 
			this.btn_Apply.Location = new System.Drawing.Point(19, 86);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(75, 23);
			this.btn_Apply.TabIndex = 5;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.UseVisualStyleBackColor = true;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(100, 86);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 6;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_OK
			// 
			this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_OK.Location = new System.Drawing.Point(181, 86);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(75, 23);
			this.btn_OK.TabIndex = 7;
			this.btn_OK.Text = "OK";
			this.btn_OK.UseVisualStyleBackColor = true;
			// 
			// OutputManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 121);
			this.ControlBox = false;
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.cb_OutputEnabled);
			this.Controls.Add(this.tb_OutputName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_Outputs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OutputManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Output Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutputManager_FormClosing);
			this.Load += new System.EventHandler(this.OutputManager_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_Outputs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_OutputName;
		private System.Windows.Forms.CheckBox cb_OutputEnabled;
		private System.Windows.Forms.Button btn_Apply;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_OK;
	}
}