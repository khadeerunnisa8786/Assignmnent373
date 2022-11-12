using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnent373
{
     class SwappingWithoutThird
    {
        public static void Main()
        {
            Console.WriteLine("enter a value:"+"\n");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value:" + "\n");
            int b= Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
