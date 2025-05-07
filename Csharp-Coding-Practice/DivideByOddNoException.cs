using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Coding_Practice
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by odd number.";
            }
        }
    }
}
