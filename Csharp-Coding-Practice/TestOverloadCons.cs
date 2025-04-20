using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class OverloadCons
    {
        int i; bool b;
        public OverloadCons()
        {
            //Initializes i & b with default values
        }
        public OverloadCons(int i)
        {
            //Initializes b with default value and i with given value
            this.i = i;
        }
        public OverloadCons(bool b)
        {
            //Initializes i with default value and b with given value
            this.b = b;
        }
        public OverloadCons(int i, bool b)
        {
            //Initializes both i & b with given values
            this.i = i;
            this.b = b;
        }
        public void Display()
        {
            Console.WriteLine($"Value of i is: {i} and value of b is: {b}");
        }
    }
    internal class TestOverloadCons
    {
        static void Main()
        {
            OverloadCons c1 = new OverloadCons();
            c1.Display();
            OverloadCons c2 = new OverloadCons(10);
            c2.Display();
            OverloadCons c3 = new OverloadCons(true);
            c3.Display();
            OverloadCons c4 = new OverloadCons(10, true);
            c4.Display();
            Console.ReadLine();
        }
    }
}
