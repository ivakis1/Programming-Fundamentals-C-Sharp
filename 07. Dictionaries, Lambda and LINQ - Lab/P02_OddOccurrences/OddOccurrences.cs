using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_OddOccurrences
{
   public class OddOccurrences
    {
       public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToArray();

            var words = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words[item] = 1;
                }
            }

            var sortedWords = new List<string>();

            foreach (var item in words)
            {
                if (item.Value % 2 != 0)
                {
                    sortedWords.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", sortedWords));
        }
    }
}
