using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    namespace OOPSProject
    {
        internal class AnonymousType
        {
            static void Main()
            {
                var Emp = new
                {
                    Id = 1001,
                    Name = "Raju",
                    Job = "Manager",
                    Salary = 50000.00,
                    Status = true,
                    Dept = new { Id = 10, Name = "Sales", Location = "Hyderabad" }
                };
                Console.WriteLine(Emp.GetType() + "\n");
                Printer.Print(Emp);
                Console.ReadLine();
            }
        }
        internal class Printer
        {
            public static void Print(dynamic d)
            {
                Console.WriteLine($"Employee Id: {d.Id}");
                Console.WriteLine($"Employee Name: {d.Name}");
                Console.WriteLine($"Employee Job: {d.Job}");
                Console.WriteLine($"Employee Salary: {d.Salary}");
                Console.WriteLine($"Employee Status: {d.Status}");
                Console.WriteLine($"Department Id: {d.Dept.Id}");
                Console.WriteLine($"Department Name: {d.Dept.Name}");
                Console.WriteLine($"Department Location: {d.Dept.Location}");
            }
        }
    }
}
