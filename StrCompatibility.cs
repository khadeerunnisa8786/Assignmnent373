namespace Assignmnent373
{
    public class StrCompatibility
    {
        public static  void Main()
        {
            
            try
            {
                Console.WriteLine("Enter a string:");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" compatible");
            }
            catch (Exception e)
            {
                Console.WriteLine("not compatible");

            }
        }
    }
}
