namespace P11_PairsByDifference
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var differecnce = int.Parse(Console.ReadLine());

            var pairs = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                var currentNumber = inputNumbers[i];

                for (int j = 0; j < inputNumbers.Length; j++)
                {
                    if (currentNumber - inputNumbers[j] == differecnce)
                    {
                        pairs++;
                    }
                }

            }
            Console.WriteLine(pairs);
        }
    }
}
