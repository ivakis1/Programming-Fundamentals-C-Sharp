namespace P05_PizzaIngredients
{
    using System;
    using System.Linq;

    public class PizzaIngredients
    {
        public static void Main()
        {
            var originalIngredients = Console.ReadLine().Split(' ').ToArray();

            var length = int.Parse(Console.ReadLine());

            var ingredients = new string[10];

            var position = 0;

            for (int i = 0; i < originalIngredients.Length; i++)
            {

                if (originalIngredients[i].Length == length)
                {
                    ingredients[position] = originalIngredients[i];
                    position++;
                    Console.WriteLine($"Adding {originalIngredients[i]}.");

                }
                if (position == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {position} ingredients.");

            var arrayOfIngredients = new string[position];

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] != null)
                {
                    arrayOfIngredients[i] = ingredients[i];
                }
            }
            Console.Write($"The ingredients are: " + string.Join(", ", arrayOfIngredients) + ".");
            Console.WriteLine();

        }
    }
}
