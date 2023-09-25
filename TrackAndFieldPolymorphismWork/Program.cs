using System.Linq;
using System.Text;
using TrackAndFieldPolymorphismWork;

List<Event> trackAndFieldMeet = new List<Event>();
var worldChampionshipBudapest = new Event();

worldChampionshipBudapest.TrackEvenets.Add(new Track { LongDistance = "10,000m" });