# Concatenation

## Concat

Concat Two Collection to each other and return collection.

```csharp
using Concatenation.Models;

var threeQuestions = QuestionBank.Randomize(3);
var twoQuestions = QuestionBank.Randomize(2);

var fiveQuestions = threeQuestions.Concat(twoQuestions);
foreach (var question in fiveQuestions)
{
    Console.WriteLine(question);
}

```