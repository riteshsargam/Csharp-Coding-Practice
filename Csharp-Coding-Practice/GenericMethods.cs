using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class GenericMethods
    {
        public bool AreEqual<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }
        static void Main()
        {
            GenericMethods obj = new GenericMethods();
            Console.WriteLine(obj.AreEqual<int>(100, 200));
            Console.WriteLine(obj.AreEqual<bool>(true, true));
            Console.WriteLine(obj.AreEqual<double>(34.56, 87.12));
            Console.WriteLine(obj.AreEqual<string>("Hello", "Hello"));
            Console.ReadLine();
        }
    }
}
