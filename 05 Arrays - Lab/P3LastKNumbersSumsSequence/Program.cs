namespace P3LastKNumbersSumsSequence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var seq = new long[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += seq[prev];
                    }
                    seq[i] = sum;
                }
            }

            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write(seq[i] + " ");
                Console.WriteLine();
            }

        }
    }
}
