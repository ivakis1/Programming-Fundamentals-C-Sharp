namespace P01_MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToList();

            var start = 0;
            var length = 1;
            var bestStart = 0;
            var bestLength = 0;
            var lastNum = input[0];

            for (int i = 1; i < input.Count; i++)
            {
               var currNum = input[i];   
                       
                if (currNum == lastNum)
                {
                    length++; ;
                    start = i - length;
                                 
                }
                else
                {
                    length = 1;
                    start = i;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = i - length;

                }
                lastNum = input[i];

            }
            if (length == 1)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                var longestSequens = new List<long>();

                longestSequens = input.Skip(bestStart + 1).Take(bestLength).ToList();

                Console.WriteLine(string.Join(" ", longestSequens));
            }        
        }
    }
}
