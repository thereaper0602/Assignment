using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Find : UserControl
    {
        ManageBook manager = new ManageBook();
        public Find()
        {
            InitializeComponent();
        }

        private void addToGrid(List<Book> books)
        {
            foreach (Book book in books)
            {
                int idx = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[idx];
                newRow.SetValues(book.Id, book.Title, book.Author, book.Category, book.Date.ToString("dd/MM/yyyy"), book.Quanti);
            }
        }
        private void Find_Load(object sender, EventArgs e)
        {
            try
            {
                List<Book> books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
                manager.Books = books;
                this.addToGrid(books);
            }
            catch { }
        }

        private void findBt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Book> find = new List<Book>();
            if (sortDate.Text.Equals("Mới nhất"))
            {
                find = manager.FindBook(idTxt.Text, titleTxt.Text, category.Text,true);
            }
            else
            {
                find = manager.FindBook(idTxt.Text, titleTxt.Text, category.Text, false);
            }
            addToGrid(find);
        }

        private void Find_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<Book> books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
                manager.Books = books;
                this.addToGrid(books);
            }
            catch { }
        }
    }
}
