using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" \t".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            var sum = 0.0;

            foreach (var item in input)
            {
                var firstLetter = item.First();
                var lastLetter = item.Last();

                var number = double.Parse(item.Substring(1, item.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - ('A' - 1);
                }
                else
                {
                    number *= firstLetter - ('a' - 1);
                }
                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - ('A' - 1);
                }
                else
                {
                    number += lastLetter - ('a' - 1);
                }

                sum += number;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
