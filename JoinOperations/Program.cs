using JoinOperations.Models;

var employees = Repository.LoadEmployees();
var departements = Repository.LoadDepartment();

# region JOIN
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
from emp in employees
join dept in departements
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

#endregion


#region Group Join

// Method Syntax

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

#endregion