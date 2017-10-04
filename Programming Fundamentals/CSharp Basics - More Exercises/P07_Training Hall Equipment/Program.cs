namespace P07_Training_Hall_Equipment
{
    using System;

    public class Program
    {
       public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var items = int.Parse(Console.ReadLine());

            var subtotal = 0.0;

            for (int i = 0; i < items; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                subtotal += itemPrice * itemCount;

                if (itemCount > 1)
                {
                    itemName = itemName + "s";
                }
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }

            Console.WriteLine($"Subtotal: ${subtotal:F2}");

            if (subtotal <= budget)
            {
                Console.WriteLine($"Money left: ${(budget - subtotal):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(subtotal - budget):F2} more.");
            }
        }
    }
}
