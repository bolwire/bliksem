using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bliksem
{
	public partial class LogWindow : Form
	{
		public LogWindow()
		{
			InitializeComponent();
		}
		public void AddLog(string message)
		{
			listBox1.Items.Add(DateTime.Now + ": " + message);
		}

		private void buttonSaveLog_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog {Filter = @"Text File | .txt"})
			{
				if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

				SaveLogFile(saveFileDialog.FileName);
			}
		}

		private void SaveLogFile(string sPath)
		{
			System.IO.StreamWriter saveFile = new System.IO.StreamWriter(sPath);

			foreach (var line in listBox1.Items)
			{
				saveFile.WriteLine(line);
			}

			saveFile.Flush();
			saveFile.Close();

			if (MessageBox.Show(@"Log saved, would you like to view in notepad", @"Log saved", MessageBoxButtons.YesNo,MessageBoxIcon.Question)
				== DialogResult.Yes)
			{
				Process.Start(sPath);
			}
		}
	}
}
