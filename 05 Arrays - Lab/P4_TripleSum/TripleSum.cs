namespace P4_TripleSum
{
    using System;

    public class TripleSum
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] items = input.Split(' ');

            int[] array = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                array[i] = int.Parse(items[i]);
            }

            int sum = 0;
            bool tripleExist = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (i < j && array[i] >= 0 && array[j] >= 0)
                    {
                        sum = array[i] + array[j];
                    }                   
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (sum == array[k])
                        {
                            tripleExist = true;
                            Console.Write($"{array[i]} + {array[j]} == {array[k]}");
                            Console.WriteLine();
                            break;
                        }                   
                    }
                }
            }
            if (tripleExist == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
