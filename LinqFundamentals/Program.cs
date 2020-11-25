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
                new Employee {Id = 3, Name = "Steven"}
            };

            var sales = new List<Employee>()
            {
                new Employee{ Id = 3, Name = "Alex"}
            };

            foreach (var employee in developers.Where(e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(employee.Name);
            }

        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
