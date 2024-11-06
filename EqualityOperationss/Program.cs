using EqualityOperationss.Models;

#region SequenceEqual

var questionsOne = QuestionBank.PickOne();
var questionsTwo = QuestionBank.PickOne();
var questionsThree = QuestionBank.PickOne();

var quizOne = new List<Question>(new[] { questionsOne, questionsTwo, questionsThree });
var quizTwo = new List<Question>(new[] { questionsOne, questionsTwo, questionsThree });

var quizOneEqualQuizTwo = quizOne.SequenceEqual(quizTwo);
// First Check if Number of element is the same (index)
// Second Check if each element in first collection equal to elements in second collection

Console.WriteLine(quizOneEqualQuizTwo);

#endregion

