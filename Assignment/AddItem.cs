using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AddItem : UserControl
    {
        private ManageBook manager = new ManageBook();
        public AddItem()
        {
            InitializeComponent();
        }

        private void addToGrid(Book newBook)
        {
            int index = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[index];
            newRow.SetValues(newBook.Id, newBook.Title, newBook.Author, newBook.Category, newBook.Date.ToString("dd/MM/yyyy"), newBook.Quanti);
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
    }
}
