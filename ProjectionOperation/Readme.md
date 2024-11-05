# Projection Operation

## Projection

refers to the operation of transforming and object into a new form that is going to be used.

**Goal of projection**

- Construct a new type
- Project a new property
- Perform mathematical

---

## Select

return collection form original collection based on a transform function

```sql
List<string> words = new() { "I", "Love", "ASP.Net", "Core" };

// Extention Method
var UpperCaseWords = words.Select(x => x.ToUpper());

// Enumerable Method
var UpperCaseWordsEnumrableMethod = Enumerable.Select(words, x => x.ToUpper());

// Query Syntax
var UpperCaseWordsQuerySyntax =
from x in words
select x.ToUpper();

foreach (var w in UpperCaseWords)
{
    Console.Write(w);
}
Console.WriteLine();

// Using Select and Where togther
var ASPDotNETAllCapse = (words.Where(x => x.StartsWith("A")).Select(x => x.ToUpper())).ToList();
Console.WriteLine(ASPDotNETAllCapse[0]);

```

---

## SelectMany

Using to convert value to sequence of values.

```sql
// Ex: Convert each sentance to be array that have n of word as value of it.

string[] sentance ={
    "I love asp.net core",
    "I like SQL server also",
    "in genral i love programming"
};

// With Normal Select
var arrayOfEachSentanceNormalSelect = sentance.Select(x => x.Split(' ')).ToArray();

foreach (var arr in arrayOfEachSentanceNormalSelect)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

// With Select Many
var arrayOfEachSentance = sentance.SelectMany(x => x.Split(' ')).ToArray();

foreach (var arr in arrayOfEachSentance)
{
    Console.WriteLine(arr);
}
```

---

## ZIP

margin two collection into new collection with same type.

```sql

string[] colorName = { "Red", "Green", "blue" };

// extra value is oversize of array one
// (so it will be ignored)
string[] colorHEX = { "FF0000", "00FF00", "0000FF", "extra" };

// Extention Method
var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} By HEX will be {hex}");

// Query Syntaxt
var QueryColor = from x in colorName.Zip(colorHEX)
                 select $"{x.First} By HEX will be {x.Second}";

foreach (var color in colors)
{
    Console.WriteLine(color);
}
```