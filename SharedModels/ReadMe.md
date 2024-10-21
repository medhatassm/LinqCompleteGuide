## Shared Models

This a class library that include file which has models class (data) that i use to test LINQ method .

- **Employee.cs**
    
    This file has all properties of employee data.
    
    ```csharp
    public int Index { get; set; }
    public string EmployeeNo { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    public decimal Salary { get; set; }
    
    public List<string> Skills { get; set; } = new List<string>();
    ```
    
- **Repository.cs**
    
    This file include seed data to **Employee.cs** class and have `loadEmployee()` method to get all employee to use in my projects.
    
    ```csharp
    public static IEnumerable<Employee> LoadEmployees()
            {
                return new List<Employee>
                {
                    new Employee
                    {
                         Index = 1,
                         EmployeeNo = "2017-FI-8516",
                         Name = "Cochran Cole",
                         Email = "Cole.Cochran@example.com",
                         Salary = 103200,
                         Skills = new() {"Javascript" , "NodeJS"  }
                    },
                    new Employee
                    {
                         Index = 2,
                         EmployeeNo = "2018-FI-4815",
                         Name = "Jaclyn Wolfe",
                         Email = "Wolfe.Jaclyn@example.com",
                         Salary = 192400,
                         Skills = new() {"C++" , "Javascript" , "Oracle"  }
                    },
                    new Employee
                    {
                         Index = 3,
                         
    						more code..... 
    				}
    			};
    		}
    	}
    }
    ```
    
- **ExtensionFunctional.cs**
    
    This file include extension method called **Print()**, i use it to re-formate my out put to have a title and good style before it print to my console, that make me description all output so easily.
    
    ```csharp
    public static void Print<T>(this IEnumerable<T> source, string title)
    {
        if (source == null)
            return;
        Console.WriteLine();
        Console.WriteLine("┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
        Console.WriteLine("└───────────────────────────────────────────────────────┘");
        Console.WriteLine();
        foreach (var item in source)
        {
            if (typeof(T).IsValueType)
                Console.Write($" {item} "); // 1, 2, 3
            else
                Console.WriteLine(item);
        }
    
    }
    ```
    
- **EmplyeeDto**
    
    Just a class using to explain how **Zip()** method work.