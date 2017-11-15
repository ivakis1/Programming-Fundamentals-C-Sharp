namespace P04_GrabAndGo
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class GrabAndGo
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());

            var occurance = 0;
            long position = -1;
         

             for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == number)
                {
                    occurance++;
                    position = i;
                }
                if (occurance >= 2)
                {
                    position = i;
                    
                }
                
            }
            if (input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            if (position >= 0)
            {
                long sum = 0;
                for (int i = 0; i < position; i++)
                {
                    sum += input[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
