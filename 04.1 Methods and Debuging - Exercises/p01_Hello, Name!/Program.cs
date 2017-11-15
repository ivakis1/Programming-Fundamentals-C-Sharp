namespace p01_Hello_Name
{

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            GetName(name);

        }public static string GetName(string name)
        {
            Console.WriteLine($"Hello, {name}!");

            return name;
        }
    }
}
