
namespace P02_Choose_a_Drink_2._0
{
    using System;

    public class ChooseDrink
    {
        public static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var drinksCount = int.Parse(Console.ReadLine());

            var drink = string.Empty;
            var price = 0.00;

            if (profession == "Athlete")
            {
                drink = "Water";
                price = drinksCount * 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = drinksCount * 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = drinksCount * 1.70;
            }
            else
            {
                drink = "Tea";
                price = drinksCount * 1.20;
            }

            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
