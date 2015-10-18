using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using Bliksem.Properties;

namespace Bliksem
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			
			//Check if the user wants to set a custom path to save files
			//pass the 

			//Environment.Exit(1);

			/*
			if (arg.Length > 0)
			{
				switch (arg[0])
				{
					case "-setpath":
						//set custom path
						MessageBox.Show(@"Select the disired location to save config files when prompted.", @"Bliksem 2015");
						FolderBrowserDialog result = new FolderBrowserDialog();
						if (result.ShowDialog() != DialogResult.OK)
						{
							MessageBox.Show(@"Action canceled, please run with -setpath option again to configure. No changes were made.", @"Bliksem 2015");
							Environment.Exit(1);
						}

						Settings.Default.DataPath = result.SelectedPath;
						Settings.Default.Save();

						break;
					case "-reset":
						//reset to default path
						Settings.Default.DataPath = "";
						Settings.Default.Save();

						MessageBox.Show(@"Data path reset to default path, My Documents\Bliksem\", @"Bliksem 2015");
						break;
				}
			}
			 */

			
			//Do we need to upgrade settings from previous version ?
			if (Settings.Default.upgrade)
			{
				DialogResult upgradeSettings = MessageBox.Show(
					@"Bliksem needs to upgrade settings from a previous version, click OK to upgrade settings, or Cancel to skip.",
					@"Upgrade Settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

				if (upgradeSettings == DialogResult.OK)
				{
					Settings.Default.Upgrade();
					MessageBox.Show(@"Upgrade complete, no further action is required.");
				}

				Settings.Default.upgrade = false;
				Settings.Default.Save();
			}

			//Determine datafolder to use
			if (Settings.Default.DataPath.Length > 0 && Directory.Exists(Settings.Default.DataPath))
			{
				Application.Run(new Form1(Settings.Default.DataPath));
			}
			else
			{
				Settings.Default.DataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bliksem");
				Settings.Default.Save();
				Application.Run(new Form1(Settings.Default.DataPath));
			}
		}
	}
}
