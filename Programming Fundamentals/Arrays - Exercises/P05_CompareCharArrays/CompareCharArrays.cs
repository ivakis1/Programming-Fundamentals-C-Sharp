namespace P05_CompareCharArrays
{
    using System;
    using System.Linq;

   public class CompareCharArrays
    {
       public static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ');
            var secondArray = Console.ReadLine().Split(' ');
            

            var smallerArray = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < smallerArray; i++)
            {
                var letters = firstArray[i].CompareTo(secondArray[i]);

                if (letters == 0)
                {
                    continue;

                }
                if(letters < 0)
                {
                    Console.WriteLine(string.Join("", firstArray));
                    Console.WriteLine(string.Join("", secondArray));
                    return;
                }
                else if (letters > 0)
                {
                    Console.WriteLine(string.Join("", secondArray));
                    Console.WriteLine(string.Join("", firstArray));
                    return;
                }

            }

            if (firstArray.Length <= secondArray.Length)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }

        }
    }
}
