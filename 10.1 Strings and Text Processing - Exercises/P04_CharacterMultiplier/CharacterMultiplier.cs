using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var sum = 0;

            var length = Math.Min(input[0].Length, input[1].Length);
            var max = Math.Max(input[0].Length, input[1].Length);

            var substring = "";
            var secondSum = 0;

            if (input[0].Length != input[1].Length)
            {

                if (max == input[0].Length)
                {                   
                    substring = input[0].Substring(input[1].Length);
                }
                else
                {                    
                    substring = input[1].Substring(input[0].Length);
                }

                for (int i = 0; i < substring.Length; i++)
                {         
                    secondSum += substring[i];
                }
            }
            for (int i = 0; i < length; i++)
            { 
                sum += input[0].ElementAtOrDefault(i) * input[1].ElementAtOrDefault(i);
            }

            Console.WriteLine(sum + secondSum);
        }
    }
}
