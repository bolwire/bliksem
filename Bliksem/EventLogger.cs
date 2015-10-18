using System;
using System.Collections.Generic;

namespace Bliksem
{
	public static class EventLogger
	{
		// ReSharper disable once InconsistentNaming
		private static readonly List<string> _eventList = new List<string>();

		public delegate void NewEventDelegate(string eventText);
		public static event NewEventDelegate NewEventAdded;

		public delegate void EventsClearedDelegate();
		public static event EventsClearedDelegate EventsCleared;

		public static List<string> EventList
		{
			get { return _eventList; }
		}

		public static void Add(string eventText)
		{
			eventText = DateTime.Now + ": " + eventText;

			_eventList.Add(eventText);
			NewEventAdded(eventText);
		}

		public static void Clear()
		{
			_eventList.Clear();
			EventsCleared();
		}
	}
}
