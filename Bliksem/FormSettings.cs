using System;
using System.IO;
using System.Windows.Forms;
using Bliksem.Properties;

namespace Bliksem
{
	public partial class FormSettings : Form
	{
		public FormSettings()
		{
			InitializeComponent();
		}

		private void buttonBrowseFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
			{
				SelectedPath =
					Settings.Default.DataPath.Length > 0
						? Settings.Default.DataPath
						: Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bliksem")
			};

			if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
			
			Settings.Default.DataPath = folderBrowserDialog.SelectedPath;
			MessageBox.Show(@"You must restat Bliksem for the changes to take effect.", @"Application Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}
