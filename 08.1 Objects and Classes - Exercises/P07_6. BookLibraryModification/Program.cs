using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_6.BookLibraryModification
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

        public DateTime ReleaseDate { get; set; }

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
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy",
                CultureInfo.InvariantCulture),
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

            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",
                CultureInfo.InvariantCulture);

            var result = new Dictionary<string, DateTime>();

            foreach (var item in booksHarakteristics)
            {
                if (!result.ContainsKey(item.Title))
                {
                    result.Add(item.Title, DateTime.MinValue);
                }

                result[item.Title] = item.ReleaseDate;

                if (item.ReleaseDate <= date )
                {
                    result.Remove(item.Title);
                }
            }

            foreach (var item in result.OrderBy(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Key, item.Value);
            }
        }
    }
}