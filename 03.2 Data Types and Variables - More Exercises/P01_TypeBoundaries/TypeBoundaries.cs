namespace P01_TypeBoundaries
{
    using System;

   public class TypeBoundaries
    {
       public static void Main()
        {
            var input = Console.ReadLine();

            if (input == "sbyte")
            {
                Console.WriteLine($"{sbyte.MaxValue}\n {sbyte.MinValue}");
            }
            else if (input == "byte")
            {
                Console.WriteLine($"{byte.MaxValue}\n {byte.MinValue}");
            }
            else if (input == "int")
            {
                Console.WriteLine($"{int.MaxValue}\n {int.MinValue}");
            }
            else if (input == "uint")
            {
                Console.WriteLine($"{uint.MaxValue}\n {uint.MinValue}");
            }
            else
            {
                Console.WriteLine($"{long.MaxValue}\n {long.MinValue}");

            }
        }
    }
}
