using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_Calculate_Triangle_Area
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(width, height);
            Console.WriteLine(area);
        }
        public static double GetTriangleArea (double width, double height)
        {
            double area = width * (height / 2);
            return area;
        }
    }
}
