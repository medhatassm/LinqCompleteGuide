using ElementOperations.Models;

var questions = QuestionBank.All;

#region Element At

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



#endregion

#region First

var firstQuestion = questions.First(); // return first value
Console.WriteLine(firstQuestion);

//var firstQuestionWithCondition = questions.First(x=> x.Title.Length == 0); // Invalid Operation Exception

// Solution Of That Error
var firstQuestionWithCondition = questions.FirstOrDefault(x => x.Title.Length == 0); // return null if nothing found
Console.WriteLine(firstQuestionWithCondition);

#endregion

#region Last

var lastQuestion = questions.Last(); //return last value
Console.WriteLine(lastQuestion);


var lastQuestionWithCondition = questions.LastOrDefault(x => x.Title.Length == 0); // return null if nothing found
Console.WriteLine(lastQuestionWithCondition);

#endregion

#region Single

var singleQuestion = questions.Single(x => x.Title.Contains("#245"));
// If there is more than one value match 
// the predicate return Invalid Operation Exception

// Soulution of this problem
var singleQuestionWithDefault = questions.SingleOrDefault(x => x.Title.Contains("#245"));
//return null if exception return

#endregion