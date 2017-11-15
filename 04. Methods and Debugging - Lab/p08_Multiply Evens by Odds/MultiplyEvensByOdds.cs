
namespace p08_Multiply_Evens_by_Odds
{
    using System;
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumEven = GetSumOfEvenDigits(n);
            int sumOdd = GetSumOfOddDigits(n);

            int result = sumEven * sumOdd;

            Console.WriteLine(result);

        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
               n = n / 10;
            }

            return sum;
            
        }

        static int GetSumOfOddDigits (int n)
        {
            int sum = 0;
            n = Math.Abs(n);

            while(n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 !=0)
                {
                    sum += lastDigit;
                }

                n = n / 10;
            }

            return sum;
        }
    }
}
