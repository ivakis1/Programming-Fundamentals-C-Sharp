namespace P04_Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Largest3Numbers
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(", ", input.OrderByDescending(x => x).Take(3)));
        }
    }
}
