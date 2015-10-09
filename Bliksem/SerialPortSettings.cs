using System;
using System.IO.Ports;
using System.Runtime.Serialization;

namespace Bliksem
{
	[DataContract]
	public class SerialPortSettings
	{
		public SerialPortSettings(string portName, int baudRate, Parity parity, Int32 dataBits, StopBits stopBits)
		{
			PortName = portName;
			BaudRate = baudRate;
			Parity = parity;
			DataBits = dataBits;
			StopBits = stopBits;
		}

		public SerialPortSettings()
		{

		}
		[DataMember]
		public string PortName { get; set; }
		[DataMember]
		public int BaudRate { get; set; }
		[DataMember]
		public Parity Parity { get; set; }
		[DataMember]
		public Int32 DataBits { get; set; }
		[DataMember]
		public StopBits StopBits { get; set; }

	}
}
