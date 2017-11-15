namespace P10_IndexOfLetters
{
    using System;
 
   public class IndexOfLetters
    {
       public static void Main()
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var inputWord = Console.ReadLine().ToCharArray();

            for (int i = 0; i < inputWord.Length; i++)
            {
                var currLetter = inputWord[i];

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (currLetter == alphabet[j])
                    {
                        Console.WriteLine($"{currLetter} -> {j}");
                    }
                }
            }
            
        }
    }
}
