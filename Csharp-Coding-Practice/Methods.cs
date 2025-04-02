using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class Methods
    {
        //Non-value returning method without parameters 
        public void Test1() //Static in behavior  
        {
            int x = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }
        //Non-value returning method with parameters
        public void Test2(int x, int ub) //Dynamic in behavior      
        {
            for (int i = 1; i <= ub; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }
        }
        //Value returning method without parameters
        public string Test3() //Static in behavior  
        {
            string str = "hello world";
            str = str.ToUpper();
            return str;
        }
        //Value returning method with parameters
        public string Test4(string str) //Dynamic in behavior  
        {
            str = str.ToUpper();
            return str;
        }
        static void Main()
        {
            Methods p = new Methods();
            //Calling non-value returning methods.
            p.Test1();
            Console.WriteLine();

            p.Test2(8, 15);
            Console.WriteLine();

            //Calling value returning methods
            string s1 = p.Test3();
            Console.WriteLine(s1);

            string s2 = p.Test4("hello india");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }

}
