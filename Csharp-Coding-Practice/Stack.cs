using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Csharp_Coding_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push('A'); s.Push(100); s.Push(false); s.Push(34.56); s.Push("Hello");

            foreach (object obj in s)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            Console.WriteLine(s.Pop());
            foreach (object obj in s)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            Console.WriteLine(s.Peek());
            foreach (object obj in s)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
            Console.WriteLine($"No. of items in the Stack: {s.Count}");
            s.Clear();
            Console.WriteLine($"No. of items in the Stack: {s.Count}");
            Console.ReadLine();
        }
    }
}
