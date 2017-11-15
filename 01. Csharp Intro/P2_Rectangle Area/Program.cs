using System;


namespace P2_Rectangle_Area
{
   public class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var sum = width * height;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
