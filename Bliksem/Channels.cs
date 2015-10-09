using System;
using System.Runtime.Serialization;

namespace Bliksem
{
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
}
