namespace P04_4.NumbersInReversedOrder
{
    using System;

    public class NumbersInReverseOrder
    {
        static void Main()
        {
            string number = (Console.ReadLine());

            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
    }
}
