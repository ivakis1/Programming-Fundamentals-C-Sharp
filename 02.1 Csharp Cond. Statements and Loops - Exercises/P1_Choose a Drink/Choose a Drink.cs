
namespace P1_Choose_a_Drink
{
    using System;

   public class Choose_Drink
    {
       public static void Main()
        {
            var profession = Console.ReadLine();

            var drink = string.Empty;

            if (profession == "Athlete")
            {
                drink = "Water";
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }

            Console.WriteLine(drink);
        }
    }
}
