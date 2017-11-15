namespace p12MasterNumbers
{
    using System;

    class MasterNumbers
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                bool palindrome = IsPalindrome(i);
                bool divadableBySeven = SumOfDigitsIsDevidableBySeven(i);
                bool evenDigit = ContainEvenDigit(i);

                if (palindrome && divadableBySeven && evenDigit)
                {
                    Console.WriteLine(i);
                }

            }
        }
        public static bool IsPalindrome(int num)
        {
      
            int t = num;
            int a, s = 0;
            while (num > 0)
            {
                a = num % 10;
                s = s * 10 + a;
                num = num / 10;
            }
            if (t == s)
            {
                return true;
            }
            return false;

        }
        public static bool SumOfDigitsIsDevidableBySeven(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;

        }
        public static bool ContainEvenDigit(int num)
        {
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                num = num / 10;
            }
            return false;

        }
    }
}
