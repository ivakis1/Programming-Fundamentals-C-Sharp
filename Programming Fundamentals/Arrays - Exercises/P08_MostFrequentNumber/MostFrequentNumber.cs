namespace P08_MostFrequentNumber
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

            var lastMFN = 0;
            var lastMFNOccurs = 0;

            var currentMostFrequentNumber = 0;
            var currentMFNOccurs = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentNumber = input[i];
                currentMFNOccurs = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == currentNumber)
                    {
                       currentMostFrequentNumber = currentNumber;
                       currentMFNOccurs++;

                        if (currentMFNOccurs > lastMFNOccurs)
                        {
                            lastMFN = currentMostFrequentNumber;
                            lastMFNOccurs = currentMFNOccurs;
                        }
                    }
                }       
            }
            Console.WriteLine(lastMFN);     
        }
    }
}
