﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class ThreadSynchronization
    {
        public static void Print()
        {
            lock (typeof(ThreadSynchronization))
            {
                Console.Write("[CSharp Is ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented]");
            }
        }
        static void Main()
        {
            Thread t1 = new Thread(Print);
            Thread t2 = new Thread(Print);
            Thread t3 = new Thread(Print);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();
        }
    }
}
