
using Quantifiers.Models;

var emp = Repository.LoadEmployees();

#region Any

//Ex: Check if There is an employee with name start with 'jac'

var resultOne = emp.Any(x => x.Name.StartsWith("jac", StringComparison.OrdinalIgnoreCase));



Console.WriteLine(resultOne);

//Ex: check if There is an employees with salary less than $10,000

var resultTwo = emp.Any(x => x.Salary < 10_000);

Console.WriteLine(resultTwo);

//Ex: check if there  is an employee with one skill

var resultThree = emp.Any(x => x.Skills.Count() == 1);

// Query Syntax

var resultThreeQuery = from x in emp
                       where x.Skills.Any(s => s.Count() == 1)
                       select x;

Console.WriteLine(resultThree);

#endregion

#region All

//Ex: check if all employee have value for email

var emailValue = emp.All(x => !string.IsNullOrWhiteSpace(x.Email));
System.Console.WriteLine(emailValue);

//Ex: check if all employee have C# skill

var CSharpChecker = emp.All(x => x.Skills.Any(s => s == "C#"));

// Query Syntax

var CSharpCheckerQuery = from x in emp
                         where x.Skills.All(s => s == "C#")
                         select x;

Console.WriteLine(CSharpChecker);

#endregion

#region Contains

var containEmail = emp.Contains(new Employee { Email = "Cole.Cochran01@example.com" });

Console.WriteLine(containEmail);

#endregion


