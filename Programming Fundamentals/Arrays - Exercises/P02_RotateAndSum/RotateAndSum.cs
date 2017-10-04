namespace P02_RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotate = int.Parse(Console.ReadLine());

            var sum = new int[array.Length];

            for (int i = 0; i < rotate; i++)
            {
                RotateArray(array);

                for (int j = 0; j < array.Length; j++)
                {
                 sum[j] = array[j] + sum[j];
                } 
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static void RotateArray(int[] array)
        {
            var lastNum = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
                
            }
            array[0] = lastNum;
        }
    }
}
