using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class ParamConDemo
    {
        public ParamConDemo(int i)
        {
            Console.WriteLine($"Parameterized constructor is called: {i}");
        }
        static void Main()
        {
            ParamConDemo cd1 = new ParamConDemo(100);
            ParamConDemo cd2 = new ParamConDemo(200);
            ParamConDemo cd3 = new ParamConDemo(300);
            Console.ReadLine();
        }
    }
}
