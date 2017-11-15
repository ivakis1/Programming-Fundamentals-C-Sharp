using System;


namespace p07_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if(input == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int max = GetMax(firstNumber, secondNumber);

                Console.WriteLine(max);
            }
            else if (input == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char max = GetMax(firstChar, secondChar);

                Console.WriteLine(max);

            }
            else if (input == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string max = GetMax(firstString, secondString);

                Console.WriteLine(max);
            }

        }

        static int GetMax (int firstNumber, int secondNumber)
        {
            int max = 0;

            if (firstNumber >= secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }
            return max;
        }

        static char GetMax (char firstChar, char secondChar)
        {
            char max = 'a';

            if (firstChar >= secondChar)
            {
                max = firstChar;
            }
            else
            {
                max = secondChar;
            }

            return max;
        }

        static string GetMax(string firstString, string secondString)
        {
            string max = string.Empty;

            if (firstString.CompareTo(secondString) >= 0)
            {
                max = firstString;
            }
            else
            {
                max = secondString;
            }

            return max;
        }
    }
}
