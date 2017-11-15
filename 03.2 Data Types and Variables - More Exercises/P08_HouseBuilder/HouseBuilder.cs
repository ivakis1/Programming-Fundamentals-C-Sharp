namespace P08_HouseBuilder
{
    using System;

   public class HouseBuilder
    {
       public static void Main(string[] args)
        {
            var firstInput = long.Parse(Console.ReadLine());
            var secondInput = long.Parse(Console.ReadLine());

            long price = 0;

            if (firstInput >= sbyte.MinValue && firstInput <= sbyte.MaxValue)
            {
                price = (firstInput * 4) + (secondInput * 10);
            }
            else
            {
                price = secondInput * 4 + firstInput * 10;
            }

            Console.WriteLine(price);
        }
    }
}
