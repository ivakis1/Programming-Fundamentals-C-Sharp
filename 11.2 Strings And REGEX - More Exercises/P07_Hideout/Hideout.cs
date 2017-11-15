using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P07_Hideout
{
    class Hideout
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            while (true)
            {
                var input = Console.ReadLine().Split();

                var searchedChar = input[0];
                var count = int.Parse(input[1]);

                var pattern = $@"\{searchedChar}{{{count},}}";

                var match = Regex.Match(text, pattern);

                if (match.Success)
                {
                    Console.WriteLine(
                        $"Hideout found at index {text.IndexOf(match.Value)} and it is with size {match.Value.Length}!");
                    break;
                }
            }
        }
    }
}
