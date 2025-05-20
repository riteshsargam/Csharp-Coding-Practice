using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    class Math<T>
    {
        public T Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2;
        }
        public T Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2;
        }
        public T Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 * d2;
        }

        public T Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 / d2;
        }
    }
    internal class TestGenericClass
    {
        static void Main()
        {
            Math<int> mi = new Math<int>();
            Console.WriteLine(mi.Add(100, 200));
            Console.WriteLine(mi.Sub(234, 123));
            Console.WriteLine(mi.Mul(12, 46));
            Console.WriteLine(mi.Div(900, 45));
            Console.WriteLine();

            Math<double> md = new Math<double>();
            Console.WriteLine(md.Add(145.35, 12.5));
            Console.WriteLine(md.Sub(45.6, 23.3));
            Console.WriteLine(md.Mul(15.67, 3.4));
            Console.WriteLine(md.Div(168.2, 14.5));
            Console.ReadLine();
        }
    }
}
