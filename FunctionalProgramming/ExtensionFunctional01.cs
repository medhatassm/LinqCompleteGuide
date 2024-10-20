using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionalProgramming.models;

namespace FunctionalProgramming
{
    public static class ExtensionFunctional01
    {
        public static IEnumerable<Employee> Filter(IEnumerable<Employee> source
        , Predicate<Employee> predicate)
        {
            // var employees = Repository.LoadEmployees(); Get Data as parameters (source)
            foreach (var employee in source)
            {
                // Imperative code
                if (predicate(employee)/*employee.FirstName.ToLowerInvariant().StartsWith(value.ToLowerInvariant())*/)
                {
                    yield return employee;
                }
            }
        }

        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
                Console.WriteLine(item);
        }
    }
}