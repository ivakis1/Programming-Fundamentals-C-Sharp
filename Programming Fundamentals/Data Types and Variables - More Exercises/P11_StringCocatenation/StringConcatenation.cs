namespace P11_StringCocatenation
{
    using System;

   public class StringConcatenation
    {
       public static void Main()
        {
            string delimiter = Console.ReadLine();
            string evenOrOdd = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var text = string.Empty;

            if (evenOrOdd == "even")
            {
                for (int i = 1; i <= n; i++)
                {
                    var word = Console.ReadLine();

                    if (i % 2 == 0)
                    {
                        text = text + word + delimiter;
                    }
                }
            }
            else if(evenOrOdd == "odd")
            {
                for (int i = 1; i <= n; i++)
                {
                    var word = Console.ReadLine();

                    if (i % 2 != 0)
                    {
                        text = text + word + delimiter;
                    }
                }
            }

            Console.WriteLine(text.Remove(text.Length - 1));

        }
    }
}
