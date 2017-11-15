using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double Average
        {
            get
            {
                return Grades.Average();
            }
        }
    }
    class AverageGrades
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input.First();

                var grades = input.Skip(1).Select(double.Parse).ToArray();

                var student = new Student
                {
                    Name = name,
                    Grades = grades
                };

                students.Add(student);
            }
            students = students
                .Where(a => a.Average >= 5.00)
                .OrderBy(a => a.Name)
                .ThenByDescending(a => a.Average)
                .ToList();


            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name} -> {item.Average:F2}");
            }
        }
    }
}
