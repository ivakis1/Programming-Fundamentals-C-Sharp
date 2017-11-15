
namespace p3_Printing_Triangle
{
    using System;
    class PrintTriangle
    {
       public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrintFigure(number);


        }

        public static void PrintColums(int row)
        {
            for (int cols = 1; cols <= row; cols++)
            {
                Console.Write($"{cols} ");
            }
            Console.WriteLine();
        }

        public static void PrintFigure(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintColums(row);
            }
            for (int row = n - 1; row >= 1; row--)
            {
                PrintColums(row);
            }
        }


    }
}
