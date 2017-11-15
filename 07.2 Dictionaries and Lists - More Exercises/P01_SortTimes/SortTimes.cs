namespace P01_SortTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortTimes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
              
            input.Sort();

            Console.WriteLine(string.Join(", ", input));
          
        }
    }
}
