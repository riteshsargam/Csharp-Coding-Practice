using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class MethodParameters
    {
        public void AddParams(params double[] args)
        {
            double Sum = 0;
            foreach (double arg in args)
            {
                Sum = Sum + arg;
            }
            Console.WriteLine($"Sum of {args.Length} no's in the array is: {Sum}");
        }
        public void AddNums(int x, int y = 50, int z = 25)
        {
            Console.WriteLine($"Sum of given 3 no's is: {x + y + z}");
        }
        static void Main()
        {
            MethodParameters obj = new MethodParameters();

            obj.AddParams(56.87);
            obj.AddParams(78, 12.35);
            obj.AddParams(12.34, 56.32, 87.21);
            obj.AddParams(10, 20, 30, 40, 50);
            Console.WriteLine();

            obj.AddNums(100);
            obj.AddNums(100, 100);
            obj.AddNums(100, z: 100);
            obj.AddNums(100, 100, 100);
            Console.ReadLine();
        }
    }
}
