namespace P11_Geometry_Calculator
{
    using System;

    public class GeometryCalculator
    {
       public static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                double area = GetTriangleArea(side, height);

                Console.WriteLine("{0:f2}", area);
            }
            else if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());

                double area = GetSquareArea(side);

                Console.WriteLine("{0:f2}", area);
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());

                double area = GetCircleArea(radius);

                Console.WriteLine("{0:f2}", area);
            }
        }

        public static double GetTriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        public static double GetSquareArea(double side)
        {
            double area = side * side;
            return area;
        }

        public static double GetRectangleArea(double side, double height)
        {
            double area = side * height;
            return area;
        }

        public static double GetCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
