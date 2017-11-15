namespace ConditionalStatementsAndLoops
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }

            

        }
    }
}
