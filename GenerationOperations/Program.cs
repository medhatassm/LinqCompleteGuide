using GenerationOperations.Models;

#region Empty List
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

#endregion


#region Defult of Empty

// Using With Left || Right Outer Join

// default keyword
Console.WriteLine(default(int)); // return default of type (int => 0)
Console.WriteLine(default(DateTime)); // return default of type (DateTime => 1/1/0001 12:00:00 AM)
Console.WriteLine(default(Object) is null ? "Null" : default(Object)); // return default of type (Object => Null)

var questionsEmptyExample = Enumerable.Empty<Question>(); // Empty List

var questionsDefultOfEmpty = questionsEmptyExample.DefaultIfEmpty(); //return default of datatype of list.
// is null
//  ? null
//  : questionsEmptyExample.DefaultIfEmpty(); 

questionsDefultOfEmpty.ToQuiz();

var questionsDefult = questions.DefaultIfEmpty(Question.Default); // if list was empty return Default Function
questionsDefult.ToQuiz();

#endregion

#region Range Operation

// Genrate Number From 1 to 10 and return it into IEnumerable
var range = Enumerable.Range(1, 10);

foreach (int num in range)
{
    Console.WriteLine(num);
}

var questionsRange = QuestionBank.GetQuestionRange(range);
questionsRange.ToQuiz();

#endregion

#region Repeat

var repeatList = Enumerable.Repeat("=", 50);
foreach (var equal in repeatList)
{
    Console.Write(equal);
}

#endregion