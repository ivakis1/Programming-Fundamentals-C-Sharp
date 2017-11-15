using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().Split(
                new char[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            foreach (var item in inputText)
            {
                var reversedItem = new string(item.Reverse().ToArray());

                if (item == reversedItem)
                {
                    palindromes.Add(item);
                }
            }

            var distinctedPalindromes = palindromes.Distinct().ToList();

            Console.WriteLine(string.Join(", ", distinctedPalindromes.OrderBy(a => a)));
        }
    }
}
