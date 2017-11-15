namespace P04_Elevator
{
    using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            var persons = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            var courses = persons / capacity;

            if (persons % capacity != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
