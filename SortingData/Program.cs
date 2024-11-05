#region OrderBy & ThenBy

string[] fruits = ["apricot", "orange", "banana", "mango", "apple", "grape", "strawberry"];

// Order By

// Method Syntax
var orderFruits = fruits.OrderBy(x => x); // ASC

var orderFruitsDESC = fruits.OrderByDescending(x => x); // DESC

var orderFruitsAsLength = fruits.OrderBy(x => x.Length); // By Length

// Then By

var orderFruitsASCThenLength = fruits.OrderBy(x => x).ThenBy(x => x.Length);

var orderFruitsASCThenLengthThenDesenfing = fruits.OrderBy(x => x). // ASC
ThenBy(x => x.Length). // By Length
ThenByDescending(x => x); // DESC

// Query Syntax
var orderFruitsQuerySyntax =
 from x in fruits
 orderby x
 select x; // ASC

var orderFruitsQuerySyntaxDESC =
from x in fruits
orderby x descending
select x; // DESC

var orderFruitsQuerySyntaxAsLength =
from x in fruits
orderby x.Length
select x; // DESC

foreach (var f in orderFruitsQuerySyntaxAsLength)
{
    Console.WriteLine(f);
}

#endregion





