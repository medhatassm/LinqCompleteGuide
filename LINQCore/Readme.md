# LINQ Core

## LINQ

language integrated query

- MS.Net Component
- Type safe queries (in code)
- query local object (IEnumerable)
- LINQ to remote (sql)
- set of query operator (Extension Method)

> LINQ Statement Store the original collection into the ram then when enumeration process (foreach) begin / execute it will return the new collection (even if the original change after LINQ statement, this change will effect the original collection which in ram also)
> 

**LINQ Statement written with two way**

1. **Method Syntax**
2. **Query Syntax**

---

## WHERE

return new collection from collection under condition

```sql
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
```