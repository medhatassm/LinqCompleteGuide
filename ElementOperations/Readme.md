# Element Operations

## ElementAt

return value from collection by index, or if index out of range using **ElementAtDefault** to return null.

```csharp
// Get Question at index 10
var questionAt10 = questions.ElementAt(10);

Console.WriteLine(questionAt10);

// Out of range exception solution
var questionOutOfRange = questions.ElementAtOrDefault(300);

if (questionOutOfRange is null)
{
    System.Console.WriteLine("No Question At this index");
}
else
{
    Console.WriteLine(questionOutOfRange);
}
```

---

## First & Last

return **First** Or **Last** element of collection, or return **First** Or **Last** value match the predicate.

```csharp
var firstQuestion = questions.First(); // return first value
Console.WriteLine(firstQuestion);

//var firstQuestionWithCondition = questions.First(x=> x.Title.Length == 0); // Invalid Operation Exception

// Solution Of That Error
var firstQuestionWithCondition = questions.FirstOrDefault(x => x.Title.Length == 0); // return null if nothing found
Console.WriteLine(firstQuestionWithCondition);

//=============================================================================

var lastQuestion = questions.Last(); //return last value
Console.WriteLine(lastQuestion);

var lastQuestionWithCondition = questions.LastOrDefault(x => x.Title.Length == 0); // return null if nothing found
Console.WriteLine(lastQuestionWithCondition);
```

---

## Single

return single element that match predicate, If there is more than one value match the predicate return Invalid Operation Exception.

```csharp
var singleQuestion = questions.Single(x => x.Title.Contains("#245"));
// If there is more than one value match 
// the predicate return Invalid Operation Exception

// Soulution of this problem
var singleQuestionWithDefault = questions.SingleOrDefault(x => x.Title.Contains("#245")); 
//return null if exception return
```