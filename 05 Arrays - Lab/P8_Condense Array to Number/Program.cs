namespace P8_Condense_Array_to_Number
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(String.Join(", ", nums));

            //while (nums.Length > 1)
            //{
            //    var condensed = new int[nums.Length - 1];

            //    for (int i = 0; i < nums.Length - 1; i++)
            //    {
            //        condensed[i] = nums[i] + nums[1 + i];
            //    }

            //    nums = condensed;
            //}

            //Console.WriteLine(nums[0]);

        }
    }
}
