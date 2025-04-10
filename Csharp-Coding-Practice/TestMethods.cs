using System;

namespace Csharp_Coding_Practice
{
    public class Method
    {
        private readonly int x = 200; // Marked as readonly
        private static int y = 100;

        public void Add()
        {
            Console.WriteLine(x + y);
        }

        public static void Sub()
        {
            Method m = new Method();
            Console.WriteLine(m.x - y);
        }
    }

    public class TestMethods
    {
        static void Main()
        {
            Method obj = new Method();
            obj.Add();  // Add is non-static, so calling it with an instance
            Method.Sub(); // Sub is static, so calling it with the class name
            Console.ReadLine();
        }
    }
}
