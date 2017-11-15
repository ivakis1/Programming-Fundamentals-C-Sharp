using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_AdreyAndBillard
{
    class Customer
    {
        //  public string Name { get; set; }

        public Dictionary<string, int> Orders { get; set; }

        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, decimal>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split('-');
                var productName = input[0];

                products[productName] = decimal.Parse(input[1]);
            }

            var customers = new Dictionary<string, Customer>();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var tokens = Console.ReadLine().Split(new char[] { '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries);


                var name = tokens[0];
                var item = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(item))
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (!customers.ContainsKey(name))
                {
                    customers[name] = new Customer
                    {
                        Orders = new Dictionary<string, int>()
                    };
                }

                if (!customers[name].Orders.ContainsKey(item))
                {
                    customers[name].Orders[item] = 0;
                }

                customers[name].Orders[item] += quantity;
            }

            customers = customers.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var customerNameAndOrdersAndBill in customers)
            {
                var customerOrders = customerNameAndOrdersAndBill.Value;

                customerOrders.Bill = customerOrders.Orders.Values.Sum();

                //Console.WriteLine(customerNameAndOrdersAndBill.);
            }
        }
    }
}
