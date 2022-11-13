

namespace Assignmnent373
{
     class LeapYear
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter a year:");
                int yr = int.Parse(Console.ReadLine());
                if(yr%4==0 && yr%100 !=0)
                {
                    Console.WriteLine("leap year");
                }
                else
                {
                    Console.WriteLine("not leap year");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           

        }
    }
}
