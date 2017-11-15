namespace P07_Calories_Counter
{
    using System;

    public class CaloriesCounter
    {
       public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var tomatoSouce = 0;
            var cheese = 0;
            var salami = 0;
            var pepper = 0;
            var flour = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                if (ingredient == "tomato sauce")
                {
                    tomatoSouce++;
                }
                else if (ingredient == "cheese")
                {
                    cheese++;
                }
                else if (ingredient == "salami")
                {
                    salami++;
                }
                else if (ingredient == "pepper")
                {
                    pepper++;
                }
                
            }
            var totalCalories = tomatoSouce * 150 + cheese * 500 + salami * 600 + pepper * 50 + flour;

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
