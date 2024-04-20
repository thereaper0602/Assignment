using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Issued : UserControl
    {
        ManageBook manager = new ManageBook();
        IssuedBook issued = new IssuedBook();
        int index;
        public Issued()
        {
            InitializeComponent();
        }

        private void addToGrid(Student student)
        {
            int idx = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[idx];
            newRow.SetValues(student.Id, student.Name, student.ClassName, student.Books.Id, student.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"), quantiTxt.Text);
        }


        private void addToGrid(List<Student> student)
        {
            foreach(Student s in student)
            {
               int idx = dataGridView1.Rows.Add();
               DataGridViewRow newRow = dataGridView1.Rows[idx];
               newRow.SetValues(s.Id, s.Name, s.ClassName, s.Books.Id, s.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"), quantiTxt.Text);
            }
        }


        private void addBt_Click(object sender, EventArgs e)
        {
            try
            {
                List<Book> book = manager.FindBook(idBook.SelectedText);
                Student student = new Student(mssvTxt.Text, studentNameTxt.Text, classNameTxt.Text, book[0]);
                issued.addStudent(student);
                this.addToGrid(student);
                mssvTxt.Text = studentNameTxt.Text = classNameTxt.Text = bookNameTxt.Text = quantiTxt.Text = idBook.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void Issued_Load(object sender, EventArgs e)
        {
            manager.Books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
            foreach(var item in manager.Books)
            {
                idBook.Items.Add(item.Id);
            }
        }

        private void updateCell(Student student,int index)
        {
            DataGridViewRow row = dataGridView1.Rows[index];
            row.SetValues(student.Id, student.Name, student.ClassName, student.Books.Id, student.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"), int.Parse(quantiTxt.Text));
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                issued.Students[index].Name = studentNameTxt.Text;
                issued.Students[index].ClassName = classNameTxt.Text;
                List<Book> book = manager.FindBook(idBook.SelectedText);
                issued.Students[index].Books = book[0];
                updateCell(issued.Students[index], index);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = (int)e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            studentNameTxt.Text = row.Cells["StudentName"].Value.ToString();
            mssvTxt.Text = row.Cells["MSSV"].Value.ToString();
            classNameTxt.Text = row.Cells["Class"].Value.ToString();
            idBook.Text = row.Cells["ID"].Value.ToString();
            bookNameTxt.Text = row.Cells["bookName"].Value.ToString();
            quantiTxt.Text = row.Cells["Quanti"].Value.ToString();
            string borrowDate = row.Cells["BorrowDate"].Value.ToString();
            string returnDate = row.Cells["ReturnDate"].Value.ToString();
            if (DateTime.TryParseExact(borrowDate,"dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime borrowDay)&&
                DateTime.TryParseExact(returnDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime returnDay))
            {
                dateTimePicker1.Value = borrowDay;
                dateTimePicker2.Value = returnDay;
            }
            else
            {
                MessageBox.Show("The date format is not valid.");
                dateTimePicker1.Value = dateTimePicker1.Value = DateTime.Now; // Đặt giá trị mặc định
            }
        }

        private void extendBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[index];
            row.Cells["ReturnDate"].Value = dateTimePicker2.Value.AddDays(20).ToString("dd/MM/yyyy");
        }

        private void findBt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Student> students = new List<Student>();
            students = issued.FindStudent(id : extendMStxt.Text,bookId : ExtendBookTxt.Text);
            this.addToGrid(students);
        }

        private void Issued_VisibleChanged(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            students = issued.FindStudent(id: extendMStxt.Text, bookId: ExtendBookTxt.Text);
            issued.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\BorrowBook.xml");
        }
    }
}
