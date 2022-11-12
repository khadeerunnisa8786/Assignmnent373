using System;

namespace Assignmnent373
{
    public class AreaofSquare
    {
        public static void Main()
        {
            int area;
            Console.WriteLine("Enter the s value:");
            int s =Convert.ToInt32(Console.ReadLine());
            area = s * s;
            Console.WriteLine("Area of a square is:" + area);
        }
    }
}
