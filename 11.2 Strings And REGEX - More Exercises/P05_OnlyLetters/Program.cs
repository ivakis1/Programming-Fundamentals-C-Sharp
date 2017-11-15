using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P05_OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(\d+)[A-Za-z]";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                var number = match.Groups[1].Value.ToCharArray();

                var charToReplace = input.IndexOf(number[number.Length - 1]); 

                input = input.Replace(number[number.Length - 1], input[charToReplace + 1]);

                // zamesti poslednoto chislo s znaka koito se namira na poziciq poslednoto chislo + 1
            }          

            var digit = @"(\d)[A-Za-z]";   

            MatchCollection matchNumber = Regex.Matches(input, digit);

            foreach (Match item in matchNumber)
            {
                var digitNum = item.Groups[1].Value;

                input = input.Replace(digitNum, "");
            }


            Console.WriteLine(input);
        }
    }
}
