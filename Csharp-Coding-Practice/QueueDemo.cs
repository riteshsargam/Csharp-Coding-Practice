using System;
using System.Collections;

namespace Csharp_Coding_Practice
{
    internal class QueueDemo
    {
        static void Main()
        {
            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue(100);
            q.Enqueue(false);
            q.Enqueue(34.56);
            q.Enqueue("Hello");

            foreach (object obj in q)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            Console.WriteLine(q.Dequeue());
            foreach (object obj in q)
            {
                Console.Write(obj + "  ");
            }
            Console.ReadLine();
        }
    }
}
