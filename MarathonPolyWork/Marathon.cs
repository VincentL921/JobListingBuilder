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

		//public void GatherRaceWinners()
		//{
  //          foreach (var item in this.Participants)
		//	{

  //              IEnumerable<People> query = this.OrderBy(this.Participants => Participants.f);
  //              //var finishersInOrder = this.Participants.OrderBy(this.Participants);
		//		Console.WriteLine(finishersInOrder);
  //          }
		//}

		public Marathon()
		{
			this.Participants = new List<People>();
			this.Spectators = new List<Spectators>();

		}
	}
}

