﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class CollectionInitializers
    {
        static void Main()
        {
            //Copying values > 40 from 1 list to another list and arranging them in descending order
            List<int> coll1 = new List<int>() { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };
            List<int> coll2 = new List<int>();

            foreach (int i in coll1)
            {
                if (i > 40)
                {
                    coll2.Add(i);
                }
            }
            coll2.Sort();
            coll2.Reverse();
            Console.WriteLine(String.Join(", ", coll2));
            Console.ReadLine();
        }
    }
}
