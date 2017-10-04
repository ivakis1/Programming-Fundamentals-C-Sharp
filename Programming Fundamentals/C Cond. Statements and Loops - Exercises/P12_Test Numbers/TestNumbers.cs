namespace P12_Test_Numbers
{
    using System;

    public class TestNumbers
    {
        public static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var maxNum = int.Parse(Console.ReadLine());

            var sum = 0;
            var count = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                if (sum >= maxNum)
                {
                    break;
                }
                for (int j = 1; j <= secondNum; j++)
                {
                    sum += 3 * (i * j);
                    count++;

                    if (sum >= maxNum)
                    {
                        break;
                    }


                }
            }
            if (sum >= maxNum)
            {
                Console.WriteLine($"{count} combinations\nSum: {sum} >= {maxNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations\nSum: {sum}");
            }
        }
    }
}
