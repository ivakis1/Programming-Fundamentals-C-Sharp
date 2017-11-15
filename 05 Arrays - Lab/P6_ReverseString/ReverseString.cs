namespace P6_ReverseString
{
    using System;
    using System.Linq;

    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string[] reverseInput = new string[input.Length];

            for (int i = 0; i < reverseInput.Length; i++)
            {
                reverseInput[i] = input[input.Length - 1 - i];
            }
         
            Console.Write(string.Join(" ", reverseInput));
        }
    }
}
