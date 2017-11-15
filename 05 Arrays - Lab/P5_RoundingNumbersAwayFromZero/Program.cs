namespace P5_RoundingNumbersAwayFromZero
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] split = input.Split(' ');

            var numbers = new double[split.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(split[i]);
            }

            var roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedNumbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            }
        }
    }
}
