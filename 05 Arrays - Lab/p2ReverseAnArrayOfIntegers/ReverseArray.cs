namespace p2ReverseAnArrayOfIntegers
{
    using System;
    using System.Linq;

    public class ReverseArray
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
