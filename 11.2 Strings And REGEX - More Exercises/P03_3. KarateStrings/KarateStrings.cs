using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_3.KarateStrings
{
    class KarateStrings
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sum += int.Parse(input[i + 1].ToString());
                    i++;

                    while (i < input.Length &&sum > 0)
                    {
                        if (input[i] == '>')
                        {
                            break;
                        }                  
                        input.Remove(i, 1);
                        sum--;                  
                    }
                    i--;                   
                }
            }
                Console.WriteLine(input);
        }
    }
}
