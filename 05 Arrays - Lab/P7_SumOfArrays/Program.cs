using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_SumOfArrays
{
    class Program
    {
        static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').ToArray();
            var secondArray = Console.ReadLine().Split(' ').ToArray();

            var len1 = firstArray.Length;
            var len2 = secondArray.Length;

            var result = new int[GetMax(len1, len2)];
            var firstArrayNums = StringToInt(firstArray);
            var secondArrayNums = StringToInt(secondArray);


            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstArrayNums[i % len1] + secondArrayNums[i % len2];
            }

            Console.WriteLine(String.Join(" ", result));
        }

        public static int GetMax(int len1, int len2)
        {
            if (len1 >= len2)
            {
                return len1;
            }
            else
            {
                return len2;
            }

        }

        public static int[] StringToInt(string[] firstArray)
        {
            var firstArrayNums = new int[firstArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArrayNums[i] = int.Parse(firstArray[i]);
            }
            return firstArrayNums;

        }
    }
}
