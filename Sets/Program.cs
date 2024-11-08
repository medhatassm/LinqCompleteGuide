#region Distinct

using Sets.Models;

List<int> numbers = new List<int> { 1, 2, 5, 1, 4, 2, 6, 5, 6 };

var distinctNumber = numbers.Distinct();

distinctNumber.Print("Distinct Number");

#endregion

#region Except & Intersect

List<string> TeamOne = new List<string>() { "Medhat", "Samier", "Oreen" };
List<string> TeamTwo = new List<string>() { "Yaser", "Samier", "Rana" };

var TeamThree = TeamOne.Except(TeamTwo);

TeamThree.Print("Team One With No One Reapeted in Team Two");

var TeamFour = TeamOne.Intersect(TeamTwo);

TeamFour.Print("Team Members that repeated in two teams");

#endregion

#region Union

var AllTeams = TeamOne.Union(TeamTwo);

AllTeams.Print("All Teams Members");

#endregion


