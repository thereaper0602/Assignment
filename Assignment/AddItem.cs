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
    public partial class AddItem : UserControl
    {
        private ManageBook manager;
        public AddItem()
        {
            InitializeComponent();
        }

        private void addToGrid(Book newBook)
        {
            int index = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[index];
            newRow.Cells["id"].Value = newBook.Id;
            newRow.Cells["Title"].Value = newBook.Title;
            newRow.Cells["author"].Value = newBook.Author;
            newRow.Cells["Cate"].Value = newBook.Category;
            newRow.Cells["Start"].Value = newBook.Date;
            newRow.Cells["quantity"].Value = newBook.Quanti;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(titleTxt.Text,authorTxt.Text,category.SelectedItem.ToString(),int.Parse(quantiTxt.Text),dateTimePicker1.Value.ToString());
            manager.AddBook(newBook);
            this.addToGrid(newBook);
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            manager = new ManageBook();
        }
    }
}
