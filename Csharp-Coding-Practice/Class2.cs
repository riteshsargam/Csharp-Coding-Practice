using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("Class2 constructor is called.");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        public void Test4()
        {
            Console.WriteLine("Method 4");
        }
        static void Main()
        {
            Class2 c = new Class2();
            c.Test1(); c.Test2();   //Calling members of parent class
            c.Test3(); c.Test4();   //Calling members of current class
            Console.ReadLine();
        }

    }
}
