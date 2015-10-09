using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bliksem
{
	public partial class OutputManager : Form
	{
		public List<Channels> Outputs { get; set; }
		private Channels _currentItem;
		private bool _isDirty;

		public OutputManager(List<Channels> outputs)
		{
			InitializeComponent();
			Outputs = outputs;
		}

		private void OutputManager_Load(object sender, EventArgs e)
		{
			PopulateChannelList();
		}

		private void PopulateChannelList()
		{
			foreach (Channels cc in Outputs)
			{
				cb_Outputs.Items.Add(cc);
			}
		}

		private void PopulateChannelList(int reselect)
		{
			foreach (Channels cc in Outputs)
			{
				cb_Outputs.Items.Add(cc);
			}
			cb_Outputs.SelectedIndex = reselect;

		}

		private void cb_Outputs_SelectedIndexChanged(object sender, EventArgs e)
		{
			Channels item = cb_Outputs.SelectedItem as Channels;
			if (item == null) return;

			tb_OutputName.Text = item.ChannelName;
			cb_OutputEnabled.Checked = item.ChannelEnabled;
			_currentItem = item;
		}

		private void btn_Apply_Click(object sender, EventArgs e)
		{
			if (_currentItem == null) return;

			_currentItem.ChannelName = tb_OutputName.Text;
			_currentItem.ChannelEnabled = cb_OutputEnabled.Checked;
			
			//This must be left in place, we want the index before the list is cleared.
			int i = cb_Outputs.SelectedIndex;
			cb_Outputs.Items.Clear();
			PopulateChannelList(i);
			_isDirty = false;
		}

		private void tb_OutputName_TextChanged(object sender, EventArgs e)
		{
			_isDirty = true;
		}

		private void cb_OutputEnabled_CheckedChanged(object sender, EventArgs e)
		{
			_isDirty = true;
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(@"You will loose any changes made, are you sure ?", @"Warning - Cancel", MessageBoxButtons.YesNo) == DialogResult.No)
				DialogResult = DialogResult.None;
		}

		private void OutputManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_isDirty)
			{
				if (MessageBox.Show(@"You have unsaved changes, are you sure ?", @"Warning - Unsaved Changes", MessageBoxButtons.YesNo) == DialogResult.No)
					e.Cancel = true;
			}
		}
	}
}
