namespace P02_AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


   public class AppendLists
    {
       public static void Main()
        {
            var items = Console.ReadLine().Split('|').ToList();

            items.Reverse();

            var result = new List<string>();
            var nums = new List<string>();


            foreach (var item in items)
            {
                nums = item.Split(' ').ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

          
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
