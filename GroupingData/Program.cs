using GroupingData.Models;

var emp = Repository.LoadEmployees();

#region GroupBy

// Grouping Employee By Department

// Method Syntax
var departmentGroup = emp.GroupBy(x => x.Department);

// Query Syntax
var departmentGroupQuery =
from x in emp
group emp by x.Department;

foreach (var group in departmentGroup)
{
    var key = group.Key;
    group.Print($"Employees in {key} Department");
}

#endregion

#region To Look Up

// Grouping Employee By Department

var departmentGroupByToLookup = emp.ToLookup(x => x.Department);

foreach (var group in departmentGroupByToLookup)
{
    var key = group.Key;
    group.Print($"Employees in {key} Department");
}

#endregion