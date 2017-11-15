namespace P07_MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var start = 0;
            var len = 1;
            var bestStart = 0;
            var bestLen = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }          
            }
            var count = 0;

            for (int i = bestStart; i < input.Length; i++)
            {
                if (count >= bestLen)
                {
                    Console.WriteLine();
                    return;
                }
                Console.Write(input[i] + " ");
                count++;
            }

        }
    }
}
