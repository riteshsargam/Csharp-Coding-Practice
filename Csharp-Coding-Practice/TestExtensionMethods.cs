using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class TestExtensionMethods
    {
        static void Main()
        {

            MyStruct m = new MyStruct();
            m.Show();

            uint i = 8;
            ulong result = i.Factorial();
            Console.WriteLine($"Factorial of {i} is: {result}");

            string str = "heLlO hoW aRe YoU";
            str = str.ToPascal();
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
