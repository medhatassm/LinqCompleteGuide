using LINQCore;

#region Why Using LINQ?

// Get All Employees
var Employees = Repository.LoadEmployees();

// Ex One: Get Female Employees with FirstName Start with S

// Soultion Without LINQ (Filter method build by programmer)

// var FemaleEmployee = Employees.
// Filter(x => x.Gender == "female" && x.FirstName.ToLowerInvariant().StartsWith("s"));

// FemaleEmployee.Print("Female Employees with FirstName Start with S");

// Soultion With LINQ

var FemaleEmployee =
    Employees.Where(x =>
    x.Gender == "female" && x.FirstName.ToLowerInvariant().StartsWith("s"));

// FemaleEmployee.Print("Get Female Employees with FirstName Start with S");

#endregion


#region Where Method

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Ex: Get Even number from previous list using LINQ Methods

// Using Extention Where Method
var EvenNumber = numbers.Where(x => x % 2 == 0);

// Using Enumerable Where Method
var EnumerableMethodEvenNumber = Enumerable.Where(numbers, x => x % 2 == 0);

// Using Query Syntax
var QuerySyntaxEvenNumber =
from x in numbers
where x % 2 == 0
select x;

foreach (var num in EvenNumber)
{
    Console.WriteLine(num);
}


#endregion



