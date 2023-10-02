
using System.Linq;
using System.Text;
using MarathonPolyWork;

List<Marathon> marathons = new List<Marathon>();
var berlinMarathon = new Marathon();


//DateTime assigns year, month, day, hour, min, seconds - VL 10/1/2023
berlinMarathon.Participants.Add(new People { FinisherName = "Eliud Kipchoge", FinishingTime = 2.242m, FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Vincent Kipkemoi", FinishingTime = 2.313m, FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Tadese Takele", FinishingTime = 2.0324m, FinisherCountry = "Ethiopia" });
berlinMarathon.Participants.Add(new People { FinisherName = "Ronald Korir", FinishingTime = 2.0442m, FinisherCountry = "Kenya" });
berlinMarathon.Participants.Add(new People { FinisherName = "Haftu Teklu", FinishingTime = 2.0442m, FinisherCountry = "Ethiopia" });



//List<User> usersByAge = listOfUsers.OrderBy(user => user.Age).ToList();
//foreach (User user in usersByAge)

var sortedTopFinishers = marathons.OrderBy(berlinMarathon => berlinMarathon.Participants).ToList();
foreach (var item in sortedTopFinishers)
{
    Console.WriteLine();
}