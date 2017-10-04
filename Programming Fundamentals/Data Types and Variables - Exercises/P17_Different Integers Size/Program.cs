namespace P17_Different_Integers_Size
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            try
            {
                long num = long.Parse(input);
                Console.WriteLine($"{num} can fit in:");

                if(num >= sbyte.MinValue && sbyte.MaxValue >= num)
                {
                    Console.WriteLine("* sbyte");
                }
                if (num >= byte.MinValue && byte.MaxValue >= num)
                {
                    Console.WriteLine("* byte");
                }
                if (num >= short.MinValue && short.MaxValue >= num)
                {
                    Console.WriteLine("* short");
                }
                if (num >= ushort.MinValue && ushort.MaxValue >= num)
                {
                    Console.WriteLine("* ushort");
                }
                if (num >= int.MinValue && int.MaxValue >= num)
                {
                    Console.WriteLine("* int");
                }
                if (num >= uint.MinValue && uint.MaxValue >= num)
                {
                    Console.WriteLine("* uint");
                }
                if (num >= long.MinValue && long.MaxValue >= num)
                {
                    Console.WriteLine("* long");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
