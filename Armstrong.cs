using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnent373
{
     class Armstrong
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse( Console.ReadLine());
            int sum = 0, r=0, temp=n;
            for (int i = 0; i <= temp.ToString().Length; i++)
            {
                r = n % 10;
                n= n / 10;
                sum = sum + (r * r * r);


            }
            if (temp==sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }
        }
    }
}
