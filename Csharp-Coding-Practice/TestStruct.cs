using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    struct TestStruct
    {
        static void Main()
        {
            MyStruct obj1 = new MyStruct(); obj1.Display();
            MyStruct obj2 = new MyStruct(30); obj2.Display();
            Console.ReadLine();
        }
    }
}
