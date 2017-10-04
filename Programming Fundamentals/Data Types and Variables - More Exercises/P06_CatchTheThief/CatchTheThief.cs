namespace P06_CatchTheThief
{
    using System;

    public class CatchTheThief
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            long lastNum = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (input == "sbyte")
                {
                    var currentNum = long.Parse(Console.ReadLine());

                    if (currentNum >= sbyte.MinValue && currentNum <= sbyte.MaxValue)
                    {
                        if (currentNum >= lastNum)
                        {
                            lastNum = currentNum;
                        }
                    }
                }
                else if (input == "int")
                {
                    var currentNum = long.Parse(Console.ReadLine());

                    if (currentNum >= int.MinValue && currentNum <= int.MaxValue)
                    {
                        if (currentNum >= lastNum)
                        {
                            lastNum = currentNum;
                        }
                    }
                }
                else if (input == "long")
                {
                    var currentNum = long.Parse(Console.ReadLine());



                    if (currentNum >= lastNum)
                    {
                        lastNum = currentNum;
                    }

                }
            }
            Console.WriteLine(lastNum);


        }
    }
}
