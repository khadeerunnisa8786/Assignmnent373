namespace Assignmnent373
{
     class PositiveAndNegativeNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number");
            int i=Convert.ToInt32(Console.ReadLine());

            try
            {
                if (i >= 0)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           
        }
    }
}
