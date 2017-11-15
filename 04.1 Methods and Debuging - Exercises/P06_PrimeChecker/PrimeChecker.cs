namespace P06_PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            bool primeOrNot = IsPrime(number);

            Console.WriteLine(primeOrNot);

        }

        public static bool IsPrime(long number)
        {
            var IsPrime = true;

            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;

                }
            }
            return IsPrime;
        }
    }
}
