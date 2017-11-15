using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNames = Console.ReadLine();

            string pattern = "\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";

            MatchCollection matches = Regex.Matches(inputNames, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
