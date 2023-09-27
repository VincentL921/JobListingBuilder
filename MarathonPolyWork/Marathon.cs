using System;
namespace MarathonPolyWork
{
	public class Marathon
	{
		public string MarathonName { get; set; }
		public int MarathonYear { get; set; }
		public Race Race { get; set; }
		public Event Event { get; set; }
		public List<People> Participants { get; set; }
		public List<Spectators> Spectators { get; set; }

		public Marathon()
		{
			this.Participants = new List<People>();
			this.Spectators = new List<Spectators>();

		}
	}
}

