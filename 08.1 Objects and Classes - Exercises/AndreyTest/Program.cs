using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyTest
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductsAndQuantity { get; set; }
        public decimal Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var goodsAndPrices = new Dictionary<string, decimal>();

            fillWithGoods(goodsAndPrices);

            List<Customer> customers = new List<Customer>(); 

            string command = Console.ReadLine();

            while (command != "end of clients")
            {
                var commandArgs = command.Split('-');
                var quantityAndProduct = commandArgs[1].Split(',');

                var name = commandArgs[0];
                var product = quantityAndProduct[0];
                var quantity = int.Parse(quantityAndProduct[1]);

                if (goodsAndPrices.ContainsKey(product))
                {
                    bool customerIsPresent = false;


                    Customer customer = new Customer();
                    customer.Name = name;
                    customer.ProductsAndQuantity = new Dictionary<string, int>();
                    customer.ProductsAndQuantity.Add(product, quantity);
                    customer.Bill = customer.Bill + goodsAndPrices[product] * quantity;

                    foreach (var c in customers)
                    {
                        if (c.Name == customer.Name)
                        {
                            customerIsPresent = true;
                            if (c.ProductsAndQuantity.ContainsKey(product))
                            {
                                c.ProductsAndQuantity[product] += quantity;
                            }
                            else
                            {
                                c.ProductsAndQuantity.Add(product, quantity);
                            }
                            c.Bill += goodsAndPrices[product] * quantity;
                        }
                    }

                    if (!customerIsPresent)
                    {
                        customers.Add(customer);
                    }
                }
                command = Console.ReadLine();
            }

            printResult(customers);
        }

        private static void printResult(List<Customer> customers)
        {
            decimal totalBill = 0.0M;

            foreach (var customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ProductsAndQuantity)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        private static void fillWithGoods(Dictionary<string, decimal> goodsAndPrices)
        {
            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                var commandArgs = Console.ReadLine().Split('-');
                var product = commandArgs[0];
                var price = decimal.Parse(commandArgs[1]);

                if (!goodsAndPrices.ContainsKey(product))
                {
                    goodsAndPrices.Add(product, 0);
                }

                goodsAndPrices[product] = price;
            }
        }
    }
}
