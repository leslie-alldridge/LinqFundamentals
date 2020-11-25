using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {



            var developers = new[]
            {
                new Employee {Id = 1, Name = "Leslie"},
                new Employee {Id = 2, Name = "Lisa"},
                new Employee {Id = 3, Name = "Steven"},
                new Employee {Id = 4, Name = "Lucy"}
            };

            var sales = new List<Employee>()
            {
                new Employee{ Id = 3, Name = "Alex"}
            };

            var querySyntax = from developer in developers
                where developer.Name.Length == 4
                orderby developer.Name
                select developer;

            var methodSyntax = developers.Where(e => e.Name.StartsWith("L"))
                .OrderByDescending(e => e.Name)
                .Select(e => e);

            foreach (var employee in methodSyntax)
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine("*****");

            foreach (var employee in querySyntax)
            {
                Console.WriteLine(employee.Name);
            }

        }
    }
}
