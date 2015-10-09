using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Bliksem.CustomControls
{
	public class CustomFlowLayoutPanel: FlowLayoutPanel
	{
		#region Events

		public static event Action<Schedule> ScheduleClicked = delegate { };

		#endregion Events

		#region Private Memebers

		private readonly Label _dateLabel = new Label();
		private readonly FlowLayoutPanel _itemsPanel = new FlowLayoutPanel();
		private DateTime _date;

		#endregion Private Memebers

		#region Public Members

		public DateTime Date
		{
			get { return _date; }
			set
			{
				_date = value;
				_dateLabel.Text = _date.Day.ToString(CultureInfo.InvariantCulture);
				new ToolTip().SetToolTip(_dateLabel,String.Format("{0:M/d/yyyy}", _date));
			}
		}

		#endregion Public Members

		#region Initialization & Constructor

		public CustomFlowLayoutPanel()
		{
			//Is this needed ? Is it right ?
			base.BackColor = SystemColors.Control;
			base.DoubleBuffered = true;

			Margin = new Padding(2);
			Padding = new Padding(0);
			Size = new Size(110,100);
			FlowDirection = FlowDirection.TopDown;
			WrapContents = false;
			
			_dateLabel.BackColor = Color.Black;
			_dateLabel.ForeColor = Color.White;
			_dateLabel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
			_dateLabel.AutoSize = false;
			_dateLabel.Width = Width;
			_dateLabel.TextAlign = ContentAlignment.TopRight;
			_dateLabel.Padding = new Padding(0);
			_dateLabel.Margin = new Padding(0);
			Controls.Add(_dateLabel);

			_itemsPanel.BackColor = Color.Transparent;
			_itemsPanel.Margin = new Padding(0);
			_itemsPanel.Width = Width;
			_itemsPanel.Height = Height - _dateLabel.Height;
			_itemsPanel.Parent = this;
			_itemsPanel.WrapContents = false;
			_itemsPanel.AutoScroll = true;
			_itemsPanel.FlowDirection = FlowDirection.TopDown;
			
			//When items are added and the scrollbar appears, the client area changes, this updates all of the child
			//controls to still fit the width so that the horizontal scrollbar does not appear.
			_itemsPanel.ControlAdded += (sender, e) =>
			{
				foreach (Control control in _itemsPanel.Controls)
				{
					control.Width = _itemsPanel.ClientSize.Width;
				}
			};

			_itemsPanel.MouseClick += ItemPanel_OnClick;
			
			Controls.Add(_itemsPanel);
		}

		#endregion Initialization & Constructor

		#region Public Methods

		public void Clear()
		{
			_itemsPanel.Controls.Clear();
		}

		public void Add(Schedule schedule)
		{
			//This is a hack to get the color back to the original after loosing focus,
			//this should be done via a raised event when the schedule is changed so that
			//the color is set to the proper color anyhow, but this should work for now
			//DAMIT we need mutliple tags!

			Color color = schedule.Enabled ? Color.Green : Color.Red;

			Tuple<Schedule, Color> tagItem = new Tuple<Schedule, Color>(schedule, color);
			Label newLabel = new Label
			{
				AutoSize = false,
				Width = _itemsPanel.ClientSize.Width,
				//Margin = new Padding(0),
				Margin = _itemsPanel.Controls.Count > 0 ? new Padding(0, 5, 0, 0) : new Padding(0),
				Text = schedule.Name + Environment.NewLine + @"ON: " + schedule.StartTime + Environment.NewLine + @"OFF: " + schedule.EndTime,
				BackColor = color,
				Tag = tagItem
			};

			Label onLabel = new Label
			{
				AutoSize = false,
				Width = _itemsPanel.ClientSize.Width,
				Margin = new Padding(0),
				Text = @"ON: " + string.Format("{0:h:mm tt}", schedule.StartTime),
				BackColor = Color.DarkSeaGreen
			};

			Label offLabel = new Label
			{
				AutoSize = false,
				Width = _itemsPanel.ClientSize.Width,
				Margin = new Padding(0),
				Text = @"OFF: " + string.Format("{0:h:mm tt}", schedule.EndTime),
				BackColor = Color.Salmon
			};

			newLabel.MouseClick += ScheduleItem_OnClick;
			newLabel.GotFocus += ScheduleItem_OnFocus;
			newLabel.LostFocus += ScheduleItem_OnFocusLost;

			_itemsPanel.Controls.Add(newLabel);
			_itemsPanel.Controls.Add(onLabel);
			_itemsPanel.Controls.Add(offLabel);
		}

		#endregion Public Methods

		#region Event Handlers
		
		private void ItemPanel_OnClick(object sender, MouseEventArgs e)
		{
			FlowLayoutPanel panel = (FlowLayoutPanel) sender;
			panel.Focus();
			Console.WriteLine(@"Panel clicked: " + string.Format("{0:d}",_date));
			//panel.DoDragDrop(string.Format("{0:d}", _date).ToString(CultureInfo.InvariantCulture), DragDropEffects.Copy);
		}

		private void ScheduleItem_OnFocus(object sender, EventArgs e)
		{
			Label scheduleItem = ((Label)sender);

			scheduleItem.BackColor = Color.DarkGray;
			scheduleItem.Font = new Font(scheduleItem.Font, FontStyle.Bold);
		}

		private void ScheduleItem_OnFocusLost(object sender, EventArgs e)
		{
			Label scheduleItem = ((Label)sender);
			Tuple<Schedule, Color> senderTag = (Tuple<Schedule, Color>)scheduleItem.Tag;

			scheduleItem.BackColor = senderTag.Item2;
			scheduleItem.Font = new Font(scheduleItem.Font, FontStyle.Regular);
		}

		private void ScheduleItem_OnClick(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;

			Label scheduleItem = ((Label)sender);

			Tuple<Schedule, Color> senderTag = (Tuple<Schedule, Color>)scheduleItem.Tag;

			//ScheduleItemClicked(senderTag.Item1);
			ScheduleClicked(senderTag.Item1);

			Console.WriteLine(senderTag.Item1.Name + @" Clicked");

			scheduleItem.Focus();
		}

		#endregion Event Handlers

		#region Overrides

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			_dateLabel.Text = _date.Day.ToString(CultureInfo.InvariantCulture);

			Color c1 = Color.FromArgb(190, Color.LightGray);
			Color c2 = Color.FromArgb(190, Color.Gray);

			Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, 90);
			e.Graphics.FillRectangle(b, ClientRectangle);
		}

		protected override void OnScroll(ScrollEventArgs se)
		{
			Invalidate();
			base.OnScroll(se);
		}

		#endregion Overrides
	}
}
