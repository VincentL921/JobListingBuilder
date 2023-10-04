
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using MarathonPolyWork;

List<Marathon> marathons = new List<Marathon>();
var berlinMarathon = new Marathon();


//DateTime assigns year, month, day, hour, min, seconds - VL 10/1/2023
berlinMarathon.Participants.Add(new People { FinisherName = "Eliud Kipchoge", FinishingTime = new TimeSpan(0, 2, 2, 42), FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Vincent Kipkemoi", FinishingTime = new TimeSpan (0, 2, 3, 13), FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Tadese Takele", FinishingTime = new TimeSpan(0, 2, 3, 24), FinisherCountry = "Ethiopia" });
berlinMarathon.Participants.Add(new People { FinisherName = "Ronald Korir", FinishingTime = new TimeSpan(0, 2, 4, 42), FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Haftu Teklu", FinishingTime = new TimeSpan(0, 2, 4, 42), FinisherCountry = "Ethiopia" });
berlinMarathon.Participants.Add(new People { FinisherName = "Abdulem Belay Shiferaw", FinishingTime = new TimeSpan(0, 2, 4, 44), FinisherCountry = "Ethiopia" });
berlinMarathon.Participants.Add(new People { FinisherName = "Amos Kipruto", FinishingTime = new TimeSpan(0, 2, 4, 49), FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Philemon Kiplimo", FinishingTime = new TimeSpan(0, 2, 4, 56), FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Amanal Petros", FinishingTime = new TimeSpan(0, 2, 4, 58), FinisherCountry = "Germany" });
berlinMarathon.Participants.Add(new People { FinisherName = "Bonface Kimutai Kiplimo", FinishingTime = new TimeSpan(0, 2, 5, 05), FinisherCountry = "Kenya" });


berlinMarathon.GetTopFinishers();
Console.WriteLine("");
berlinMarathon.GetPodiumWinners();

//var sortedTopFinishers = marathons.Select(item => item.Participants).OrderBy(item => item.OrderBy(item2 => item2.FinishingTime));
//did not use this LINQ example for the method building