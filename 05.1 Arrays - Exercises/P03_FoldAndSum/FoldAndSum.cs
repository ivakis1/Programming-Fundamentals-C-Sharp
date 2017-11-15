namespace P03_FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var kNumbers = input.Length / 4;

            var leftKNumbers = new int[kNumbers];
            var rightKNumbers = new int[kNumbers];// already reversed

            for (int i = 0; i < kNumbers; i++)
            {
                leftKNumbers[i] = input[i];
                rightKNumbers[i] = input[input.Length - 1 - i];
            }

            var leftKnumbersReversed = new int[kNumbers]; // Array.Reverse(leftKNumbers)

            for (int i = 0; i < kNumbers; i++)
            {
                leftKnumbersReversed[i] = leftKNumbers[leftKNumbers.Length - i - 1];
            }
          
            
            var kNumbersArray = new int[kNumbers * 2];

            for (int i = 0; i < kNumbers; i++)
            {
                kNumbersArray[i] = leftKnumbersReversed[i];
                kNumbersArray[kNumbers + i] = rightKNumbers[i];
            }

            var middleNumbers = new int[kNumbers * 2];

            for (int i = kNumbers; i < input.Length - kNumbers; i++)
            {
                middleNumbers[i - kNumbers] = input[0 + i];
            }

            var sumOFArrays = new int[kNumbers * 2];

            for (int i = 0; i < kNumbers * 2; i++)
            {
                sumOFArrays[i] = kNumbersArray[i] + middleNumbers[i]; 
            }
            Console.WriteLine(string.Join(" ", sumOFArrays));
        }
    }
}
