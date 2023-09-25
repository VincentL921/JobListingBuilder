using System;
namespace TrackAndFieldPolymorphismWork
{
	public class Road
	{
        public string LongDistance { get; set; }
        public string MiddleDistance { get; set; }
        public List<Winners> EventWinners { get; set; }

        public Road()
		{
		}
	}
}

