using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Find : UserControl
    {
        ManageBook manager;
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
                manager = new ManageBook();
                List<Book> books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
                manager.Books = books;
                this.addToGrid(books);
            }
            catch { }
        }

        private void findBt_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<Book> find = new List<Book>();
                if (sortDate.Text.Equals("Mới nhất"))
                {
                    find = manager.FindBook(idTxt.Text, titleTxt.Text, category.Text, true);
                }
                else
                {
                    find = manager.FindBook(idTxt.Text, titleTxt.Text, category.Text, false);
                }
                if(find.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách");
                    return;
                }
                addToGrid(find);
            }
            catch { }
        }

        // Khi có sự thay đổi về visible thì dữ liệu phải được cập nhật lại sao cho đồng bộ với ứng dụng
        private void Find_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if(Visible == true)
                {
                    dataGridView1.Rows.Clear();
                    List<Book> books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
                    manager.Books = books;
                    this.addToGrid(books);
                }
            }
            catch { }
        }

        // Khôi phục lại trạng thái ban đầu sau khi kiếm xong
        private void refreshBt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Book> books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
            this.addToGrid(books);
        }
    }
}
