using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class Student
    {
        int? _Id, _Class;
        string? _Name;
        float? _Marks, _Fees;
        public int? Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int? Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        public string? Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public float? Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }
        public float? Fees
        {
            get { return _Fees; }
            set { _Fees = value; }
        }
        public override string ToString()
        {
            return "Id: " + _Id + "\nName: " + _Name + "\nClass: " + _Class + "\nMarks: " + _Marks + "\nFees: " + _Fees;
        }
    }


    internal class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student { Id = 101, Name = "Raju", Class = 10, Marks = 575.00f, Fees = 5000.00f };
            Student s2 = new Student { Id = 102, Name = "Vijay", Class = 10 };
            Student s3 = new Student { Id = 103, Marks = 560.00f, Fees = 5000.00f };
            Student s4 = new Student { Id = 104, Class = 10, Fees = 5000.00f };
            Student s5 = new Student { Id = 105, Name = "Raju", Marks = 575.00f };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);

            Console.ReadLine();
        }
    }
}
