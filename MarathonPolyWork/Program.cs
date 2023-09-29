
using System.Linq;
using System.Text;
using MarathonPolyWork;

List<Marathon> marathons = new List<Marathon>();
var berlinMarathon = new Marathon();

berlinMarathon.Participants.Add(new People { FinisherName = "Eliud Kipchoge", FinishingTime = "2:02:42", FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Vincent Kipkemoi", FinishingTime = "2:03:13", FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Tadese Takele", FinishingTime = "2:03:24", FinisherCountry = "Ethiopia" });
berlinMarathon.Participants.Add(new People { FinisherName = "Ronald Korir", FinishingTime = "2:04:42", FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Haftu Teklu", FinishingTime = "2:04:42", FinisherCountry = "Ethiopia" });

berlinMarathon.GatherRaceWinners();
