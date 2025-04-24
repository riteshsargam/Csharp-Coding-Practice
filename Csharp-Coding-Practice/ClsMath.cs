using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class ClsMath : IMath1, IMath2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main()
        {
            ClsMath obj = new ClsMath();
            obj.Add(100, 34); obj.Sub(576, 287);
            obj.Mul(12, 38); obj.Div(456, 2);
            Console.ReadLine();
        }
    }

}
