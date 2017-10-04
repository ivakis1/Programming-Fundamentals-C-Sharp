namespace P06_Interval_of_Numbers
{
    using System;

    public class IntervalOfNumbers
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}
