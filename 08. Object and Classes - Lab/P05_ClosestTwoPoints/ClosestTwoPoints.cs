using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_ClosestTwoPoints
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

   public class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var pointsPart = Console.ReadLine().Split().Select(double.Parse).ToList();

                var currentPoint = new Point
                {
                    X = pointsPart[0],
                    Y = pointsPart[1]
                };

                points.Add(currentPoint);             
            }

            var pointsMinDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;


            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = CalcDistance(firstPoint, secondPoint);

                    if (currentDistance < pointsMinDistance)
                    {
                        pointsMinDistance = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }             
            }
            Console.WriteLine($"{pointsMinDistance:F3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
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
