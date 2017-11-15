using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            var pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)\|";

            var matchedForecast = new Dictionary<string, Dictionary<double, string>>();

            var text = Console.ReadLine();

            while (text != "end")
            {
                var weatherMatch = Regex.Match(text, pattern);

                if (weatherMatch.Success)
                {
                    var city = weatherMatch.Groups[1].Value;
                    var temp = double.Parse(weatherMatch.Groups[2].Value);
                    var weather = weatherMatch.Groups[3].Value;

                    if (!matchedForecast.ContainsKey(city))
                    {
                        matchedForecast.Add(city, new Dictionary<double, string>());
                    }

                    matchedForecast[city] = new Dictionary<double, string>() { { temp, weather } };

                }

                text = Console.ReadLine();
            }

            foreach (var item in matchedForecast.OrderBy(a => a.Value.Keys.Sum()).ToDictionary(a => a.Key, a=> a.Value))
            { 
                Console.WriteLine($"{item.Key} => {item.Value.Keys.First():f2} => {item.Value.Values.First()}");
            }
        }
    }
}
