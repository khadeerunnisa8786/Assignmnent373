using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnent373
{
    class LargestAmongFourNumbers
    {
        public static void Main()
        {
            //int n1 = 34, n2 = 12, n3 = 65, n4 = 56;
            //int x1, x2, res;
            //x1 = (n1 > n2 ? n1 : n2);
            //x2 = (n3 > n4 ? n3 : n4);
            //res=(x1>x2 ? x1: x2);
            //Console.WriteLine(res);
            Console.WriteLine("enter n1:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n2:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n3:");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n4:");
            int n4 = int.Parse(Console.ReadLine());
            int x1, x2, res;

            x1 = (n1 > n2 ? n1 : n2);
            x2 = (n3 > n4 ? n3 : n4);
            res = (x1 > x2 ? x1 : x2);
            Console.WriteLine("Largest Among four numbers:" + res);
        }
    }
}
