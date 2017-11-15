namespace P08_UpgradedMatcher
{
    using System;
    using System.Linq;

   public class UpgradedMatcher
    {
       public static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(' ').ToArray();
            var quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "done")
                {
                    break;
                }

                for (int i = 0; i < products.Length; i++)
                {
                    if (input[0] == products[i])
                    {
                        var quantityNeeded = long.Parse(input[1]);

                        try
                        {
                            if (quantityNeeded <= quantity[i])
                            {
                                Console.WriteLine($"{products[i]} x {quantityNeeded} costs {quantityNeeded * price[i]:F2}");

                                quantity[i] = quantity[i] - quantityNeeded;
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                            break;
                        }

                        if (quantityNeeded > quantity[i])
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                            break;
                        }
                    }
                }
            }
        }
    }
}
