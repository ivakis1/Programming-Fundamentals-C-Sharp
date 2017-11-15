namespace P04_TouristInformation
{
    using System;

   public class TouristInformation
    {
       public static void Main()
        {
            var imperialUnit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());

            switch (imperialUnit)
            {
                case "miles":                   
                    Console.WriteLine($"{value} {imperialUnit} = {(value * 1.6):F2} kilometers");
                    break;

                case "inches":                       
                    Console.WriteLine($"{value} {imperialUnit} = {(value * 2.54):F2} centimeters");
                    break;

                case "feet":                   
                    Console.WriteLine($"{value} {imperialUnit} = {(value * 30):F2} centimeters");
                    break;

                case "yards":
                    Console.WriteLine($"{value} {imperialUnit} = {(value * 0.91):F2} meters");
                    break;

                case "gallons":
                    Console.WriteLine($"{value} {imperialUnit} = {(value * 3.8):F2} liters");
                    break;
            }           
        }
    }
}
