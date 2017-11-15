namespace P10_CubeProperties
{
    using System;

   public class CubeProperties
    {
      public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameterToCalculate = Console.ReadLine();

            if (parameterToCalculate == "face")
            {
                double face = GetFaceDiagonals(side);

                Console.WriteLine("{0:f2}", face);
            }
            else if (parameterToCalculate == "space")
            {
                double space = GetSpaceDiagonals(side);

                Console.WriteLine("{0:f2}", space);
            }
            else if (parameterToCalculate == "volume")
            {
                double volume = GetCubeVolume(side);

                Console.WriteLine("{0:f2}", volume);
            }
            else if (parameterToCalculate == "area")
            {
                double area = GetCubeArea(side);

                Console.WriteLine("{0:f2}", area);
            }


        }

        public static double GetFaceDiagonals(double side)
        {
            double faceDiagonals = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiagonals;
        }

        public static double GetSpaceDiagonals(double side)
        {
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiagonals;
        }

        public static double GetCubeVolume (double side)
        {
            double cubeVolume = Math.Pow(side, 3);
            return cubeVolume;
        }

        public static double GetCubeArea (double side)
        {
            double cubeArea = 6 * Math.Pow(side, 2);
            return cubeArea;
        }

    }
}
