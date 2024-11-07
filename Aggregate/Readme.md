### Aggregate

take two collection and manipulate them based on return code you write the return element of new value (summation all value in two collection).

```csharp
var names = new[] { "Ali", "Salem", "Abeer", "Reem", "Jalal" };

// Old Way
var output = "";
foreach (var name in names)
{
    output += $"{name},";
}

// Console.WriteLine(output.TrimEnd(','));

// New Way But (Not LINQ)
var output2 = string.Join(',', names);
Console.WriteLine(output2);

// With LINQ

var commaSaperatedName = names.Aggregate((a, b) =>
{
    Console.WriteLine($"a = {a} , b = {b}");
    return $"{a},{b}";
});
Console.WriteLine(commaSaperatedName);
```