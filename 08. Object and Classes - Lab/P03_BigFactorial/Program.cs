using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P03_BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = 1;

            for (int i = 2; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);

        }
    }
}
