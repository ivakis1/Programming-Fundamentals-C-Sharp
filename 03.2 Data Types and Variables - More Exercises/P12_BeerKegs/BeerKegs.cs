namespace P12_BeerKegs
{
    using System;

   public class BeerKegs
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            string biggestKegName = string.Empty;

            var biggestVolume = 0.0;
            

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                var kegRadius = double.Parse(Console.ReadLine());
                var kegHeigth = double.Parse(Console.ReadLine());

              var volume = Math.PI * (kegRadius * kegRadius) * kegHeigth;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKegName = kegModel+ " ";
                }
            }
            Console.WriteLine(biggestKegName.Trim());
        }
    }
}
