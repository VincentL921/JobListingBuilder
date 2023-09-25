using System;
namespace TrackAndFieldPolymorphismWork
{
	public class Track:Event
	{
		public string LongDistance { get; set; }
        public string MiddleDistance { get; set; }
        public string Sprinting { get; set; }
        

        public Track()
		{
        }
	}
}

