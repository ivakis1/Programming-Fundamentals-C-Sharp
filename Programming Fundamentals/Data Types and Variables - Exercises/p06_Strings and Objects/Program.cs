namespace p06_Strings_and_Objects
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
    
            object obj = first + " " + second;
          
            Console.WriteLine((string)obj);
        }
    }
}
