# Grouping Data

## Group By

Grouping collection based on key you pass to it and return IEnumerable<Key,Source>

- Using Deferred Execution
- each iterate ⇒ group again
- return IEnumrable<IGrouping<TKey,TSource>>

```sql
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
```

---

## ToLookup

Grouping collection based on key you pass to it and return IEnumerable<Key,Source>

- Using immediate Execution
- buffer the result in memory (multiple process)
- return ILookup<TKey,TSource>

```sql
// Grouping Employee By Department

var departmentGroupByToLookup = emp.ToLookup(x => x.Department);

foreach (var group in departmentGroupByToLookup)
{
    var key = group.Key;
    group.Print($"Employees in {key} Department");
}
```