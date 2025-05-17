using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class ArrayListDemo
    {
        static void Main()
        {
            ArrayList Coll1 = new ArrayList();
            Console.WriteLine($"Initial capacity: {Coll1.Capacity}");

            Coll1.Add('A');
            Console.WriteLine($"Capacity of the collection after adding 1st item: {Coll1.Capacity}");

            Coll1.Add(100); Coll1.Add(false); Coll1.Add(34.56);
            Console.WriteLine($"Capacity of the collection after adding 4th item: {Coll1.Capacity}");

            Coll1.Add("Hello");
            Console.WriteLine($"Capacity of the collection after adding 5th item: {Coll1.Capacity}");

            for (int i = 0; i < Coll1.Count; i++)
            {
                Console.Write(Coll1[i] + "  ");
            }
            Console.WriteLine();

            // Remove 1 item at index 2
            Coll1.RemoveRange(2, 1);
            foreach (object obj in Coll1)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            // Insert item at index 2
            Coll1.Insert(2, true);
            foreach (object obj in Coll1)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine("\n");

            ArrayList Coll2 = new ArrayList(Coll1);
            foreach (object obj in Coll2)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
            Console.WriteLine($"Initial capacity of new collection: {Coll2.Capacity}");
            Coll2.Add(false);
            Console.WriteLine($"Capacity of new collection after adding new item: {Coll2.Capacity}");
            Coll2.TrimToSize();
            Console.WriteLine($"Capacity of new collection after calling TrimToSize: {Coll2.Capacity}");

            Console.ReadLine();
        }
    }
}
