using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class AbsChild : AbsParent
    {
        public override void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public override void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void Mod(int a, int b)
        {
            Console.WriteLine(a % b);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            c.Add(100, 50); c.Add(75, 17);
            c.Mul(12, 13); c.Div(870, 15);
            Console.ReadLine();
        }
    }
}
