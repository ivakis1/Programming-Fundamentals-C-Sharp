using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {       
            File.WriteAllText("input.txt", "-I was quick to judge him, but it wasn't his fault.\n\r-Is this some kind of joke?! Is it?\n\r-Quick, hide here…It is safer.");

            File.WriteAllText("words.txt", "quick is fault");

            var words = File.ReadAllText("words.txt").ToLower().Split(' ');
           
            var text = File.ReadAllText("input.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);
       
            var wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            File.Delete("result.txt");

            foreach (var item in wordsCount.OrderByDescending(a => a.Value))
            {
                var result = $"{item.Key} - {item.Value} \r";  

                File.AppendAllText("result.txt", result);
            }

        }
    }
}
