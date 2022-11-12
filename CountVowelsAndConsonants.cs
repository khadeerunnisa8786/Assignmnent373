

namespace Assignmnent373
{
    class CountVowelsAndConsonants
    {
        public static void Main()
        {
            try
            {
                string str = "";
                int i, length, vowl = 0, cons = 0;
                Console.WriteLine("Enter a string:");
                str = Console.ReadLine();
                length = str.Length;
                for (i = 0; i < length; i++)
                {
                    if (!string.IsNullOrEmpty(str[i].ToString()) && !string.IsNullOrWhiteSpace(str[i].ToString()))
                    {
                        if
                            (str[i] == 'a' || str[i] == 'A' ||
                             str[i] == 'e' || str[i] == 'E' ||
                             str[i] == 'i' || str[i] == 'I' ||
                             str[i] == 'o' || str[i] == 'O' ||
                             str[i] == 'u' || str[i] == 'U')
                        {
                            vowl++;
                        }
                        else
                        //if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                        {
                            cons++;
                        }
                    }
                }
                Console.WriteLine("number of vowel:" + vowl);
                Console.WriteLine("number of consonants:" + cons);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
             
        
    

