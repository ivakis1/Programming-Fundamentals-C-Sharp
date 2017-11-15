using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P01_ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var regex = @"(?<user>(^| )[a-z]+[\-_\.]*[0-9]*[a-z]*)@(?<host>[a-z]+[\.\-]+)(?<domein>[\.\-]*[a-z]+)+";

            var text = Console.ReadLine();

            var matchedMeils = Regex.Matches(text, regex).Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join("\r\n", matchedMeils));
        }
    }
}
