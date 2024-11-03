# Pure V.S Impure Function

## Statement And Expression

### Statement

Can Consist of a single line of code that end in a semicolon.

```sql
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
```

### Expressions

is a sequence operators & operands that yield a value

```sql
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
```

---

## Pure And Impure Functions

### Impure Function

- Impure mutate parameter.
- impure mutate global variables
- impure interaction with outside world

### Pure Function

- Easy to test
- pure don’t mutate parameter.
- pure don’t mutate global variables
- pure don’t interaction with outside world

```sql
static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Print(numbers);

// AddInteger1(3);

//var x = 2;
//AddInteger2(ref x);

//AddInteger3();

var newList = AddInteger4(numbers, 3);
Console.WriteLine("old list");
Print(numbers);
Console.WriteLine("new list");
Print(newList);

static void Print(List<int> source)
{
    foreach (var item in source)
    {
        Console.Write($" {item}");
    }
    Console.WriteLine();
}

static void AddInteger1(int num)
{
    numbers.Add(num); // impure mutate global variable
}

static void AddInteger2(ref int num)
{
    num++; // impure mutate parameter
    numbers.Add(num);
}

static void AddInteger3()
{
    numbers.Add(new Random().Next()); // impure interation with outside world
}

static List<int> AddInteger4(List<int> numbers, int num)
{
    var result = new List<int>(numbers); // This is pure function
    result.Add(num);
    return result;
}
```