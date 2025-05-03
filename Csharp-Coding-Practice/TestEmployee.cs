using System;

namespace Csharp_Coding_Practice
{
    public class Employee
    {
        int _Id;
        string? _Name, _Job;
        double _Salary;
        bool _Status;

        public Employee(int Id)
        {
            _Id = Id;
            _Name = "Scott";
            _Job = "Manager";
            _Salary = 50000.00;
            _Status = true;
        }

        public object? this[int index]
        {
            get
            {
                if (index == 1)
                    return _Id;
                else if (index == 2)
                    return _Name;
                else if (index == 3)
                    return _Job;
                else if (index == 4)
                    return _Salary;
                else if (index == 5)
                    return _Status;
                else
                    return null;
            }
            set
            {
                if (index == 2)
                    _Name = (string?)value;
                else if (index == 3)
                    _Job = (string?)value;
                else if (index == 4)
                    _Salary = (value is double d) ? d : _Salary;
                else if (index == 5)
                    _Status = (value is bool b) ? b : _Status;
            }
        }

        public object? this[string name]
        {
            get
            {
                if (name.Equals("id", StringComparison.OrdinalIgnoreCase))
                    return _Id;
                else if (name.Equals("name", StringComparison.OrdinalIgnoreCase))
                    return _Name;
                else if (name.Equals("job", StringComparison.OrdinalIgnoreCase))
                    return _Job;
                else if (name.Equals("salary", StringComparison.OrdinalIgnoreCase))
                    return _Salary;
                else if (name.Equals("status", StringComparison.OrdinalIgnoreCase))
                    return _Status;
                else
                    return null;
            }
            set
            {
                if (name.Equals("name", StringComparison.OrdinalIgnoreCase))
                    _Name = (string?)value;
                else if (name.Equals("job", StringComparison.OrdinalIgnoreCase))
                    _Job = (string?)value;
                else if (name.Equals("salary", StringComparison.OrdinalIgnoreCase))
                    _Salary = (value is double d) ? d : _Salary;
                else if (name.Equals("status", StringComparison.OrdinalIgnoreCase))
                    _Status = (value is bool b) ? b : _Status;
            }
        }
    }

    internal class TestEmployee
    {
        static void Main()
        {
            Employee Emp = new Employee(1005);

            Console.WriteLine("Employee ID: " + Emp[1]);
            Console.WriteLine("Employee Name: " + Emp[2]);
            Console.WriteLine("Employee Job: " + Emp[3]);
            Console.WriteLine("Employee Salary: " + Emp[4]);
            Console.WriteLine("Employee Status: " + Emp[5]);
            Console.WriteLine();

            // ID is not settable – still safe
            Emp[3] = "Sr. Manager";
            Emp["Salary"] = 75000.00;
            Emp["Status"] = false;

            Console.WriteLine("Employee ID: " + Emp["Id"]);
            Console.WriteLine("Employee Name: " + Emp["name"]);
            Console.WriteLine("Employee Job: " + Emp["JOB"]);
            Console.WriteLine("Employee Salary: " + Emp["SaLaRy"]);
            Console.WriteLine("Employee Status: " + Emp["Status"]);
            Console.ReadLine();
        }
    }
}
