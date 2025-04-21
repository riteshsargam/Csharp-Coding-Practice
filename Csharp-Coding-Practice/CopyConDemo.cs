using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class CopyConDemo
    {
        int Id;
        string Name;
        double Balance;
        public CopyConDemo(int Id)
        {
            this.Id = Id;
            Name = "Vijay";
            Balance = 5000.00;
        }
        public CopyConDemo(CopyConDemo cd)
        {
            this.Id = cd.Id;
            this.Name = cd.Name;
            this.Balance = cd.Balance;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {Id}; Name: {Name}; Balance: {Balance}");
        }
        static void Main()
        {
            CopyConDemo cd1 = new CopyConDemo(1005);
            cd1.Display();
            CopyConDemo cd2 = new CopyConDemo(cd1);
            cd2.Display();
            Console.WriteLine();
            cd1.Balance = 10000;
            cd1.Display();
            cd2.Display();
            Console.WriteLine();
            cd1.Balance = 20000;
            cd1.Display();
            cd2.Display();
            Console.ReadLine();
        }
    }
}
