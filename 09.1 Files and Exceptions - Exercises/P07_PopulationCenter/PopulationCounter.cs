using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_PopulationCenter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var populationCounter = new Dictionary<string, Dictionary<string, long>>(); // country, city, population

            for (int i = 0; ; i++)
            {
                var input = Console.ReadLine().Split('|');

                if (input[0] == "report")
                {
                    break;
                }

                var country = input[1];
                var city = input[0];
                var population = int.Parse(input[2]);

               

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter.Add(country, new Dictionary<string, long>());
                }

                if (!populationCounter[country].ContainsKey(city))
                {
                    populationCounter[country][city] = 0;
                }

                populationCounter[country][city] += population;
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in populationCounter.OrderByDescending(a => a.Value.Values.Sum()))
            {

                Console.WriteLine($"{country.Key} (total population: {country.Value.Select(a => a.Value).Sum()})");

                foreach (KeyValuePair<string, long> city in country.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
