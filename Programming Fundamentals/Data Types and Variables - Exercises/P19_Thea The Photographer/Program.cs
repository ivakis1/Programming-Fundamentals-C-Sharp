using System;

namespace P19_TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long countPictures = long.Parse(Console.ReadLine());
            long filterTimeForOnePicture = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double filteredPicturesCount = Math.Ceiling(countPictures * (filterFactor / 100.0));
            double filteringTime = countPictures * filterTimeForOnePicture;
            double uploadFilteredPics = filteredPicturesCount * uploadTime;
            double totalTime = filteringTime + uploadFilteredPics;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string result = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);

        }
    }
}