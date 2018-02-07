using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            string vowels = "AEIOUaeiou", consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            int vowelCount = 0, characterCount = 0, consonantCount = 0;

            Console.Clear();
            Console.WriteLine("Enter text to get the sums of all vowels and consonants within it.");

            string input = Console.ReadLine();

            if (input.Length > 0)
            {
                do
                {
                    if (vowels.Contains(input[characterCount])) {
                        vowelCount++;
                    }

                    else if (consonants.Contains(input[characterCount])) {
                        consonantCount++;
                    }


                    characterCount++;
                } while (characterCount < input.Length);
            }

            Console.WriteLine("Your text contains " + vowelCount + " vowels and " + consonantCount + " consonants.");
            Console.WriteLine("Press any key to start over");
            Console.ReadKey();
            
            goto Start;
        }
    }
}
