namespace P06_SumReversedNumbers
{
    using System;
    using System.Linq;

    class SumreversedNumbers
    {
        static void Main()
        {
            Console.WriteLine(Console.ReadLine()
                .Split()
                .Select(a => int.Parse(new string(a.Reverse().ToArray())))
                .Sum());
        }   
    }
}
