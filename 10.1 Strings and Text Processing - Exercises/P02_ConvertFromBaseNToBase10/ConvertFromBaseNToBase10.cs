using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P02_ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var baseNumber = int.Parse(input[0]);
            var numberToConvert = input[1];
            var reverse = numberToConvert.ToCharArray().Reverse().ToArray();
 
            BigInteger sum = 0;

            for (int i = 0; i < reverse.Length; i++)
            {
                sum += int.Parse(reverse[i].ToString()) * BigInteger.Pow(baseNumber, i);
            }
            Console.WriteLine(sum);
        }
    }
}
