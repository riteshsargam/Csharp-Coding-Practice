using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class DelDemo3
    {
        static void Main()
        {
            CalculatorDelegate cd = delegate (int a, int b, int c)
            {
                Console.WriteLine($"Product of given numbers: {a * b * c}");
            };
            cd(10, 20, 30);
            cd(40, 50, 60);
            cd(70, 80, 90);

            WishDelegate wd = delegate (string user)
            {
                return $"Hello {user}, welcome to the application.";
            };
            Console.WriteLine(wd("Raju"));
            Console.WriteLine(wd("Pooja"));
            Console.WriteLine(wd("Praveen"));

            Console.ReadLine();
        }
    }
}
