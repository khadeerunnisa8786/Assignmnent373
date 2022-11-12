using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnent373
{
    public class CharAlphabetOrNot
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter a alphabet");
                char ch = (char)Console.Read();

                if (char.IsLetter(ch))
                {
                    Console.WriteLine("aplhabet");
                }
                else
                {
                    Console.WriteLine("Not a alphabet");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            //try
            //{
            //    Console.WriteLine("Enter a character");
            //    char ch=(Char) Console.Read();
            //    string s = "";
            //    if(char.IsLetter(ch))
            //    {
            //        s=ch.ToString();
            //        Console.WriteLine(s.ToUpper());
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
