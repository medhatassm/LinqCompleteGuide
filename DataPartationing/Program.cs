using DataPartationing.Models;

// Get All Employees Data
var Employees = Repository.LoadEmployees();

#region Skip & Skip Last

var skipFirstTenElement = Employees.Skip(10); // Skip First 10 Elements

skipFirstTenElement.Print("Skip First 10 Elements");

var skipLastTenElement = Employees.SkipLast(10); // Skip Last 10 Elements

skipLastTenElement.Print("Skip Last 10 Elements");

#endregion

#region Skip While

var skipUntilSalary = Employees.SkipWhile(x => x.Salary != 214400); // Skip Under Condition

skipUntilSalary.Print("Skip Until Salary = 214400");

#endregion

#region Take

var takeFirstTenElement = Employees.Take(10); // Take First 10 Elements

takeFirstTenElement.Print("Take First 10 Elements");

var takeLastTenElement = Employees.TakeLast(10); // Take Last 10 Elements

takeLastTenElement.Print("Take Last 10 Elements");

#endregion

#region Take While

var takeUntilSalary = Employees.TakeWhile(x => x.Salary != 214400); // Take Under Condition

takeUntilSalary.Print("Take Until Salary = 214400");

#endregion

#region Chunks

var chunks = Employees.Chunk(10).ToList();

for (int i = 0; i < chunks.Count(); i++)
{
    chunks[i].Print($"Chunks #{i + 1}");
}

#endregion



