using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace P06_BookLibrary
{
    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string publisher { get; set; }

        public string ReleaseDate { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var books = new List<Library>();

            var booksHarakteristics = new List<Book>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();

                var book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    publisher = input[2],
                    ReleaseDate = input[3],
                    Isbn = input[4],
                    Price = decimal.Parse(input[5])
                };

                booksHarakteristics.Add(book);

                var library = new Library
                {
                    Name = "Ivo's Library",
                    Books = booksHarakteristics
                };
            }

            var result = new Dictionary<string, decimal>();

            foreach (var item in booksHarakteristics)
            {
                if (!result.ContainsKey(item.Author))
                {
                    result.Add(item.Author, 0);
                }

                result[item.Author] += item.Price;
            }

            foreach (var item in result.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
