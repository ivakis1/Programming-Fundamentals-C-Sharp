using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02_MatchHexadecimalNumbers
{
    class MatchHexaDecimalNums
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?([0-9A-F]+\b)";

            var numberInString = Console.ReadLine();

            var number = Regex.Matches(numberInString, regex).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", number));
        }
    }
}
