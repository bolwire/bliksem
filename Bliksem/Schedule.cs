using System;
using System.Runtime.Serialization;

namespace Bliksem
{
	[DataContract]
	public class Schedule : IEquatable<Schedule>
	{
		public Schedule(string name, string channel, DateTime startTime, DateTime endTime, DateTime startDate, DateTime endDate, Boolean sunday, Boolean monday, Boolean tuesday, Boolean wednesday, Boolean thursday, Boolean friday, Boolean saturday, Boolean enabled = true)
		{
			Name = name;
			Enabled = enabled;
			Channel = channel;
			StartTime = startTime;
			EndTime = endTime;
			StartDate = startDate;
			EndDate = endDate;
			Sunday = sunday;
			Monday = monday;
			Tuesday = tuesday;
			Wednesday = wednesday;
			Thursday = thursday;
			Friday = friday;
			Saturday = saturday;

		}
		
		public Schedule()
		{

		}

		private DateTime _startedDate;

		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public Boolean Enabled { get; set; }
		[DataMember]
		public string Channel { get; set; }
		[DataMember]
		public DateTime StartTime { get; set; }
		[DataMember]
		public DateTime EndTime { get; set; }
		[DataMember]
		public DateTime StartDate { get; set; }
		[DataMember]
		public DateTime EndDate { get; set; }
		[DataMember]
		public Boolean Sunday { get; set; }
		[DataMember]
		public Boolean Monday { get; set; }
		[DataMember]
		public Boolean Tuesday { get; set; }
		[DataMember]
		public Boolean Wednesday { get; set; }
		[DataMember]
		public Boolean Thursday { get; set; }
		[DataMember]
		public Boolean Friday { get; set; }
		[DataMember]
		public Boolean Saturday { get; set; }

		private bool _running;

		public Boolean Stop()
		{
			//DateTime endTime = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,EndTime.Hour, EndTime.Minute,EndTime.Second);

			//if (!running || EndTime.ToString("hh:mm:ss tt") != DateTime.Now.ToString("hh:mm:ss tt"))

			if (_running)
			{
				if (EndTime.TimeOfDay < StartTime.TimeOfDay)
				{
					if (DateTime.Now.Date == _startedDate.Date)
						return false;

					if (DateTime.Now.TimeOfDay < EndTime.TimeOfDay)
						return false;
				}

				else if (DateTime.Now.TimeOfDay < EndTime.TimeOfDay)
				{
						return false;
				}
			}

			//Retruning true causes a log window entry. This makes sure we don't spam the log window when the scedule isn't running.
			if (!_running)
				return false;

			_running = false;
			return true;
		}

		public Boolean Start()
		{
			//We are already running so we don't need to start
			if (_running)
				return false;

			bool timeOk = false;
			bool dayOk = false;
			bool dateOk = false;

			//if (DateTime.Now.ToString("hh:mm:ss") >= this.StartTime.ToString("hh:mm:ss") && DateTime.Now.ToString("hh:mm:ss") < this.EndTime.ToString("hh:mm:ss"))

			//DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, StartTime.Hour, StartTime.Minute, StartTime.Second);
			//DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, EndTime.Hour, EndTime.Minute, EndTime.Second);

			//if (StartTime.ToString("hh:mm:ss tt") == DateTime.Now.ToString("hh:mm:ss tt"))

			//if this schedule runs past midnight
			if (EndTime.TimeOfDay < StartTime.TimeOfDay && DateTime.Now.TimeOfDay > StartTime.TimeOfDay)
				timeOk = true;

			if (DateTime.Now.TimeOfDay > StartTime.TimeOfDay && DateTime.Now.TimeOfDay < EndTime.TimeOfDay)
				timeOk = true;
				
			if ((int)DateTime.Now.DayOfWeek == 0 && Sunday)
				dayOk = true;
			if ((int)DateTime.Now.DayOfWeek == 1 && Monday)
				dayOk = true;
			if ((int)DateTime.Now.DayOfWeek == 2 && Tuesday)
				dayOk = true;
			if ((int)DateTime.Now.DayOfWeek == 3 && Wednesday)
				dayOk = true;
			if ((int)DateTime.Now.DayOfWeek == 4 && Thursday)
				dayOk = true;
			if ((int)DateTime.Now.DayOfWeek == 5 && Friday)
				dayOk = true;
			if ((int)DateTime.Now.DayOfWeek == 6 && Saturday)
				dayOk = true;

			//DateTime startDate = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, 0, 0, 1);
			//DateTime endDate = new DateTime(EndDate.Year, EndDate.Month, EndDate.Day, 0, 0, 1);


			if (StartDate.Date <= DateTime.Now.Date && EndDate.Date >= DateTime.Now.Date)
				dateOk = true;

			if (!Enabled || !timeOk || !dayOk || !dateOk) return false;

			_startedDate = DateTime.Now.Date;
			_running = true;
			return true;
		}

		public bool Equals(Schedule other)
		{
			return other != null && (string.Equals(Name, other.Name, StringComparison.CurrentCultureIgnoreCase));
		}

		public override string ToString()
		{
			return Name;
		}

	}
}
