using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bliksem
{
	public partial class OutputManager : Form
	{
		public List<Channels> Outputs { get; set; }
		private Channels currentItem = null;
		private bool IsDirty = false;

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
			if (item != null)
			{
				tb_OutputName.Text = item.ChannelName;
				cb_OutputEnabled.Checked = item.ChannelEnabled;
				currentItem = item;

			}
		}

		private void btn_Apply_Click(object sender, EventArgs e)
		{
			if (currentItem != null)
			{
				int i;
				currentItem.ChannelName = tb_OutputName.Text;
				currentItem.ChannelEnabled = cb_OutputEnabled.Checked;
				i = cb_Outputs.SelectedIndex;
				cb_Outputs.Items.Clear();
				PopulateChannelList(i);
				IsDirty = false;
			}
		}

		private void tb_OutputName_TextChanged(object sender, EventArgs e)
		{
			IsDirty = true;
		}

		private void cb_OutputEnabled_CheckedChanged(object sender, EventArgs e)
		{
			IsDirty = true;
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("You will loose any changes made, are you sure ?", "Warning - Cancel", MessageBoxButtons.YesNo) == DialogResult.No)
				this.DialogResult = DialogResult.None;
		}

		private void OutputManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (IsDirty)
			{
				if (MessageBox.Show("You have unsaved changes, are you sure ?", "Warning - Unsaved Changes", MessageBoxButtons.YesNo) == DialogResult.No)
					e.Cancel = true;
			}
		}
	}
}
