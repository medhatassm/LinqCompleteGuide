## Sets

### Distinct

Remove all repeated elements in collections.

```csharp
List<int> numbers = new List<int> { 1, 2, 5, 1, 4, 2, 6, 5, 6 };

var distinctNumber = numbers.Distinct();

distinctNumber.Print("Distinct Number");
```

---

### Except

Get value in collection one without the data that repeated in collection two.

```csharp
List<string> TeamOne = new List<string>() { "Medhat", "Samier", "Oreen" };
List<string> TeamTwo = new List<string>() { "Yaser", "Samier", "Rana" };

var TeamThree = TeamOne.Except(TeamTwo);

TeamThree.Print("Team One With No One Reapeted in Team Two");
```

---

### Intersect

Get elements that Repeated in collection one and collection two.

```csharp
List<string> TeamOne = new List<string>() { "Medhat", "Samier", "Oreen" };
List<string> TeamTwo = new List<string>() { "Yaser", "Samier", "Rana" };

var TeamFour = TeamOne.Intersect(TeamTwo);

TeamFour.Print("Team Members that repeated in two teams");
```

---

### Union

Get all elements in two collections without repeated elements.

```csharp
List<string> TeamOne = new List<string>() { "Medhat", "Samier", "Oreen" };
List<string> TeamTwo = new List<string>() { "Yaser", "Samier", "Rana" };

var AllTeams = TeamOne.Union(TeamTwo);

AllTeams.Print("All Teams Members");
```