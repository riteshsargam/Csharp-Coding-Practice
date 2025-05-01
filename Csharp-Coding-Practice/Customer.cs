using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class Customer
    {
        int _Custid;
        bool _Status;
        string _Name, _State;
        double _Balance;
        Cities _City;
        public Customer(int Custid)
        {
            _Custid = Custid;
            _Status = false;
            _Name = "John";
            _Balance = 5000.00;
            _City = 0;
            _State = "Karnataka";
            Country = "India";
        }
        //Read Only Property
        public int Custid
        {
            get { return _Custid; }
        }
        //Read-Write Property
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        //Read-Write Property (With a condition in Set Accessor)
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Status)
                {
                    _Name = value;
                }
            }
        }
        //Read-Write Property (With a condition in Get & Set Accessor)
        public double Balance
        {
            get
            {
                if (_Status)
                {
                    return _Balance;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (_Status)
                {
                    if (value >= 500)
                    {
                        _Balance = value;
                    }
                }
            }
        }
        //Read-Write Property (Enumerated Property)
        public Cities City
        {
            get { return _City; }
            set
            {
                if (_Status)
                {
                    _City = value;
                }
            }
        }
        //Read-Write Property (With a different scope to each property accessor (C# 2.0))
        public string State
        {
            get { return _State; }
            protected set
            {
                if (_Status)
                {
                    _State = value;
                }
            }
        }
        //Read-Write Property (Automatic or Auto-Implemented property (C# 3.0))
        public string Country
        {
            get;
            private set;
        }
        //Read-Write Property (Auto property initializer (C# 6.0))
        public string Continent { get; } = "Asia";
    }
}
