using System;
using System.Collections.Generic;

namespace Linq_Lab1.Model
{
    public static class RandomExtension
    {
        private static string[] Authors_name;
        private static string[] Authors_surname;
        private static string[] Book_titles;
        private static string[] Publishers;

        static RandomExtension()
        {
            Authors_name = new string[]
            {
                "Sofia", "Polina", "Oleksandr", "Ivan", "Volodimir", "Victoria", "Anton", "Petro", "Oleksii", "Mikola", "Oleg",
                "Anna", "Alina", "Irina", "Maria", "Olga", "Natalya", "Darya", "Ekateryna", "Elena", "Karyna", "Diana", "Inna"
            };

            Authors_surname = new string[]
            {
                "Petrenko", "Boiko", "Shevchenko", "Ivanenko", "Sidorenko", "Zinchenko", "Melinyk",
                "Kravchenko", "Simonenko", "Oliynik", "Klochko", "Klichko", "Kovalenko", "Levchenko"
            };

            Book_titles = new string[]
            {
                "Kobzar", "Don Quixote", "One Hundred Years of Solitude", "The Great Gatsby",
                "Hamlet", "The Odyssey", "Madame Bovary", "Wuthering Heights", "The Catcher in the Rye",
                "Pride and Prejudice", "Alice's Adventures", "Wonderland", "The Iliad",
                "To the Lighthouse", "Heart of Darkness", "The Sound and the Fury"
            };

            Publishers = new string[]
            {
                "Ranok", "Svitanok", "Mria", "Caravela",
                "New Time Books", "Vivat", "Komubook", "Laurus Press",
                "Discursus"
            };
        }

        public static IEnumerable<Books> NextBook(this Random arg, int max)
        {
            var result = new Books[arg.Next(10, max)];
            for (var i = 0; i < result.Length; ++i)
                result[i] = arg.NextBook();
            return result;
        }
        public static Books NextBook(this Random arg)
        {
            return new Books()
            {
                Author = arg.NextFirstName(),
                Title = arg.NextBookTitle(),
                Publishing = arg.NextPublisher(),
                Publication_year = arg.NextPublicationYear()

            };
        }
        public static string NextFirstName(this Random arg)
        {
            return Authors_name[arg.Next(0, Authors_name.Length)] + " " + Authors_surname[arg.Next(0, Authors_surname.Length)];
        }

        public static string NextBookTitle(this Random arg)
        {
            return Book_titles[arg.Next(0, Book_titles.Length)];
        }
        public static string NextPublisher(this Random arg)
        {
            return Publishers[arg.Next(0, Publishers.Length)];
        }
        public static int NextPublicationYear(this Random arg)
        {
            return arg.Next(1988, 2008);
        }
    }
}
