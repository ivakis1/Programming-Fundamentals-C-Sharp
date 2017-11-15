namespace P14_Magic_Letter
{
    using System;

   public class MagicLetter
    {
       public static void Main()
        {
            var firstLetter = (Console.ReadLine()).ToCharArray();
            var secondLetter = Console.ReadLine().ToCharArray();
            var tirthLetter = Console.ReadLine().ToCharArray();

            for (char i = firstLetter[0]; i <= secondLetter[0]; i++)
            {
                for (char j = firstLetter[0]; j <= secondLetter[0]; j++)
                {
                    for (char y = firstLetter[0]; y <= secondLetter[0]; y++)
                    {
                        if (i != tirthLetter[0] && j != tirthLetter[0] && y != tirthLetter[0])
                        {
                            Console.Write(i + "" + j + "" + y + " ");
                            
                        }
                    }
                }
            }


        }
    }
}
