using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO.Ports;


namespace Bliksem
{

	[DataContract]
	public class SerialPortSettings
	{
		public SerialPortSettings(string PortName, int BaudRate, Parity Parity, Int32 DataBits, StopBits StopBits)
		{
			this.PortName = PortName;
			this.BaudRate=BaudRate;
			this.Parity=Parity;
			this.DataBits=DataBits;
			this.StopBits=StopBits;
		}

		public SerialPortSettings()
		{

		}
		[DataMember]
		public string PortName {get;set;}
		[DataMember]
		public int BaudRate {get;set;}
		[DataMember]
		public Parity Parity {get;set;}
		[DataMember]
		public Int32 DataBits {get;set;}
		[DataMember]
		public StopBits StopBits {get;set;}

	}
	[DataContract]
	public class Channels
	{
		public Channels(string ChannelNumber, string ChannelName, Boolean ChannelEnabled = true)
		{
			this.ChannelNumber = ChannelNumber;
			this.ChannelName = ChannelName;
			this.ChannelEnabled = ChannelEnabled;
		}
		public Channels()
		{

		}
		[DataMember]
		public string ChannelNumber { get; set; }
		[DataMember]
		public string ChannelName { get; set; }
		[DataMember]
		public bool ChannelEnabled { get; set; }

		public override string ToString()
		{
			return ChannelNumber + ":" + ChannelName;
		}
	}
	[DataContract]
	public class Schedule
	{
		public Schedule(string Name, string Channel, DateTime StartTime, DateTime EndTime, DateTime StartDate, DateTime EndDate, Boolean Sunday, Boolean Monday, Boolean Tuesday, Boolean Wednesday, Boolean Thursday, Boolean Friday, Boolean Saturday, Boolean Enabled = true)
		{
			this.Name = Name;
			this.Enabled = Enabled;
			this.Channel = Channel;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.Sunday = Sunday;
			this.Monday = Monday;
			this.Tuesday = Tuesday;
			this.Wednesday = Wednesday;
			this.Thursday = Thursday;
			this.Friday = Friday;
			this.Saturday = Saturday;

		}
		public Schedule()
		{

		}
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public Boolean Enabled { get; set;}
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
		//[DataMember]
		public Boolean Stop
		{
			get
			{
				if (this.EndTime.ToString("hh:mm:ss") == DateTime.Now.ToString("hh:mm:ss"))
					return true;
				else
					return false;
			}
		}
		public Boolean Start
		{
			get
			{
				bool TimeOK = false;
				bool DayOK = false;
				bool DateOK = false;
				
				//if (DateTime.Now.ToString("hh:mm:ss") >= this.StartTime.ToString("hh:mm:ss") && DateTime.Now.ToString("hh:mm:ss") < this.EndTime.ToString("hh:mm:ss"))
				if (this.StartTime.ToString("hh:mm:ss") == DateTime.Now.ToString("hh:mm:ss"))
					TimeOK = true;				
				if ((int)DateTime.Now.DayOfWeek == 0 && this.Sunday)
					DayOK = true;
				if ((int)DateTime.Now.DayOfWeek == 1 && this.Monday)
					DayOK = true;
				if ((int)DateTime.Now.DayOfWeek == 2 && this.Tuesday)
					DayOK = true;
				if ((int)DateTime.Now.DayOfWeek == 3 && this.Wednesday)
					DayOK = true;
				if ((int)DateTime.Now.DayOfWeek == 4 && this.Thursday)
					DayOK = true;
				if ((int)DateTime.Now.DayOfWeek == 5 && this.Friday)
					DayOK = true;
				if ((int)DateTime.Now.DayOfWeek == 6 && this.Saturday)
					DayOK = true;

				if (this.StartDate.Date <= DateTime.Now.Date && this.EndDate.Date >= DateTime.Now.Date)
					DateOK = true;

				if (this.Enabled && TimeOK && DayOK && DateOK)
					return true;
				else
					return false;
			}
		}


		public override string ToString()
		{
			return Name;
		}

	}
}
