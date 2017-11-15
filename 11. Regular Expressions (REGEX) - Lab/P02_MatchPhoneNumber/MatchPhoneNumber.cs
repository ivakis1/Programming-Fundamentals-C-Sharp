using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02_MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var regex = @"(?: |^)\+359( |-)2\1\d{3}\1\d{4}\b";

            var phoneNumbers = Console.ReadLine();

            var phoneNumMatches = Regex.Matches(phoneNumbers, regex);

            var matchedPhones = phoneNumMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
