using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class ListDemo
    {
        static void Main()
        {
            List<int> Coll = new List<int>();
            Coll.Add(10); Coll.Add(20); Coll.Add(30); Coll.Add(40); Coll.Add(50);

            for (int i = 0; i < Coll.Count; i++)
            {
                Console.Write(Coll[i] + "  ");
            }
            Console.WriteLine();

            Coll.Insert(3, 35);
            foreach (int i in Coll)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            Coll.Remove(30);
            foreach (int i in Coll)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
