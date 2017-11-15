using System;
using System.Collections.Generic;
using System.Numerics;

namespace P01_ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var baseNumber = BigInteger.Parse(input[0]);
            var numbreTodivide = BigInteger.Parse(input[1]);

            var rem = new List<BigInteger>();

            while (numbreTodivide > 0)
            {
                rem.Add(numbreTodivide % baseNumber);

                numbreTodivide = numbreTodivide / baseNumber;
            }

            rem.Reverse();

            Console.WriteLine(string.Join("", rem));
        }

    }
}
