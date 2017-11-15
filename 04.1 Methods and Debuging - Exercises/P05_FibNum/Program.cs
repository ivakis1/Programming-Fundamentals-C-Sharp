namespace P05_FibNum
{
    using System;

    public class Program
    {
       public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int fibNumber = GetFib(number);

            Console.WriteLine(fibNumber);
        }

        public static int GetFib(int number)
        {
            int fib1 = 1;
            int fib0 = 1;
            int currentNum = 1;

            for (int i = 2; i <= number; i++)
            {
                currentNum = fib1 + fib0;

                fib0 = fib1;
                fib1 = currentNum;
            }

            return fib1;
        }
    }
}
