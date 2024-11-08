// Normal Delegate

using System.Linq.Expressions;

Func<int, bool> IsEven = num => num % 2 == 0;
Console.WriteLine(IsEven(10));

#region Experssions

Expression<Func<int, bool>> IsEvenExpression = num => num % 2 == 0;
Func<int, bool> isEvenTwo = IsEvenExpression.Compile(); // Convert the experssion to delegate
Console.WriteLine(isEvenTwo(10));

#endregion