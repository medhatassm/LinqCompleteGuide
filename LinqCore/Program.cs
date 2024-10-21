using SharedModels;

// Get Employee Data From Shred Library Class "SharedModels"
var allEmployees = Repository.LoadEmployees();
// Print is Extention Method From SharedModel Library
allEmployees.Print("All Employee");

#region Where Method

var firstNameStartWithS = allEmployees.Where(e => e.Name.ToLowerInvariant().StartsWith("s"));
firstNameStartWithS.Print("Employee Start With `S` in First Name");

///<summary>
/// Where Filter your data and return IEnumerable List
///</summary>
///

static void FilterNumbers()
{
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
}

#endregion

#region Select Method

var selectEmployeeSkills = allEmployees.Select(e =>
{
    return new EmplyeeDto
    {
        Name = $"{e.Name}",
        TotalSkills = e.Skills.Count()
    };
});

selectEmployeeSkills.Print("Employee Dto");

///<summary>
/// Select Produces Values that are based on transform function.
///</summary>
///

static void ArrayUpperCase()
{
    string[] wordsArr = { "I", "love", "ASP.Net", "Core" };

    List<string> words = new() { "i", "love", "asp.net", "core" };

    var selectResult = words.Select(item => item.ToUpper());

    selectResult.Print("Captalize Result Using Select Method");

}

static void MultipliTwoNumber()
{

    List<int> numbers = new() { 2, 3, 5, 7 };

    var selectResult = numbers.Select(item => item * item);

    var selectResultWithQueySyntax = from item in numbers select item * item; // Query Syntax

    selectResult.Print("Captalize Result Using Select Method");
    selectResultWithQueySyntax.Print("Captalize Result Using Select Method With SQL Syntax");

}

#endregion

#region Select Many Method

var selectManyResult = allEmployees.SelectMany(item => item.Skills).Distinct();

//Query Syntax (Dapper)
var selectManyResultQuerySyntax = (from item in allEmployees
                                   from skill in item.Skills
                                   select skill).Distinct();

selectManyResult.Print("All Employee Skills With Distinct (Extention Method)");

// selectManyResultQuerySyntax.Print("All Employee Skills With Distinct (Query Syntax)");

///<summary>
/// Select Many Produces sequences of values then flattens them into one sequence
///</summary>
///

static void SplitArray()
{
    string[] sentance = { "i love asp.net", "i like sql server also", "in general i love programming" };

    var selectManyResult = sentance.SelectMany(item => item.Split(' '));
    selectManyResult.Print("Select Many Result");
}

#endregion

#region Zip Method

var allEmployeesArray = allEmployees.ToArray();

var firstThreeEmp = allEmployeesArray[..3];
var lastThreeEmp = allEmployeesArray[^3..];

var employeeInfo = firstThreeEmp.Zip(lastThreeEmp, (first, last) => $"({first.Index})- {last.Name}");
employeeInfo.Print("Employee Info");

// Query Syntax
var employeeInfoQuerySyntax = from item in firstThreeEmp.Zip(lastThreeEmp)
                              select $"({item.First.Index})- {item.Second.Name}";

///<summary>
/// Zip Produces a sequence of tuples with element from 2 - 3 specified sequence
///</summary>
///

static void MargiedColors()
{
    string[] colorName = { "Red", "Green", "Blue" };
    string[] colorHex = { "FF0000", "00FF00", "0000FF", "Extra" }; // Extra Value will not margied.

    var color = colorName.Zip(colorHex, (first, second) => { return $"{first} ({second})"; });

    color.Print("Color Name With HEX");
}

#endregion

#region OrderBy And ThenBy Method

string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };

// Method Syntax
var orderFruits = fruits.OrderBy(item => item).ThenBy(item => item.Length); // ASC
orderFruits.Print("Fruits ASC Order Then by Length Order (Method Syntax)");

var orderFruitsDESC = fruits.OrderByDescending(item => item); // DSC
orderFruitsDESC.Print("Fruits DESC Order (Method Syntax)");

var orderFruitsByLength = fruits.OrderByDescending(item => item.Length); // DSC By Length
orderFruitsByLength.Print("Fruits By Length Order (Method Syntax)");

// Query Syntax
var orderFruitsQuerySyntax = from item in fruits
                             orderby item
                             select item;
orderFruitsQuerySyntax.Print("Fruits ASC Order (Query Syntax)");

var orderFruitsBylengthQuerySyntax = from item in fruits
                                     orderby item.Length
                                     select item;
orderFruitsBylengthQuerySyntax.Print("Fruits By length Order (Query Syntax)");

var orderFruitsQuerySyntaxDESC = from item in fruits
                                 orderby item descending
                                 select item;
orderFruitsQuerySyntaxDESC.Print("Fruits DESC Order (Query Syntax)");

///<summary>
/// OrderBy To order a sequence by the value of the element themselves.
///</summary>

#endregion

#region Skip Method (While - Last)

var skipFirst10Element = allEmployees.Skip(10);
skipFirst10Element.Print("Skip First 10 Element");

var skipWhile = allEmployees.SkipWhile(e => e.Salary != 343200);
skipWhile.Print("Skip Until Salary EGP343.200");

var skipLast10Element = allEmployees.SkipLast(10);
skipLast10Element.Print("Skip Last 10 Element");

///<summary>
/// Skip is used to skip or bypass the (first , last or on condition)
/// n number of element from a data source or sequence and return
/// the remaining element.
///</summary>
#endregion

#region Take Method (While - Last)

var takeFirst10Element = allEmployees.Take(10);
takeFirst10Element.Print("Take First 10 Element");

var takeWhile = allEmployees.TakeWhile(e => e.Salary != 343200);
takeWhile.Print("Take Until Salary EGP343.200");

var takeLast10Element = allEmployees.TakeLast(10);
takeLast10Element.Print("Take Last 10 Element");

///<summary>
/// Take fetches the first “n” number of elements from the data source,
/// where “n” is an integer passed as a parameter to the LINQ Take method.
///</summary>
#endregion

#region Chuncks

var chunks = allEmployees.Chunk(15).ToList();

for (int i = 0; i < chunks.Count(); i++)
{
    chunks[i].Print($"Chunck #{i + 1}");
}

#endregion





