namespace p16_Comparing_Floats
{
    using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double numCompared = num1 + 0.000001;
            double numCompared2 = num2 + 0.000001;

            if (num2 >= numCompared)
            {
                Console.WriteLine("False");
            }

            else if(num1 >= numCompared2)
            {
                Console.WriteLine("False");
            }
        
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
