namespace P05_WeatherForecast
{
    using System;

    public class WeatherForecast
    {
       public static void Main()
        {
            try
            {
                var input = long.Parse(Console.ReadLine());

                if (input >= sbyte.MinValue && input <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (input >= int.MinValue && input <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
                
            }
            catch
            {
                Console.WriteLine("Rainy");
            }

           
        }
    }
}
