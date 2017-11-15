using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new SortedDictionary<string, Dictionary<string, int>>(); //country / town / population

            for (int i = 0; ; i++)
            {
                var input = Console.ReadLine().Split('|');

                if (input[0] == "report")
                {
                    break;
                }

                var country = input[1];
                var town = input[0];
                var population = int.Parse(input[2]);

                if (!dic.ContainsKey(country))
                {
                    dic.Add(country, new Dictionary<string, int>());
                }
                if (!dic[country].ContainsKey(town))
                {
                    dic[country].Add(town, 0);
                }

                dic[country][town] += population;

            }
            foreach (KeyValuePair<string, Dictionary<string, int>> item in dic
                .OrderByDescending(a => a.Value.Values.Sum())) // country 
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");


                foreach (KeyValuePair<string, int> count in item.Value.OrderByDescending(a => a.Value)) // town, populaton
                {
                    Console.WriteLine($"=>{count.Key}: {count.Value} ");
                }
            }

        }
    }
}
