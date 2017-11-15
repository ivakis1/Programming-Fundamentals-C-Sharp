namespace Lab_Arrays
{
    using System;


    public class Program
    {
        public static void Main()
        {
            string[] days =
             {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <= days.Length)
            {
               
                Console.WriteLine(days[index - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");

            }
           

            
       }
    }
}
