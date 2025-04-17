using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class LoadChild: LoadParent
    {
        //Overloading parent's Test method in child
        public void Test(int i)
        {
            Console.WriteLine("Child Class Test Method Is Called.");
        }
        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Test();       //Executes parent class Test method
            c.Test(10);     //Executes child class Test method
            c.Show();           //Executes parent class Show method
            c.Display();    //Executes parent class Display method 
            Console.ReadLine();
        }
    }
}
