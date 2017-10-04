using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_SupermarketDatabase
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {

            var stocks = new Dictionary<string, double>(); // name + price + quantity 

            var nameAndQuantity = new Dictionary<string, double>();

            for (int i = 0; ; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "stocked")
                {
                    break;
                }

                if (!stocks.ContainsKey(input[0]))
                {
                    stocks.Add(input[0], double.Parse(input[1]));

                    nameAndQuantity[input[0]] = double.Parse(input[2]);                

                }
                else
                {
                    nameAndQuantity[input[0]] = nameAndQuantity[input[0]] + double.Parse(input[2]);

                    stocks[input[0]] = double.Parse(input[1]);


                }
            }


      
            var quantities = new List<double>();

            foreach (var item in nameAndQuantity)
            {
                quantities.Add(item.Value);
            }


            var names = new List<string>();
            var prices = new List<double>();

            foreach (var item in stocks)
            {

                names.Add(item.Key);
                prices.Add(item.Value);

            }

            var sum = 0.0;

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]}: ${prices[i]:F2} * {quantities[i]} = ${(prices[i] * quantities[i]):F2}");

                sum += prices[i] * quantities[i];

               
            }

          
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${sum:F2}");




        }
    }
}
