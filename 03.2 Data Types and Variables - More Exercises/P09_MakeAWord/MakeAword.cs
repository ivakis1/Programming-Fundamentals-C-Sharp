namespace P09_MakeAWord
{
    using System;

    public class MakeAword
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var word = new string[n];

            for (int i = 0; i < n; i++)
            {
                string letter = Console.ReadLine();

                word[i] = letter;
               
            }           
           
            Console.WriteLine($"The word is: " + string.Join("", word));
        }
    }
}
