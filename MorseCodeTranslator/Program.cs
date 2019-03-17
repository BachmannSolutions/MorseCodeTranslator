using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        public static void Main()
        {

            while (true)
            {
                Console.Write("Enter what you would like to have translated to morse code here: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string output = MorseCodeTranslator.ToMorse(input);

                Console.WriteLine(output);
            }
        }
    }
}
