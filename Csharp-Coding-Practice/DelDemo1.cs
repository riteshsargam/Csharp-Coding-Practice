using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class DelDemo1
    {
        public void AddNums(int x, int y, int z)
        {
            Console.WriteLine($"Sum of given 3 no's is: {x + y + z}");
        }
        public static string SayHello(string Name)
        {
            return $"Hello {Name}, have a nice day!";
        }
        static void Main()
        {
            DelDemo1 obj = new DelDemo1();

            CalculatorDelegate cd = obj.AddNums;
            cd(10, 20, 30); cd(40, 50, 60); cd(70, 80, 90);

            WishDelegate wd = DelDemo1.SayHello;
            Console.WriteLine(wd("Raju"));
            Console.WriteLine(wd("Vijay"));
            Console.WriteLine(wd("Naresh"));

            Console.ReadLine();
        }
    }
}
