namespace P09_LongerLine
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x11 = double.Parse(Console.ReadLine());
            double y11 = double.Parse(Console.ReadLine());
            double x22 = double.Parse(Console.ReadLine());
            double y22 = double.Parse(Console.ReadLine());

            double dist1 = CalcDistance(x1, y1) + CalcDistance(x2, y2);
            double dist2 = CalcDistance(x11, y11) + CalcDistance(x22, y22);

            var list = new List<double>();
            var list2 = new List<double>();

            if (dist1 >= dist2)
            {
                list.Add(x2);
                list.Add(y2);
                list2.Add(x1);
                list2.Add(y1);
            }
            else
            {
                list.Add(x22);
                list.Add(y22);
                list2.Add(x11);
                list2.Add(y11);
                
            }
           
                Console.Write("(");
                Console.Write(String.Join(", ", list2));
                Console.Write(")");

                Console.Write("(");
                Console.Write(String.Join(", ", list));
                Console.WriteLine(")");
              
        }

        public static double CalcDistance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }
    }
}
