using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    internal static class ExtensionMethods
    {
        public static void Show(this MyStruct obj)
        {
            Console.WriteLine("Added this method to MyStruct structure.");
        }
        public static ulong Factorial(this UInt32 x)
        {
            if (x == 0 || x == 1)
                return 1;
            else if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }
        public static string ToPascal(this String OldStr)
        {
            if (OldStr.Trim().Length > 0)
            {
                OldStr = OldStr.ToLower();
                string[] sarr = OldStr.Split(' ');
                String NewStr = null;
                foreach (string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if (NewStr == null)
                    {
                        NewStr = new String(carr);
                    }
                    else
                    {
                        NewStr += " " + new String(carr);
                    }
                }
                return NewStr;
            }
            return OldStr;
        }
    }
}
