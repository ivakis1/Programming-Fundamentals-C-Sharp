namespace P03_WaterOverflow
{
    using System;

   public class WaterOverflow
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            var capacity = 255;

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());

                sum += input;

                if (sum > capacity)
                {
                    sum -= input;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
