using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P01_MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine();

            var regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (var m in matchedNames)
            {
                Console.Write(m + " ");
            }

        }
    }
}
