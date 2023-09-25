using System;
namespace TrackAndFieldPolymorphismWork
{ 
	public class Event
	{
        public string EventName { get; set; }
		public List<Track> TrackEvenets { get; set; }
		public List<Field> FieldEvents { get; set; }
		public List<Road> RoadEvents { get; set; }
		public List<RaceWalking> WalkingEvents { get; set; }
		public List<OtherEvents> OtherEvents { get; set; }
        public List<Winners> EventWinners { get; set; }

        public Event()
		{
		}
	}
}

