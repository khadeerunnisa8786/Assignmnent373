

namespace Assignmnent373
{
    class EvenAndOdd
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number :");
            int j = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Even Numbers :");
            for (int i = 1; i <= j; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (int i = 1; i <= j; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+ " ");
                }
            }

            //Console.WriteLine("Enter a number to know whether it is odd number or even number:");
            //int 
            //int i = Convert.ToInt32(Console.ReadLine());
            //for (int j = 0; j <= i; j++)
            //{
            //    if (j % 2 == 0)
            //    {
            //        Console.Write(j +",");
            //    }
            //    else
            //    {
            //        Console.Write(j +"," );
            //    }
            //}


        }
        }
    }

    

