using System;
namespace TrackAndFieldPolymorphismWork
{
	public class Field
	{
        public string ThrowEvents { get; set; }
        public string JumpEvents { get; set; }
        public List<Winners> EventWinners { get; set; }

        public Field()
		{
		}
	}
}

