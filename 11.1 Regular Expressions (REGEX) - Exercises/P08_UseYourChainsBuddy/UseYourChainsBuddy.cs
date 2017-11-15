using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P08_UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            var paragpraphRegex = new Regex(@"<p>(?<message>.+?)<\/p>");

            var text = Console.ReadLine();

            var paragpraphs = paragpraphRegex.Matches(text)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z\d]+", " "))
                .Select(a => Regex.Replace(a, @"\s+", " "))
                .ToArray();

            for (int i = 0; i < paragpraphs.Length; i++)
            {
                paragpraphs[i] = Rot13String(paragpraphs[i]);
            }

            var result = new StringBuilder();

            foreach (var p in paragpraphs)
            {
                result.Append(p);
            }

            Console.WriteLine(result.ToString());
        }

        private static string Rot13String(string input)
        {
            var result = new StringBuilder();

            foreach (var letter in input)
            {
                result.Append(Rot13(letter));
            }

            return result.ToString();
        }

        private static char Rot13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }
            var offset = char.IsUpper(letter) ? 'A' : 'a';

            var rotatedLetter = (char) ((letter - offset + 13) % 26 + offset);

            return rotatedLetter;
        }
    }
}
