using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class Fields
    {
        int x;
        static int y = 200;
        const float pi = 3.14f;
        readonly bool flag;
        public Fields(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main()
        {
            Console.WriteLine("Static field y is: " + y);
            Console.WriteLine("Constant field pi is: " + pi);
            y = 500; //Can be modified
                     //pi = 5.67f; //Can't be modified & error if un-commented
            Console.WriteLine("Modified static field y is: " + y);
            Console.WriteLine("--------------------------------------------------");
            //Creating instances of the class
            Fields s1 = new Fields(50, true);
            Fields s2 = new Fields(150, false);
            Console.WriteLine("Non-Static Fields: " + (s1.x + "  " + s2.x));
            Console.WriteLine("ReadOnly Fields: " + (s1.flag + "  " + s2.flag));
            s1.x = 100; //Can be modified
            s2.x = 300; //Can be modified
                        //s1.flag = false; //Can't be modified & Error if un-commented 
                        //s2.flag = true; //Can't be modified & Error if un-commented
            Console.WriteLine("Modified Non-Static Fields: " + (s1.x + "  " + s2.x));
            Console.ReadLine();

        }
    }
}
