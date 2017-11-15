namespace P07_SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var sales = new List<Sale>();

            for (int i = 0; i < count; i++)
            {
                var readSale = Console.ReadLine().Split().ToArray();

                var currentSale = new Sale
                {
                    town = readSale[0],
                    product = readSale[1],
                    price = double.Parse(readSale[2]),
                    quantity = double.Parse(readSale[3])
                };

                sales.Add(currentSale);
            }

            var totalSales = new SortedDictionary<string, double>();

            foreach (var sale in sales)
            {
                if (!totalSales.ContainsKey(sale.town))
                {
                    totalSales[sale.town] = 0;
                }
                totalSales[sale.town] += sale.price * sale.quantity;
            }

            foreach (var kvp in totalSales)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }

        }
    }
}
