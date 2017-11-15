namespace P09_Count_the_Integers
{
    using System;

    class Program
    {
        static void Main()
        {
            var count = 0;

            for (int i = 0; i <100; i++)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    count++;
                    if (i == 99)
                    {
                        Console.WriteLine(count);
                    }
                }
                catch
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
