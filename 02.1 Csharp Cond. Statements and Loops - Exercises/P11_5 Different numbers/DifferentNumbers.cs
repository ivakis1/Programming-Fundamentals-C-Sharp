namespace P11_5_Different_numbers
{
    using System;

   public class DifferentNumbers
    {
       public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            if (secondNum - firstNum <= 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    for (int k = firstNum; k <= secondNum; k++)
                    {
                        for (int l = firstNum; l <= secondNum; l++)
                        {
                            for (int m = firstNum; m <= secondNum; m++)
                            {
                                if (i >= firstNum && j > i && k > j && l > k && m > l && m <= secondNum)
                                {
                                    Console.WriteLine(i + " " + j + " " + k + " " + l + " " + m + " ");
                                }                              
                            }
                        }
                    }
                }
            }

        }
    }
}
