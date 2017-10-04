namespace P10_CharSum
{
    using System;

    public class CharSum
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                char letterCode = input[0];

                sum += letterCode;
            
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
