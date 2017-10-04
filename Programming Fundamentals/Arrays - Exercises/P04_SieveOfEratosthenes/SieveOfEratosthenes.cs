namespace P04_SieveOfEratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var primes = new bool[number + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 0; i <= number; i++)
            {
                if (!primes[i])
                {
                    continue;
                }
                Console.Write(i + " ");

                for (int j = 2 * i; j <= number; j += i)
                {
                    primes[j] = false;

                }

            }

            Console.WriteLine();
        }
    }
}
