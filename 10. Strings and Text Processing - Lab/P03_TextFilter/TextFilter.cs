using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var bannedword in bannedWords)
            {
                if (text.Contains(bannedword))
                {
                    text = text.Replace(bannedword, new string('*', bannedword.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
