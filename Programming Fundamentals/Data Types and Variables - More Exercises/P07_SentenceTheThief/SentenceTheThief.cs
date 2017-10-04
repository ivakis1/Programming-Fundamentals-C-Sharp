namespace P07_SentenceTheThief
{
    using System;

    public class SentenceTheThief
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var lastNum = decimal.MinValue;

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

            decimal sentence;

            if (lastNum < 0)
            {              
                sentence = Math.Ceiling(lastNum / -128);
            }
            else
            {
                sentence = Math.Ceiling(lastNum / 127);
            }

            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {lastNum} is sentenced to {sentence} years");
            }
            else if(sentence <= 1)
            {
                Console.WriteLine($"Prisoner with id {lastNum} is sentenced to {sentence} year");
            }
        }
    }
}
