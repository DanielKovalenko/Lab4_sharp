using System;

namespace Linq_Lab1.Model
{
    [Serializable]
    public class Books
    {
        //Автор, назва, видавництво, рік видання

        public string Author { get; set; }
        public string Title { get; set; }
        public string Publishing { get; set; }
        public int Publication_year { get; set; }

        public Books(string author, string title, string publishing, int year)
        {
            Author = author;
            Title = title;
            Publishing = publishing;
            Publication_year = year;
        }
        public Books()
        {

        }
    }
}
