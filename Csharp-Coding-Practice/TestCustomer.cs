using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class TestCustomer
    {
        static void Main()
        {
            Customer obj = new Customer(1001);
            Console.WriteLine("Custid: " + obj.Custid + "\n");
            //obj.Custid = 1005;  //Invalid, because the property is defined read only

            if (obj.Status)
                Console.WriteLine("Customer Status: Active");
            else
                Console.WriteLine("Customer Status: In-Active");
            Console.WriteLine("Customer Name: " + obj.Name);
            obj.Name += " Smith"; //Update fails because status is in-active
            Console.WriteLine("Name when update failed: " + obj.Name);
            Console.WriteLine("Balance when status is in-active: " + obj.Balance + "\n");

            obj.Status = true; //Activating the status
            if (obj.Status)
                Console.WriteLine("Customer Status: Active");
            else
                Console.WriteLine("Customer Status: In-Active");
            Console.WriteLine("Customer Name: " + obj.Name);
            obj.Name += " Smith"; //Update succeds because status is in-active
            Console.WriteLine("Name when update succeded: " + obj.Name);
            Console.WriteLine("Balance when status is active: " + obj.Balance + "\n");

            obj.Balance -= 4600; //Transaction failed
            Console.WriteLine("Balance when transaction failed: " + obj.Balance);
            obj.Balance -= 4500; //Transaction succeds
            Console.WriteLine("Balance when transaction succeded: " + obj.Balance + "\n");

            Console.WriteLine("Current City: " + obj.City);
            obj.City = Cities.Hyderabad;
            Console.WriteLine("Modified City: " + obj.City);

            Console.WriteLine("Customer State: " + obj.State);
            //obj.State = "Telangana"; //Invalid because set accessor is accessible only to child classes

            Console.WriteLine("Customer Country: " + obj.Country);
            Console.WriteLine("Customer Continent: " + obj.Continent);
            Console.ReadLine();
        }
    }
}
