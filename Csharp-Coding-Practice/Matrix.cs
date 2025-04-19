using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal class Matrix
    {
        //Declaring attributes for a 2 * 2 Matrix
        int a, b, c, d;
        //Initializing attributes of the Matrix in constructor
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }
        //Overriding the ToString() method inherited from Object class to return values of the Matrix in 2 * 2 format
        public override string ToString()
        {
            return a + "  " + b + "\n" + c + "  " + d + "\n";
        }
        //Implementing the + operator so that it can be used between 2 Matrix operands
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        //Implementing the - operator so that it can be used between 2 Matrix operands
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
        //Re-Implementing the == operator using Hiding/Shadowing so that it can be used between 2 Matrix’s to perform values == comparison because original implementation is reference equal comparison
        public static bool operator ==(Matrix obj1, Matrix obj2)
        {
            if (obj1.a == obj2.a && obj1.b == obj2.b && obj1.c == obj2.c && obj1.d == obj2.d)
                return true;
            else
                return false;
        }
        //Re-Implementing the != operator using Hiding/Shadowing so that it can be used between 2 Matrix’s to perform values != comparison because original implementation is reference not equal comparison
        public static bool operator !=(Matrix obj2, Matrix obj1)
        {
            if (obj1.a != obj2.a || obj1.b != obj2.b || obj1.c != obj2.c || obj1.d != obj2.d)
                return true;
            else
                return false;
        }
    }
}
