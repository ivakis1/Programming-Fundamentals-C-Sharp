using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_MorseCodeUpgraded
{
    class MorseCode
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            var result = new StringBuilder();
            var pattern = @"0{2,}|1{2,}";
            
            foreach (var item in input)
            {
                var zeros = 0;
                var ones = 0;
                var sum = 0;

                for (int i = 0; i < item.Length; i++)
                {
                    if (int.Parse(item[i].ToString()) == 0)
                    {
                        zeros++;
                    }
                    else
                    {
                        ones++;
                    }
                }
                var sequences = Regex.Matches(item, pattern);

                foreach (Match sequence in sequences)
                {
                    sum += sequence.ToString().Length;
                }
                sum += zeros * 3 + ones * 5;

                var letter = (char)(sum);

                result.Append(letter);
            }

            Console.WriteLine(result.ToString());           
        }
    }
}
