namespace P13_Game_of_Numbers
{
    using System;

   public class GameOfNumbers
    {
       public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var lastFirstNum = 0;
            var lastSecondNum = 0;
            var count = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    if (i + j == magicNum)
                    {
                        lastFirstNum = i;
                        lastSecondNum = j;
                    }
                    count++;
                }
            }

            if (lastFirstNum + lastSecondNum == magicNum)
            {
                Console.WriteLine($"Number found! {lastFirstNum} + {lastSecondNum} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum} ");
            }

        }
    }
}
