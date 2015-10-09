using System;
using System.Drawing;
using System.Windows.Forms;
using Bliksem.CustomControls;

namespace Bliksem.UserControls
{
	public partial class ScheduleCalendar : UserControl
	{
		#region Private Memebers
		
		private readonly CustomFlowLayoutPanel[,] _panel;
		private DateTime _month = DateTime.Now;

		#endregion Private Memebers

		#region Public Members

		public DateTime Month
		{
			get { return _month; }
			set
			{
				_month = value;
				try
				{
					UpdateView();
				}
				catch (Exception e)
				{
					Console.WriteLine(@"Error: " + e.Message);
				}
			}
		}		

		#endregion Public Members

		#region Initialization & Constructor

		public ScheduleCalendar()
		{
			InitializeComponent();

			_panel = new[,]
			{
				{ panelWeek1Sunday, panelWeek1Monday, panelWeek1Tuesday,panelWeek1Wednesday,panelWeek1Thursday,panelWeek1Friday,panelWeek1Saturday},
				{ panelWeek2Sunday, panelWeek2Monday, panelWeek2Tuesday,panelWeek2Wednesday,panelWeek2Thursday,panelWeek2Friday,panelWeek2Saturday},
				{ panelWeek3Sunday, panelWeek3Monday, panelWeek3Tuesday,panelWeek3Wednesday,panelWeek3Thursday,panelWeek3Friday,panelWeek3Saturday},
				{ panelWeek4Sunday, panelWeek4Monday, panelWeek4Tuesday,panelWeek4Wednesday,panelWeek4Thursday,panelWeek4Friday,panelWeek4Saturday},
				{ panelWeek5Sunday, panelWeek5Monday, panelWeek5Tuesday,panelWeek5Wednesday,panelWeek5Thursday,panelWeek5Friday,panelWeek5Saturday}
				
			};

			Month = DateTime.Now;
		}

		#endregion Initialization & Constructor

		#region Private Methods

		private void UpdateView()
		{
			if (_month.Year < DateTime.Now.Year - 5)
				return;

			var firstDayOfMonth = new DateTime(_month.Year, _month.Month, 1);
			//var LastDayOfMOnth = FirstDayOfMonth.AddMonths(1).AddDays(-1);

			//Console.WriteLine("First day: " + FirstDayOfMonth.DayOfWeek + " " + FirstDayOfMonth);
			//Console.WriteLine("Last day: " + LastDayOfMOnth.DayOfWeek + " " + LastDayOfMOnth);

			//_panel[0, (int) FirstDayOfMonth.DayOfWeek].Date = FirstDayOfMonth.Day.ToString(CultureInfo.InvariantCulture);

			//iterate weeks, inside of the week iteration, iterate the days for that week
			//find the firstday of the the week, subtract that number of days and set panel[0,0] to that

			var startingDate = firstDayOfMonth.AddDays(-(int)firstDayOfMonth.DayOfWeek);

			//Console.WriteLine("Calendar start: " + startingDate);

			for (int w = 0; w < 5; w++)
			{
				for (int d = 0; d < 7; d++)
				{
					_panel[w, d].Date = startingDate.AddDays((w * 7) + d);
				}
			}
		}

		#endregion Private Methods

		#region Public Methods

		public void Panel(int week, int day, DateTime date)
		{
			_panel[week, day].Date = date;
		}

		public DateTime Panel(int week, int day)
		{
			return _panel[week, day].Date;
		}

		public CustomFlowLayoutPanel GetPanel(int week, int day)
		{
			return _panel[week, day];
		}

		public void AddItemByDate(DateTime date, Schedule schedule)
		{
			for (int w = 0; w < 5; w++)
			{
				for (int d = 0; d < 7; d++)
				{
					if (string.Format("{0:d}", _panel[w, d].Date) == string.Format("{0:d}", date))
					{
						_panel[w, d].Add(schedule);
					}
				}
			}
		}

		public void ClearPanels()
		{
			for (int w = 0; w < 5; w++)
			{
				for (int d = 0; d < 7; d++)
				{
						_panel[w, d].Clear();
				}
			}
		}

		#endregion Public Methods
	}
}
