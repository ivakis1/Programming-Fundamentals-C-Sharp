namespace P05_BMP_Counter
{
    using System;

    public class BMPCounter
    {
       public static void Main()
        {
            double bmp = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            var bars = Math.Round(numberOfBeats / 4.0, 1);

            double beatPerSecond = 60 / bmp;

            double totalSeconds = beatPerSecond * numberOfBeats;

            int seconds = (int) totalSeconds % 60;

            int minutes = (int) totalSeconds / 60;

          

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");



        }
    }
}
