using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class DelDemo5
    {
        static void Main()
        {
            CalculatorDelegate cd = (a, b, c) => Console.WriteLine($"Product of given numbers: {a * b * c}");
            cd(10, 20, 30);
            cd(40, 50, 60);
            cd(70, 80, 90);

            WishDelegate wd = user => $"Hello {user}, welcome to the application.";
            Console.WriteLine(wd("Raju"));
            Console.WriteLine(wd("Pooja"));
            Console.WriteLine(wd("Praveen"));
            Console.ReadLine();
        }
    }
}
