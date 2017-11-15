namespace P01_ArrayStatistics
{
    using System;
    using System.Linq;

    public class ArrayStatistics
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var min = input.Min();
            var max = input.Max();
            var sum = input.Sum();
            var average = input.Average();

            Console.WriteLine($"Min = {min}\nMax = {max}\nSum = {sum}\nAverage = {average}");


        }
    }
}
