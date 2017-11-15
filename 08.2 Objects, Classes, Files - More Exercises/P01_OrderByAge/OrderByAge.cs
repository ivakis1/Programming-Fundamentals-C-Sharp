namespace P01_OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Student
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }

    class OrderByAge
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            for (int i = 0; ; i++)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                var name = input[0];
                var id = input[1];
                var age = int.Parse(input[2]);

                var student = new Student
                {
                    Name = name,
                    Id = id,
                    Age = age
                };

                students.Add(student);
            }

            foreach (var item in students.OrderBy(item => item.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
}
