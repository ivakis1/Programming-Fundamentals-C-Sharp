namespace P03_EnglishNameOfTheLastDigit
{
    using System;

    public class EnglishNameOfTheLastDIgit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            string name = GetName(number);

            Console.WriteLine(name);
        }

        public static string GetName(long number)
        {
            number = Math.Abs(number % 10);

            if (number == 1)
            {
                return "one";
            }
            else if (number == 2)
            {
                return "two";
            }
            else if (number == 3)
            {
                return "three";
            }
            else if (number == 4)
            {
                return "four";
            }
            else if (number == 5)
            {
                return "five";
            }
            else if (number == 6)
            {
                return "six";
            }
            else if (number == 7)
            {
                return "seven";
            }
            else if (number == 8)
            {
                return "eight";
            }
            else if (number == 0)
            {
                return "zero";
            }
            else
            {
                return "nine";
            }
        }
    }
}
