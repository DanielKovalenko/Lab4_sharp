using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lab1.Model
{
    public static class Storage
    {
        public static Books[] books1 { get; private set; }
        public static readonly List<Books> Book;
        public static readonly Random Rand;

        static Storage()
        {
            books1 = new Books[0];
            Book = new List<Books>();
            Rand = new Random();
        }
        public static void AddBook(Books books)
        {
            if (books == null)
                throw new ArgumentNullException("studio");
            //var tmp1 = new List<Books>(books1.Length + 1);
            Book.Add(books);
        }
        public static void Generate()
        {
            Book.Clear();
            Book.AddRange(Rand.NextBook(20));
        }
        public static void GenerateFromFile(object obj)
        {
            Book.Clear();
            Book.AddRange(Rand.NextBook(20));
        }
        public static IEnumerable<Books> SortBookByAuthor()
        {
            return Book.OrderBy(x => x.Author);
        }

        public static IEnumerable<Books> SortBookByTitle()
        {
            return Book.OrderBy(x => x.Title);
        }
        public static IEnumerable<Books> SortBookByPublishing()
        {
            return Book.OrderBy(x => x.Publishing);
        }
        public static IEnumerable<Books> SortBookByYear()
        {
            return Book.OrderBy(x => x.Publication_year);
        }
    }
}
