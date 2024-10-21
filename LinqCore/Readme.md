### LINQ Advantages

- MS.Net Component (language + feature).
- Type Safe Queries.
- Query Local Object (IEnumerable <T>).
- LINQ to remote (SQL) (IQueryable<T>).
- Set of Query operator (Extension Method).

> LINQ ⇒ Language **Integrated** Query
> 

> LINQ only work for IEnumerable or collection inherited from it.
> 

### Projection Operation

- **Where()**
    
    Filter your data and return IEnumerable list.
    
    - Take Predicate (delegate) as argument.
    - Store reference object of original list.
    
    Without Using LINQ
    
    ```csharp
    var employees = Repository.LoadEmployees(); // Get All Employees
    var femaleWithFirstNameStartWithS = employees.Filter(e => e.Gender == "female" &&
     e.FirstName.ToLowerInvariant().StartsWith("s"));
    
    femaleWithFirstNameStartWithS.Print("Female With FirstName Start With S");
    ```
    
    With LINQ
    
    ```csharp
    var femaleWithFirstNameStartWithSWithLINQ = employees.Where(e => e.Gender == "female" &&
     e.FirstName.ToLowerInvariant().StartsWith("s"));
    
    femaleWithFirstNameStartWithSWithLINQ.Print("Female With FirstName Start With S With LINQ (Where)");
    ```
    
    > Every thing before Enumeration (ForEach) w’ll be effect the object that use where method, Once Enumerated then nothing will effect the object.
    > 
    
      
    
    ```csharp
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    
    // Extention Where
    var evenNumber = numbers.Where(item => item % 2 == 0); // Store Refreance of orginal list
    
    numbers.Add(12);
    numbers.Add(14);
    numbers.Add(11);
    numbers.Remove(4);
    
    evenNumber.Print("Extention Method");
    // Every thing before foreach (Enumration) will be effect evenNumber and change its value.
    numbers.Add(10); // Once Enumrated Nothing effect evenNumber.
    ```
    
    **There are three way to use LINQ Method**
    
    - **Extension**
        
        ```csharp
        var evenNumber = numbers.Where(item => item % 2 == 0);
        ```
        
    - **Enumerable Class**
        
        ```csharp
        var evenNumberEnumrableWhereMethod = Enumerable.Where(numbers, item => item % 2 == 0);
        ```
        
    - **Query Syntax**
        
        ```csharp
        var evenNumberUsingQuerySyntax =
            from item in numbers
            where item % 2 == 0
            select item;
        ```
        
    
    > We can use LINQ Method with object of LINQ method, even as we know that LINQ method return object with (predicate, reference original list)
    > 
    > 
    > ```csharp
    > var empMale = employees.Where(item => item.Gender == "male");
    > 
    > empMale.Print("Male Employee");
    > 
    > var empMaleInHRDepartment = empMale.Where(item => item.Department.ToLowerInvariant() == "hr");
    > 
    > empMaleInHRDepartment.Print("Male Employee in HR Department");
    > ```
    > 
- **Select()**
    
    Produces Values that are based on transform function.
    
    ```csharp
        string[] wordsArr = { "I", "love", "ASP.Net", "Core" };
    
        List<string> words = new() { "i", "love", "asp.net", "core" };
    
        var selectResult = words.Select(item => item.ToUpper());
    ```
    
    ```csharp
    // Query Syntax
    var selectResultWithQueySyntax = from item in numbers select item * item; 
    ```
    
    ---
    
- **SelectMany()**
    
    Produces sequences of values then flattens them into one sequence
    
    ```csharp
    string[] sentance = { "i love asp.net", "i like sql server also", "in general i love programming" };
    
    var selectManyResult = sentance.SelectMany(item => item.Split(' '));
    ```
    
    ```csharp
    //Query Syntax (Dapper)
        var selectManyResultQuerySyntax = (from item in sentance
                                           from item in item.Split(' ')
                                           select item).Distinct();
    ```
    
    ---
    
- **Zip()**
    
    Produces a sequence of tuples with element from 2 - 3 specified sequence
    
    ```csharp
    var employees = RepositoryForSelect.LoadEmployees().ToArray();
    var firstThreeEmp = employees[..3];
    var lastThreeEmp = employees[^3..];
    
    var team = firstThreeEmp.Zip(lastThreeEmp, (first, last) => $"({first.FullName}) With ({last.FullName})");
    ```
    
    ```csharp
    // Query Syntax
      var teams = from item in firstThreeEmp.Zip(lastThreeEmp)
                  select $"({item.First.FullName}) With ({item.Second.FullName})";
    ```
    

---

### Sorting Data

- **OrderBy() & ThenBy()**
    
    To order a sequence by the value of the element themselves.
    
    ```csharp
    string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };
    
    // Method Syntax
    var orderFruits = fruits.OrderBy(item => item).ThenBy(item => item.Length); // ASC
    
    var orderFruitsDESC = fruits.OrderByDescending(item => item); // DSC
    
    var orderFruitsByLength = fruits.OrderByDescending(item => item.Length); // DSC By Length
    ```
    
    ```csharp
    string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };
    
    // Query Syntax
    var orderFruitsQuerySyntax = from item in fruits
                                 orderby item
                                 select item;
    
    var orderFruitsBylengthQuerySyntax = from item in fruits
                                         orderby item.Length
                                         select item;
    
    var orderFruitsQuerySyntaxDESC = from item in fruits
                                     orderby item descending
                                     select item;
    ```
    

---

### Data Partitioning

- **Skip() (While - Last)**
    
    Skip is used to skip or bypass the (first , last or on condition) n number of element from a data source or sequence and return the remaining element.
    
    ```csharp
    var skipFirst10Element = allEmployees.Skip(10);
    
    var skipWhile = allEmployees.SkipWhile(e => e.Salary != 343200);
    
    var skipLast10Element = allEmployees.SkipLast(10);
    ```
    
    ---
    
- **Take() (While - Last)**
    
    Fetches the first “n” number of elements from the data source, where “n” is an integer passed as a parameter to the ***LINQ Take*** method.
    
    ```csharp
    var takeFirst10Element = allEmployees.Take(10);
    
    var takeWhile = allEmployees.TakeWhile(e => e.Salary != 343200);
    
    var takeLast10Element = allEmployees.TakeLast(10);
    ```
    
    ---
    
- **Chunks**
    
    Split a collection into buckets or “chunks” of at most same size, it receives the chunk size and return a collection of arrays.
    
    ```csharp
    var chunks = allEmployees.Chunk(15).ToList();
    
    for (int i = 0; i < chunks.Count(); i++)
    {
        chunks[i].Print($"Chunck #{i + 1}");
    }
    ```