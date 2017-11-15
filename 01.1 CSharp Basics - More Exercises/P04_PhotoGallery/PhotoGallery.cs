namespace P04_PhotoGallery
{
    using System;

   public class PhotoGallery
    {
       public static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var size = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());


            var orientation = string.Empty;

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (height > width)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minute:D2}");

            if (size <= 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size > 1000 && size <= 999999)
            {
                double sizeEnd = size / 1000;
                Console.WriteLine($"Size: {sizeEnd}KB");
            }
            else if (size >= 1000000)
            {
                double sizeEnd = size / 1000000;
                Console.WriteLine($"Size: {sizeEnd}MB");
            }
                                    
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");


        }
    }
}
