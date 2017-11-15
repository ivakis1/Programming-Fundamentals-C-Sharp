namespace P07_Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    class PrimesInRange
    {
        static void Main()
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int counter = 0;

            FindPrimesInRange(num1, num2, counter);
        }

        static void FindPrimesInRange(int num1, int num2, int counter)
        {
            List<int> numbers = new List<int>();
            if (num1 < 0 || num2 < 0)
            {
                num1 = 2;
            }
            if (num1 == 0 || num1 == 1)
            {
                num1 = 2;
            }
            if (num1 > num2)
            {
                Console.WriteLine("empty list");
            }
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                    if (counter > 2)
                    {
                        break;
                    }
                }
                if (counter <= 2)
                {
                    numbers.Add(i);
                }
                counter = 0;
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
        }

    }
}
