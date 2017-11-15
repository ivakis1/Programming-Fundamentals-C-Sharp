using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_IntersectionOfCircle
{ 
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class IntersectionOfCircle
    {
        static void Main(string[] args)
        {
            var firstCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();


            var fistCirclePoints = new Point
            {
                X = firstCoordinates[0],
                Y = firstCoordinates[1]
            };

            var secondCirclePoint = new Point
            {
                X = secondCoordinates[0],
                Y = secondCoordinates[1]

            };


            bool isIntersect = false;

            var distance = Distance(fistCirclePoints, secondCirclePoint);

            if (distance <= firstCoordinates[2] + secondCoordinates[2])
            {
                isIntersect = true;
            }

            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        public static double Distance(Point c1, Point c2)
        {
            var diffX = Math.Abs(c1.X - c2.X);
            var diffY = Math.Abs(c1.Y - c2.Y);

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);


            var distance =  Math.Sqrt(powX + powY);


            return distance;

        }
    }
}
