namespace P07_Cake_Ingredients
{
    using System;

    public class Program
    {
       public static void Main(string[] args)
        {

            var count = 0;

            for (int i = 0; i < 50; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                count++;

                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
