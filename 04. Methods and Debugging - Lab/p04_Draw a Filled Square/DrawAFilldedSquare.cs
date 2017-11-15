using System;

namespace p04_Draw_a_Filled_Square
{
    class DrawAFilldedSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderAndFooter(n);

            PrintBody(n);

            PrintHeaderAndFooter(n);

        }

        public static void PrintHeaderAndFooter(int n)
        {
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

    }


}
