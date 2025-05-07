using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class ThrowDemo
    {
        static void Main()
        {
            Console.Write("Enter 1st number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 > 0)
            {
                throw new ApplicationException("Divisor can't be an odd number.");
                //throw new DivideByOddNoException();     
            }
            int z = x / y;
            Console.WriteLine("The result of division is: " + z);
            Console.WriteLine("End of the Program.");
        }
    }
}
