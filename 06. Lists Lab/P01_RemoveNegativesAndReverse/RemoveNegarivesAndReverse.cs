namespace P01_RemoveNegativesAndReverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveNegarivesAndReverse
    {
       public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input.Reverse();

            var listWithoutNegatives = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= 0)
                {
                    listWithoutNegatives.Add(input[i]);
                }
                
            }

            if (listWithoutNegatives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", listWithoutNegatives));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
