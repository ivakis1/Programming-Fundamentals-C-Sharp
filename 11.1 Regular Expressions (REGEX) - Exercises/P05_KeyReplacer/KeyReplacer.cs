using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P05_KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            var keys = Console.ReadLine();
                      
            var startKey = @"^[A-Za-z]+[<\|\\]";
            var endKey = @"[<\|\\][A-Za-z]+$";

            var firstKey = Regex.Match(keys, startKey);
            var secondKey = Regex.Match(keys, endKey);

            string firstK = firstKey.Value.Trim('<','\\','|');
            string secondK = secondKey.Value.Trim('<','\\','|');

            var text = Console.ReadLine();

            var pattern = $@"{firstK}(.+?){secondK}";

            StringBuilder result = new StringBuilder();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                result.Append(item.Groups[1].Value);
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
