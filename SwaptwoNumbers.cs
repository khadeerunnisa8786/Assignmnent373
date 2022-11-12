using System;
using System.Runtime;

namespace Assignmnent373
{
    public class SwaptwoNumbers
    {
        public static void Main()
        {
            int a = 5, b = 3, c;
            Console.WriteLine("before swapping a=" + a + "b=" + b + "\n");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swappinga=" + a + "b=" + b);
            //Console.WriteLine("hello here");
        }
    }
}
