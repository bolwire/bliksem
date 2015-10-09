using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Bliksem.CustomControls
{
	public class ScrollablePanel: Panel
	{


		private String _date;
		public String Date
		{
			get { return _date; }
			set
			{
				_date = value;
				Invalidate();
			}
		}

		private readonly ScrollBar _vScrollBar1 = new VScrollBar();
		private readonly Label _dateLabel = new Label();
		private readonly FlowLayoutPanel _itemPanel = new FlowLayoutPanel();
		private readonly ListBox _itemList = new ListBox();


		public void Add(string text)
		{
			_itemList.Items.Add(text);
		}

		public ScrollablePanel()
		{
			//BackColor = Color.PaleTurquoise;
			Padding = new Padding(0);
			Margin = new Padding(2);
			Size = new Size(110, 100);
			

			//BorderStyle = BorderStyle.Fixed3D;

			_vScrollBar1.Dock = DockStyle.Right;
			//_vScrollBar1.Scroll += (sender, e) => { VerticalScroll.Value = _vScrollBar1.Value; };
			//_vScrollBar1.Scroll += (sender, e) => { _itemPanel.VerticalScroll.Value = _vScrollBar1.Value; };
			//Controls.Add(_vScrollBar1);

			_dateLabel.Dock = DockStyle.Top;
			_dateLabel.BackColor = Color.Black;
			_dateLabel.ForeColor = Color.White;
			_dateLabel.TextAlign = ContentAlignment.TopCenter;
			_dateLabel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
			_dateLabel.Text = Date;
			Controls.Add(_dateLabel);

			_itemList.Top = _dateLabel.Height;
			_itemList.Left = 0;
			_itemList.Width = _dateLabel.Width;
			_itemList.IntegralHeight = false;
			_itemList.Height = Height - _dateLabel.Height;
			_itemList.Parent = this;
			//_itemList.BackColor = Color.Transparent;
			Controls.Add(_itemList);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			_dateLabel.Text = Date;

			Color c1 = Color.FromArgb(190 , Color.LightGray);
			Color c2 = Color.FromArgb(190 , Color.Gray);

			Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, 90);
			e.Graphics.FillRectangle(b, ClientRectangle);
		}
	}
}
