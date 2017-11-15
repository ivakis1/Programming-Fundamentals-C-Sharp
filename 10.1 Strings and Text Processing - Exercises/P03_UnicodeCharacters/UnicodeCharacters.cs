using System;

namespace P03_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u00{0:x}", Convert.ToUInt32(input[i]));
            }
            Console.WriteLine();
        }
    }
}
