using System;
using LinqCore.models;

namespace LinqCore;

public static class ExtensionFunctional
{
    public static IEnumerable<Employee> Filter(this IEnumerable<Employee> source, Func<Employee, bool> predicate) //  Func<Employee, bool> predicate =  Predicate<Employee> predicate 
    {
        foreach (var employee in source)
        {
            if (predicate(employee))
            {
                yield return employee;
            }
        }
    }

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
            if (typeof(T).IsValueType)
            {
                Console.Write($" {item} "); // 1 , 2 , 3
            }
            else
            {
                Console.WriteLine(item);
            }
    }
}
