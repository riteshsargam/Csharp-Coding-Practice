using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class ImplClass : Interface1, Interface2
    {
        //Implementing Test method using 1st approach
        public void Test()
        {
            Console.WriteLine("Method declared under 2 interfaces.");
        }
        //Implementing Show method using 2nd approach
        void Interface1.Show()
        {
            Console.WriteLine("Method declared under Interface1.");
        }
        //Implementing Show method using 2nd approach
        void Interface2.Show()
        {
            Console.WriteLine("Method declared under Interface2.");
        }
        static void Main()
        {
            ImplClass c = new ImplClass();
            c.Test();

            Interface1 i1 = c;
            Interface2 i2 = c;

            i1.Show();
            i2.Show();
            Console.ReadLine();
        }
    }
}
