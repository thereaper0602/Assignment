using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Manage : UserControl
    {
        int index,count;
        private ManageBook m = new ManageBook();
        public Manage()
        {
            InitializeComponent();
        }

        public void addToGrid(Book newBook)
        {
            int index = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[index];
            newRow.SetValues(newBook.Id, newBook.Title, newBook.Author, newBook.Category, newBook.Date.ToString("dd/MM/yyyy"), newBook.Quanti);
        }

        private void addToGrid(List<Book> books)
        {
            foreach(Book book in books)
            {
                int idx = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[idx];
                newRow.SetValues(book.Id, book.Title, book.Author, book.Category, book.Date.ToString("dd/MM/yyyy"), book.Quanti);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dfg = new OpenFileDialog
            {
                Filter = "JPG file(*.jpg)|*.jpg"
            };
            if(dfg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dfg.FileName);
            }
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            count++;
            Book newBook = new Book(count,titleTxt.Text, authorTxt.Text, category.SelectedItem.ToString(),
                                    int.Parse(quantiTxt.Text), dateTimePicker1.Value.ToString());
            Main.manager.AddBook(newBook);
            this.addToGrid(newBook);
            Main.manager.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
            titleTxt.Text = "";
            authorTxt.Text = "";
            category.Text = "";
            quantiTxt.Text = "";
        }
        private void updateCell(Book book,int index)
        {
            DataGridViewRow row = dataGridView1.Rows[index];
            row.SetValues(book.Id, book.Title, book.Author, book.Category,book.Date.ToString("dd/MM/yyyy"), book.Quanti);
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    Main.manager.Books[index].Title = titleTxt.Text;
                    Main.manager.Books[index].Author = authorTxt.Text;
                    Main.manager.Books[index].Category = category.SelectedItem.ToString();
                    Main.manager.Books[index].Quanti = int.Parse(quantiTxt.Text);
                    Main.manager.Books[index].Date = dateTimePicker1.Value;
                    updateCell(Main.manager.Books[index], index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating book: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = (int)e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            titleTxt.Text = row.Cells["Title"].Value.ToString();
            authorTxt.Text = row.Cells["author"].Value.ToString();
            quantiTxt.Text = row.Cells["quantity"].Value.ToString();
            category.Text = row.Cells["Cate"].Value.ToString();
            // Chuyển đổi an toàn ngày tháng từ chuỗi
            string dateString = row.Cells["Start"].Value.ToString();
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))
            {
                dateTimePicker1.Value = startDate;
            }
            else
            {
                MessageBox.Show("The date format is not valid.");
                // Bạn có thể đặt một giá trị mặc định hoặc xử lý lỗi theo cách khác
                dateTimePicker1.Value = DateTime.Now; // Đặt giá trị mặc định
            }
        }

        private void delBt_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            Main.manager.RemoveBook(Main.manager.Books[index]);
            dataGridView1.Rows.RemoveAt(index);
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            try
            {
                List<Book> list = m.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
                count = list.Count;
                this.addToGrid(list);
            }
            catch { }
        }
    }
}
