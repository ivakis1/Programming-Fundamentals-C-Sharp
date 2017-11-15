using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_DistanceBetweenPoints
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

   public class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            var firstPoint = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var secondPoint = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var first = new Point
            {
                X = firstPoint[0],
                Y = firstPoint[1]
            };

            var second = new Point
            {
                X = secondPoint[0],
                Y = secondPoint[1]
            };

            var result = CalcDistance(first, second);

            Console.WriteLine($"{result:F3}");

        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = Math.Abs(firstPoint.X - secondPoint.X);
            var diffY = Math.Abs(firstPoint.Y - secondPoint.Y);

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);


          return Math.Sqrt(powX + powY);

            
        }


    }
}
