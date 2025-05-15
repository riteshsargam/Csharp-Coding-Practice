using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    partial class Test
    {
        partial void Method1();         //Partial method declaration in Test1.cs file
        public void Method2()
        {
            Console.WriteLine("Method 2.");
            Method1();          //Calling the Partial Method declared above
        }
    }
}
