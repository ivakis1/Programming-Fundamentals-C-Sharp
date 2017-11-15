
namespace p15_Fast_Prime_Checker___Refactor
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numberRange; i++)
            {
                bool number = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        number = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {number}");

        }

    }
}
}
