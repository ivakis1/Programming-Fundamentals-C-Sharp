namespace P12_EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                var rightSum = 0;
                var leftSum = 0;

                for (int k = 0; k < i; k++)
                {
                    leftSum += input[k];
                }
                for (int j = i + 1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
