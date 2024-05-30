using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Manage : UserControl
    {
        int index, count;
        string imgPath;
        private ManageBook m;
        public Manage()
        {
            InitializeComponent();
        }

        /*
         * Thêm dữ liệu vào datagridview
         */
        public void addToGrid(Book newBook)
        {
            int index = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[index];
            newRow.SetValues(newBook.Id, newBook.Title, newBook.Author, newBook.Category, newBook.Date.ToString("dd/MM/yyyy"), newBook.Quanti);
        }

        // Nạp chồng
        private void addToGrid(List<Book> books)
        {
            foreach (Book book in books)
            {
                int idx = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[idx];
                newRow.SetValues(book.Id, book.Title, book.Author, book.Category, book.Date.ToString("dd/MM/yyyy"), book.Quanti);
            }
        }

        // Nút thêm ảnh cho sách
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dfg = new OpenFileDialog
            {
                Filter = "JPG file(*.jpg)|*.jpg"
            };
            if (dfg.ShowDialog() == DialogResult.OK)
            {
                imgPath = dfg.FileName;
                pictureBox1.Image = Image.FromFile(dfg.FileName);
            }
        }

        // Kiểm tra các trường dữ liệu đầu vào có phù hợp hay không ?
        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(titleTxt.Text) &&
                   !string.IsNullOrWhiteSpace(authorTxt.Text) &&
                   category.SelectedItem != null &&
                   int.TryParse(quantiTxt.Text, out _);
        }

        // Thêm sách
        private void addBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ trường thông tin");
                }
                else
                {
                    count++;
                    Book newBook = new Book(count, titleTxt.Text, authorTxt.Text, category.SelectedItem.ToString(),
                                            int.Parse(quantiTxt.Text), dateTimePicker1.Value.ToString(), imgPath);
                    this.addToGrid(newBook);
                    m.AddBook(newBook);
                    reload();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số quá lớn hoặc quá nhỏ");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        // Khởi tạo lại các ô nhập và lưu lại vào file Books.xml
        private void reload()
        {
            imgPath = "";
            titleTxt.Text = authorTxt.Text = category.Text = quantiTxt.Text = String.Empty;
            pictureBox1.Image = null;
            m.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
        }

        // Cập nhật lại thông tin cho các cuốn chọn một hàng trong datagridview 
        private void updateCell(Book book, int index,bool hasPath = false)
        {
            DataGridViewRow row = dataGridView1.Rows[index];
            if (hasPath == false) // hasPath : kiểm tra các xem có thêm ảnh hay không ?
            {
                row.SetValues(book.Id, book.Title, book.Author, book.Category, book.Date.ToString("dd/MM/yyyy"), book.Quanti);
            }
            else { row.SetValues(book.Id, book.Title, book.Author, book.Category, book.Date.ToString("dd/MM/yyyy"), book.Quanti, book.ImgPath); }
            reload();
        }

        // Xử lý sự kiện cập nhật hàng dữ liệu
        private void updateBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (!ValidateInputs())
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ trường thông tin");
                    }
                    else
                    {
                        m.Books[index].Title = titleTxt.Text;
                        m.Books[index].Author = authorTxt.Text;
                        m.Books[index].Category = category.SelectedItem.ToString();
                        m.Books[index].Quanti = int.Parse(quantiTxt.Text);
                        m.Books[index].Date = dateTimePicker1.Value;
                        m.Books[index].ImgPath = (!String.IsNullOrEmpty(imgPath)) ? imgPath : m.Books[index].ImgPath;
                        updateCell(m.Books[index], index, !String.IsNullOrEmpty(imgPath));
                    }
                }
                else return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message);
            }
        }

        // Lấy thông tin của hàng dữ liệu được chọn và đưa vào các trường dữ liệu nhập
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = (int)e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            titleTxt.Text = row.Cells["Title"].Value.ToString();
            authorTxt.Text = row.Cells["author"].Value.ToString();
            quantiTxt.Text = row.Cells["quantity"].Value.ToString();
            category.Text = row.Cells["Cate"].Value.ToString();
            string dateString = row.Cells["Start"].Value.ToString();
            pictureBox1.Image = (!String.IsNullOrEmpty(m.Books[index].ImgPath)) ? Image.FromFile(m.Books[index].ImgPath) : null;
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))// chuyển đổi về kiểu định dạng "dd/MM/yyyy"
            {
                dateTimePicker1.Value = startDate;
            }
            else
            {
                MessageBox.Show("The date format is not valid.");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        // Xóa một cuốn sách trong dữ liệu
        private void delBt_Click(object sender, EventArgs e)
        {
            try
            {
                count--;
                index = dataGridView1.CurrentCell.RowIndex;
                m.RemoveBook(m.Books[index]);
                m.updateID(); // cập nhật lại ID của các cuốn sách sau khi xóa (Kiểm tra class ManageBook)
                reload(); // cập nhật lại sau khi xóa
                dataGridView1.Rows.RemoveAt(index);
                dataGridView1.Rows.Clear();
                this.addToGrid(m.Books);
            }
            catch { }
        }

        // Khi khởi chạy sẽ lấy dữ liệu từ file book xml và đưa vào datagridview
        private void Manage_Load(object sender, EventArgs e)
        {
            m = new ManageBook();
            try
            {
                List<Book> list = m.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
                m.Books = list;
                count = list.Count;
                this.addToGrid(list);
            }
            catch { }
        }
    }
}