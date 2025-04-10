using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class Constructors
    {
        static Constructors()
        {
            Console.WriteLine("Static constructor is called.");
        }
        Constructors()
        {
            Console.WriteLine("Non-static constructor is called.");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called.");
            Constructors c1 = new Constructors();
            Constructors c2 = new Constructors();
            Constructors c3 = new Constructors();
            Console.ReadLine();
        }
    }
}
