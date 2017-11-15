namespace P04_Variable_in_Hex_Format
{
    using System;

   public class VariableInHexFormat
    {
       public static void Main(string[] args)
        {
            var number = Console.ReadLine();

            var numberInHex = Convert.ToInt32(number, 16);

            int numberInDecimal = numberInHex;

            Console.WriteLine(numberInDecimal);
        }
    }
}
