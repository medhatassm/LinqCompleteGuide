# Data Partitioning

## Skip

- **Skip** ⇒ First n elements then return collection.
- **SkipLast** ⇒ Last n element then return collection.
- **SkipWhile** ⇒ n elements under condition then return collection.

```sql
var skipFirstTenElement = Employees.Skip(10); // Skip First 10 Elements

skipFirstTenElement.Print("Skip First 10 Elements");

var skipLastTenElement = Employees.SkipLast(10); // Skip Last 10 Elements

skipLastTenElement.Print("Skip Last 10 Elements");

var skipUntilSalary = Employees.SkipWhile(x => x.Salary != 214400); // Skip Under Condition

skipUntilSalary.Print("Skip Until Salary = 214400");
```

---

## Take

- **Take** ⇒ First n elements then return collection.
- **TakeLast** ⇒ Last n element then return collection.
- **TakeWhile** ⇒ n elements under condition then return collection.

```sql
var takeFirstTenElement = Employees.Take(10); // Take First 10 Elements

takeFirstTenElement.Print("Take First 10 Elements");

var takeLastTenElement = Employees.TakeLast(10); // Take Last 10 Elements

takeLastTenElement.Print("Take Last 10 Elements");

var takeUntilSalary = Employees.TakeWhile(x => x.Salary != 214400); // Take Under Condition

takeUntilSalary.Print("Take Until Salary = 214400");
```

---

## Chunk

split collection to multiplay collections and return collection<collections>, (each collection have n element)

```sql
var chunks = Employees.Chunk(10).ToList();

for (int i = 0; i < chunks.Count(); i++)
{
    chunks[i].Print($"Chunks #{i + 1}");
}
```

---

> Take a look of Pagination System To learn more of what you can do with Skip,Take,Chunks Methods.
>