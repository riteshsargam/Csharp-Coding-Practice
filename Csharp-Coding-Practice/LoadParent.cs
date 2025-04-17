using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class LoadParent
    {
        public void Test()
        {
            Console.WriteLine("Parent Class Test Method Is Called.");
        }
        public virtual void Show()  //Overridable
        {
            Console.WriteLine("Parent Class Show Method Is Called.");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method Is Called.");
        }
    }
}
