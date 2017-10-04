namespace P03_Restaurant_Discount
{
    using System;

    public class RestaurantDiscount
    {
       public static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hall = string.Empty;
            var price = 0.00;

           
            if (groupSize <= 50)
            {
                hall = "Small Hall";

                if (package == "Normal")
                {
                    price = 3000 - (3000 * 0.05);                    
                }
                else if (package == "Gold")
                {
                    price = 3250 - (3250 * 0.1);
                }
                else if (package == "Platinum")
                {
                    price = 3500 - (3500 * 0.15);
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";

                if (package == "Normal")
                {
                    price = 5500 - (5500 * 0.05);
                }
                else if (package == "Gold")
                {
                    price = 5750 - (5750 * 0.1);
                }
                else if (package == "Platinum")
                {
                    price = 6000 - (6000 * 0.15);
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";

                if (package == "Normal")
                {
                    price = 8000 - (8000 * 0.05);
                }
                else if (package == "Gold")
                {
                    price = 8250 - (8250 * 0.1);
                }
                else if (package == "Platinum")
                {
                    price = 9000 - (9000 * 0.15);
                }
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                var pricePerPerson = price / groupSize;
                Console.WriteLine($"We can offer you the {hall}\nThe price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
