using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    partial class Test
    {
        partial void Method1()  //Implementing the Partial Method declared in Test1.cs under Test2.cs
        {
            Console.WriteLine("Method 1.");
        }
        static void Main()
        {
            Test obj = new Test();
            obj.Method2; Console.ReadLine();
        }
    }
}
