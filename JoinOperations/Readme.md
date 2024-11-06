# Join Operations

## Join

use this method when you have two deferent tables and you want to show specific data from each table, Table One (Outer) Table Two (Inner), and it return new class that have your combining data.

```csharp
// Method Syntax
var joinOperation = employees.Join(
    departements,
     emp => emp.DepartmentId,
     dept => dept.Id,
     (emp, dept) => new EmployeeDto
     {
         FullName = emp.FullName,
         Departements = dept.Name
     });

// Query Syntax
var joinOperationQuerySyntax =
from emp in employees // Outer Key
join dept in departements // Inner Key
on emp.DepartmentId equals dept.Id
select new EmployeeDto
{
    FullName = emp.FullName,
    Departements = dept.Name
};

foreach (var item in joinOperation)
{
    Console.WriteLine($"Employee Name: {item.FullName} : Department: {item.Departements}");
}

```

---

## Group Join

this method doing same as join method, but it will group your data based on specific inner key, and return key and List of Outer table data.

```csharp
var groupJoinOperation = departements.GroupJoin(
    employees,
    dept => dept.Id, // Inner Key
    emp => emp.DepartmentId, // Outer Key
    (dept, emp) => new Group
    {
        Departements = dept.Name,
        Employees = emp.Select(x => x.FullName).ToList()
    }
    );

// Query Syntax

var groupJoinOperationQuerySyntax =
 from dept in departements
 join emp in employees
 on dept.Id equals emp.DepartmentId into empGroup
 select empGroup;

foreach (var item in groupJoinOperation)
{
    System.Console.WriteLine(item.Departements);
    // System.Console.WriteLine("==================== Group ====================");
    foreach (var emp in item.Employees)
    {
        // System.Console.WriteLine(emp.FullName);
        System.Console.WriteLine(emp);
    }
}
```