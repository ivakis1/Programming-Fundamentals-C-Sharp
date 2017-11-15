using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_CountSubstringOccurences
{
    class CountSubstringOccurences
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().ToLower();

            var word = Console.ReadLine().ToLower();

            var index = inputText.IndexOf(word);

            var count = 0;

            while (index != -1)
            {
                count++;
                index = inputText.IndexOf(word, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
