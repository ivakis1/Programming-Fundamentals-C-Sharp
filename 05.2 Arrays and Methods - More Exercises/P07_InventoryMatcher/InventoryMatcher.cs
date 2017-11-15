namespace P07_InventoryMatcher
{
    using System;
    using System.Linq;

    public class InventoryMatcher
    {
       public static void Main()
        {
            var products = Console.ReadLine().Split(' ').ToArray();

            var quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "done")
                {
                    break;
                }

                for (int i = 0; i < products.Length; i++)
                {
                    if (input == products[i])
                    {
                        Console.WriteLine($"{products[i]} costs: {price[i]}; Available quantity: {quantity[i]}");
                    }
                }
            }
        }
    }
}
