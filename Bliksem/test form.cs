using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bliksem.Properties;

namespace Bliksem
{
	public partial class test_form : Form
	{
		public test_form()
		{
			InitializeComponent();
		}


		private bool chState;
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = chState ? pictureBox1.Image = Resources.light_off : Resources.light_on;
			chState = !chState;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			((Button) sender).Image = chState ? ((Button) sender).Image = Resources.slider_off_36 : Resources.slider_on_36;
			chState = !chState;
		}
	}
}
