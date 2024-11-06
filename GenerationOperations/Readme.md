# Generation Operations

## Empty List

create empty list with normal way reduce the performance of your project if you use the list after a lot of line of coding, but there is better way to declare empty function without reducing performance.

```csharp
// Create Empty List Normal Way (Not Recommended)
var questions = new List<Question>(); // Empty List

// 1 line
// .....
// 1000 line
foreach (var q in questions)
{
    Console.WriteLine(questions);
}

// Create Empty List (Recommended)

var questionsEmpty = Enumerable.Empty<Question>(); // Empty List

// 1 line
// .....
// 1000 line
foreach (var q in questionsEmpty)
{
    Console.WriteLine(questionsEmpty);
}

```

---

## DefaultIfEmpty

return default of datatype of the list.

let’s see example about `default` keyword first

```csharp
// default keyword
Console.WriteLine(default(int)); // return default of type (int => 0)
Console.WriteLine(default(DateTime)); // return default of type (DateTime => 1/1/0001 12:00:00 AM)
Console.WriteLine(default(Object) is null ? "Null" : default(Object)); // return default of type (Object => Null)
```

now you know the default keyword return the default value of datatype, now let’s see how LINQ make this can be use with lists (IEnumrable)

```csharp
var questionsEmptyExample = Enumerable.Empty<Question>(); // Empty List

var questionsDefultOfEmpty = questionsEmptyExample.DefaultIfEmpty(); //return default of datatype of list.
// is null
//  ? null
//  : questionsEmptyExample.DefaultIfEmpty(); 

questionsDefultOfEmpty.ToQuiz();

var questionsDefult = questions.DefaultIfEmpty(Question.Default); // if list was empty return Default Function
questionsDefult.ToQuiz();
```

---

## Range Operation

return sequence of integrate number

```csharp
var range = Enumerable.Range(1, 10);

foreach (int num in range)
{
    Console.WriteLine(num);
}
```

---

## Repeat

return a collection of repeated list

```csharp
var repeatList = Enumerable.Repeat("=", 50);
foreach (var equal in repeatList)
{
    Console.Write(equal);
}
```