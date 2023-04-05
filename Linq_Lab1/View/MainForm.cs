using System;
using Linq_Lab1.Model;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Linq_Lab1.View
{
    public partial class MainForm : Form
    {

        private readonly BindingSource _bs;
        private readonly SelectionView _view;

        public MainForm()
        {
            InitializeComponent();

            btAddBook.Click += OnAddBook;
            _bs = new BindingSource();
            _bs.DataSource = Storage.Book;
            table.DataSource = _bs;

            lbCounterTitle.Text = "Number of Books";
            lbCount.Text = _bs.Count.ToString();

            btExit.Click += (sender, args) => Application.Exit();
            btGenerate.Click += OnGenerate;
            btShowBooks.Click += OnShow;

            btSortBookByAuthor.Click += OnBookSelection;
            btSortByTitle.Click += OnBookSelection;
            btSortByPublishing.Click += OnBookSelection;
            btSortByYear.Click += OnBookSelection;

            btViewPeople.Click += OnViewSelection;
            btViewBooks.Click += OnViewSelection;
            btViewPublishers.Click += OnViewSelection;
            btViewAll.Click += OnViewSelection;


            _view = new SelectionView();
            _view.StartPosition = FormStartPosition.CenterParent;
        }
        private void OnWorkersSelection(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void OnBookSelection(object sender, EventArgs e)
        {
            if (sender == btSortBookByAuthor)
            {
                _view.Binding.DataSource = Storage.SortBookByAuthor();
                _view.ShowDialog();
            }
            if (sender == btSortByTitle)
            {
                _view.Binding.DataSource = Storage.SortBookByTitle();
                _view.ShowDialog();
            }
            if (sender == btSortByPublishing)
            {
                _view.Binding.DataSource = Storage.SortBookByPublishing();
                _view.ShowDialog();
            }
            if (sender == btSortByYear)
            {
                _view.Binding.DataSource = Storage.SortBookByYear();
                _view.ShowDialog();
            }
        }
        private void OnViewSelection(object sender, EventArgs e)
        {
            if (sender == btViewPeople)
            {
                table.Columns[0].Visible = true;
                table.Columns[1].Visible = false;
                table.Columns[2].Visible = false;
                table.Columns[3].Visible = false;
            }
            if (sender == btViewBooks)
            {
                table.Columns[0].Visible = false;
                table.Columns[1].Visible = true;
                table.Columns[2].Visible = false;
                table.Columns[3].Visible = true;
            }
            if (sender == btViewPublishers)
            {
                table.Columns[0].Visible = false;
                table.Columns[1].Visible = false;
                table.Columns[2].Visible = true;
                table.Columns[3].Visible = false;
            }
            if (sender == btViewAll)
            {
                table.Columns[0].Visible = true;
                table.Columns[1].Visible = true;
                table.Columns[2].Visible = true;
                table.Columns[3].Visible = true;
            }
        }
        private void OnShow(object sender, EventArgs e)
        {
            if (sender == btShowBooks)
            {
                _bs.DataSource = Storage.Book;
                _bs.ResetBindings(true);
                lbCounterTitle.Text = "Number of Books";
                lbCount.Text = _bs.Count.ToString();
            }
        }
        private void OnGenerate(object sender, EventArgs e)
        {
            Storage.Generate();
            _bs.ResetBindings(true);
            lbCounterTitle.Text = "Number of Books";
            lbCount.Text = _bs.Count.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var serializer = new DataContractJsonSerializer(Storage.Book.GetType());

            using (var file = new FileStream("JsonSerializer", FileMode.OpenOrCreate))
            {
                serializer.WriteObject(file, Storage.Book);
            }
            const string message =
        "The file was saved on disk with the name JsonSerializer";
            const string caption = "File saving";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            /*
            object result2;
            var serializer123 = new DataContractJsonSerializer(Storage.Book.GetType());
            using (var file = new FileStream("zxc", FileMode.Open))
            {
                result2 = serializer123.ReadObject(file);
            }
            
            Books mybook = result2 as Books;
            //Books mybook1 = (Books)result2;
            IList collection = (IList)result2;
            */
            /*List<Books> newObjectList = new List<Books>();
            foreach (var obj in result2)
            {
                
                    // копируем данные из myObj в свойства объекта вашего класса
                    Books newObject = new Books
                    {
                        Author = result2.
                        Title = mybook.Title,
                        Publishing = mybook.Publishing,
                        Publication_year = mybook.Publication_year
                    };
                }*/
        }
        private void OnAddBook(object sender, EventArgs e)
        {
            var dialog = new AddingForm();
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Storage.AddBook(dialog.Book);
            }
            _bs.ResetBindings(true);
            lbCounterTitle.Text = "Number of Books";
            lbCount.Text = _bs.Count.ToString();

        }
    }
}
