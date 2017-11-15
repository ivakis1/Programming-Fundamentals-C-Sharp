using System;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;

                while ( i > 0)
                {
                    int lastDig = i % 10;
                    sum += lastDig;
                    num = i / 10;
                }
                if (sum % 7 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
