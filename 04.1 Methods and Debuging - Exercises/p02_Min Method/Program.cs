namespace P02_Max_Method
{
    using System;

    public class MaxMethod
    {
        public static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            var firstOrSecondIsBigger = GetMax(firstNum, secondNum);
            var biggestNum = GetMax(firstOrSecondIsBigger, thirdNum);

            Console.WriteLine(biggestNum);
        }

        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
