namespace P03_Megapixes
{
    using System;

   public class Megapixes
    {
       public static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var megapixes = Math.Round(width * height / 1000000, 1);

            Console.WriteLine($"{width}x{height} => {megapixes}MP");
        }
    }
}
