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

		public void GetTopFinishers()
		{
            var bmFinishers = this.Participants.OrderBy(item => item.FinishingTime);
            foreach (var item in bmFinishers)
            {
                Console.WriteLine(item.FinisherName);
            }
        }

		public void GetPodiumWinners()
		{
            var bmPodiumWinners = this.Participants.OrderByDescending(n => n.FinishingTime).Take(3);
            foreach (var witem in bmPodiumWinners)
			{ 
                Console.WriteLine(witem.FinisherName);
                Console.WriteLine(witem.FinishingTime);
                Console.WriteLine(witem.FinisherCountry);
                Console.WriteLine("");
            }
        }

		public Marathon()
		{
			this.Participants = new List<People>();
			this.Spectators = new List<Spectators>();

		}
	}
}

