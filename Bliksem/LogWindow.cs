using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bliksem
{
	public partial class LogWindow : Form
	{
		public LogWindow()
		{
			InitializeComponent();

			EventLogger.NewEventAdded += (eventText) => listBox1.Items.Add(eventText);
			EventLogger.EventsCleared += () => listBox1.Items.Clear();

			GetEventList();
		}

		private void GetEventList()
		{
			listBox1.Items.Clear();

			foreach (string eString in EventLogger.EventList)
			{
				listBox1.Items.Add(eString);
			}
		}

		private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = @"Text File | .txt" })
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

			DialogResult result = MessageBox.Show(@"Log saved, would you like to view in notepad", @"Log saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if (result == DialogResult.Yes)
			{
				Process.Start(sPath);
			}
		}

		private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(@"Are you sure ?", @"Confirm: Clear log", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				EventLogger.Clear();
			}
		}
	}
}
