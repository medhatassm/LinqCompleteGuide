#region Statement

// Declaration statement.
int counter;

// Assignment statement.
counter = 1;

// Declare and initialize
const double pi = 3.14159; // Declare and initialize  constant.

// foreach statement
foreach (var item in new int[] { 1, 2, 3 })
{

}

// for statement
for (int i = 0; i < 10; i++)
{

}

// if , if - else if -else , 
if (true)
{

}

// switch, jump, do, while 

#endregion

#region Expresion

// Expresion 
var radius = 10;

var area = 3.14 * (radius * radius); // expression  3.14 * (radius * radius) yield a value

// 3.14 * (radius * radius);

// method invocation (this method yield void
Console.WriteLine(area);

// new object creation 
var names = new string[] { "ali", "ahmad", "reem" };

// statement can include expression and not the other way around

static void DoSomething()
{
    return;
}

#endregion