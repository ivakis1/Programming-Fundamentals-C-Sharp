namespace P02_NumberChecker
{
    using System;

   public class NumberChecker
    {
       public static void Main()
        {
            try
            {
                var inputInteger = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
