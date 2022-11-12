using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnent373
{
    public class VowelOrConsonant
    {
        public static void Main()
        {
			try
			{
                Console.WriteLine("Enter a char to know whether it is vowel or consonant");
                char ch = (char)Console.Read();
				switch (ch)
				{
					case 'a' or 'A':
						
							Console.WriteLine("a is a vowel");
						break;
                    case 'e' or 'E':

                        Console.WriteLine("e is a vowel");
                        break;
                    case 'i' or 'I':

                        Console.WriteLine("i is a vowel");
                        break;
                    case 'o' or 'O':

                        Console.WriteLine("o is a vowel");
                        break;
                    case 'u' or 'U':

                        Console.WriteLine("u is a vowel");
                        break;


                    default:
                        Console.WriteLine("consonant");
						break;
				}

			}
			catch (Exception e)
			{

                Console.WriteLine(e.Message);
			}
        }
    }
}
