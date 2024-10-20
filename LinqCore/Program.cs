using System.Collections;
using LinqCore;
using LinqCore.models;

var employees = Repository.LoadEmployees(); // Get All Employees
var femaleWithFirstNameStartWithS = employees.Filter(e => e.Gender == "female" &&
 e.FirstName.ToLowerInvariant().StartsWith("s"));

femaleWithFirstNameStartWithS.Print("Female With FirstName Start With S");

// With LINQ
var femaleWithFirstNameStartWithSWithLINQ = employees.Where(e => e.Gender == "female" &&
 e.FirstName.ToLowerInvariant().StartsWith("s"));

femaleWithFirstNameStartWithSWithLINQ.Print("Female With FirstName Start With S With LINQ (Where)");

//====================================================================================

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Extention Where
var evenNumber = numbers.Where(item => item % 2 == 0); // Store Refreance of orginal list

numbers.Add(12);
numbers.Add(14);
numbers.Add(11);
numbers.Remove(4);

evenNumber.Print("Extention Method");
// Every thing before foreach (Enumration) will be effect evenNumber and change its value.
numbers.Add(10); // Once Enumrated Nothing effect evenNumber.

// Enumerable Where Method
var evenNumberEnumrableWhereMethod = Enumerable.Where(numbers, item => item % 2 == 0);
evenNumberEnumrableWhereMethod.Print("Enumerable Where Method");

// Query Syntax (SQL Query)
var evenNumberUsingQuerySyntax =
    from item in numbers
    where item % 2 == 0
    select item;
evenNumberUsingQuerySyntax.Print("Query Syntax (SQL Query)");

// var collection = new ArrayList { 1, false, DateTime.Now }; // LINQ Won't work becuse this not IEnumerable

//====================================================================================

var empMale = employees.Where(item => item.Gender == "male");

var empSalaryOver300K = employees.Where(item => item.Salary >= 300_300);

empMale.Print("Male Employee");

empSalaryOver300K.Print("Employee With Salary Over 300K");

var empMaleInHRDepartment = empMale.Where(item => item.Department.ToLowerInvariant() == "hr");

empMaleInHRDepartment.Print("Male Employee in HR Department");

//====================================================================================

//# Select

RunExampleOne();

RunExampleTwo();

RunExampleThree();

static void RunExampleOne()
{
    string[] wordsArr = { "I", "love", "ASP.Net", "Core" };

    List<string> words = new() { "i", "love", "asp.net", "core" };

    var selectResult = words.Select(item => item.ToUpper());

    selectResult.Print("Captalize Result Using Select Method");

}

static void RunExampleTwo()
{
    // string[] wordsArr = { "I", "love", "ASP.Net", "Core" };

    List<int> numbers = new() { 2, 3, 5, 7 };

    var selectResult = numbers.Select(item => item * item);

    var selectResultWithQueySyntax = from item in numbers select item * item; // Query Syntax

    selectResult.Print("Captalize Result Using Select Method");
    selectResultWithQueySyntax.Print("Captalize Result Using Select Method With SQL Syntax");

}

static void RunExampleThree()
{
    var employees = RepositoryForSelect.LoadEmployees();

    var selectResult = employees.Select(item =>
    {
        return new EmployeeDto
        {
            Name = $"{item.FirstName} {item.LastName}",
            TotalSkills = item.Skills.Count()

        };
    });

    selectResult.Print("Print Skills Employee");
}

//====================================================================================

//# Select Many

string[] sentance = { "i love asp.net", "i like sql server also", "in general i love programming" };

var selectManyResult = sentance.SelectMany(item => item.Split(' '));
selectManyResult.Print("Select Many Result");

static void RunExampleFour()
{
    var employees = RepositoryForSelect.LoadEmployees();

    var selectManyResult = employees.SelectMany(item => item.Skills);

    //Query Syntax (Dapper)
    var selectManyResultQuerySyntax = (from item in employees
                                       from skill in item.Skills
                                       select skill).Distinct();

    selectManyResult.Print("All Employee Skills");
    selectManyResultQuerySyntax.Print("All Employee Skills With Distinct");
}

RunExampleFour();

//====================================================================================

//# Zip

string[] colorName = { "Red", "Green", "Blue" };
string[] colorHex = { "FF0000", "00FF00", "0000FF", "Extra" }; // Extra Value will not margied.

var color = colorName.Zip(colorHex, (first, second) => { return $"{first} ({second})"; });

color.Print("Color Name With HEX");

static void RunExampleFive()
{
    var employees = RepositoryForSelect.LoadEmployees().ToArray();
    var firstThreeEmp = employees[..3];
    var lastThreeEmp = employees[^3..];

    var team = firstThreeEmp.Zip(lastThreeEmp, (first, last) => $"({first.FullName}) With ({last.FullName})");
    team.Print("Margied Team");

    // Query Syntax
    var teams = from item in firstThreeEmp.Zip(lastThreeEmp)
                select $"({item.First.FullName}) With ({item.Second.FullName})";
}

RunExampleFive();

//====================================================================================

