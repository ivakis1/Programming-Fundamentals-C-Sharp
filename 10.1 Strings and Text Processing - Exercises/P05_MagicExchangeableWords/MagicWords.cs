using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_MagicExchangeableWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var letters = new List<string>();

            var firstWord = input[0].ToCharArray().ToList();
            var secondWord = input[1].ToCharArray().ToList();

            var letter = "";
            if (firstWord.Count > secondWord.Count)
            {
                Console.WriteLine("false");
                return;
            }

            if (firstWord.Count <= secondWord.Count)
            {
                while (firstWord.Count > 0)
                {
                    if (secondWord.Count > 0)
                    {
                        letter = secondWord[0].ToString();
                        var currentLetter = firstWord[0];

                        secondWord.RemoveAll(a => a.ToString() == letter);
                        firstWord.RemoveAll(a => a == currentLetter);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
    
            if (secondWord.Count > 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

        }
    }
}
