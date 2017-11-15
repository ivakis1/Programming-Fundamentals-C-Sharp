namespace P9_Extract_Middle_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
            }
            else if (input.Length % 2 != 0)
            {
                Console.WriteLine(OddCount(input));
            }
            else if (input.Length % 2 == 0)
            {
                Console.WriteLine(EvenCount(input));
            }


        }
        public static string OddCount(string[] input)
        {
            var firstMiddleElement = input[input.Length / 2 - 1];

            var secondMiddleElement = input[input.Length / 2];

            var thirthMiddleElement = input[input.Length / 2 + 1];

            return firstMiddleElement + " " + secondMiddleElement + " " + thirthMiddleElement;
        }
        public static string EvenCount(string[] input)
        {
            var firstMiddleElement = input[input.Length / 2 - 1];
            var secondMiddleElemnt = input[input.Length / 2];

            return firstMiddleElement + " " + secondMiddleElemnt;
        }
    }
}
