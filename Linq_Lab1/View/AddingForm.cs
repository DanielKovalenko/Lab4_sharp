using System;
using Linq_Lab1.Model;
using System.Windows.Forms;

namespace Linq_Lab1.View
{
    public partial class AddingForm : Form
    {
        public Books Book { get; set; }
        public AddingForm()
        {
            InitializeComponent();
            btAdd.Click += OnAddClick;
            btCancel.Click += OnCancelClick;
        }
        public AddingForm SetBook(Books books)
        {
            if (books == null)
                return this;

            Book = books;
            boxAuthor.Text = Book.Author;
            boxPublishing.Text = Book.Publishing;
            boxTitle.Text = Book.Title;
            datePublYear.Value = DateTime.Parse(Book.Publication_year.ToString());

            return this;
        }

        private void OnAddClick(object sender, System.EventArgs e)
        {

            Book = new Books(boxAuthor.Text, boxTitle.Text, boxPublishing.Text, int.Parse(datePublYear.Text));

           
            DialogResult = DialogResult.OK;
            Close();
        }
        private void OnCancelClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
