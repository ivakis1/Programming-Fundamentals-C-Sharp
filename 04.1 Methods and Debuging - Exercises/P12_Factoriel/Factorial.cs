namespace P12_Factoriel
{
    using System;
    using System.Numerics;

    class Factorial
    {
        public static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = FactorialNumber(num);

            BigInteger zerosCount = NumberOfZeros(factorial);

            Console.WriteLine(zerosCount);


        }
        public static BigInteger FactorialNumber(BigInteger num)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }
        public static int NumberOfZeros(BigInteger num)
        {
            BigInteger factorial = num;
            int count = 0;

            while (num > 0)
            {
                BigInteger a = num % 10;
                if (a > 0)
                {
                    return count;
                }
                if (a == 0)
                {
                    count++;
                }
                num = num / 10;
                         
            }
            return count;

        }
    }
}
