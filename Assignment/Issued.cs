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
        ManageBook manager;
        IssuedBook issued;
        int index;
        public Issued()
        {
            InitializeComponent();
        }

        private void addToGrid1(Student student)
        {
            int idx = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[idx];
            newRow.SetValues(student.Id, student.Name, student.ClassName, student.Books.Id, student.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"), quantiTxt.Text);
        }

        private void addToGrid1(List<Student> student)
        {
            foreach(Student s in student)
            {
               int idx = dataGridView1.Rows.Add();
               DataGridViewRow newRow = dataGridView1.Rows[idx];
               newRow.SetValues(s.Id, s.Name, s.ClassName, s.Books.Id, s.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"),s.Quanti.ToString());
            }
        }

        private void addToGrid2(Student s)
        {
             int idx = dataGridView2.Rows.Add();
             DataGridViewRow newRow = dataGridView2.Rows[idx];
             newRow.SetValues(s.Id, s.Name, s.ClassName, s.Books.Id, s.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"), s.Quanti.ToString());
        }

        private void addToGrid2(List<Student> student)
        {
            foreach (Student s in student)
            {
                int idx = dataGridView2.Rows.Add();
                DataGridViewRow newRow = dataGridView2.Rows[idx];
                newRow.SetValues(s.Id, s.Name, s.ClassName, s.Books.Id, s.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"), s.Quanti.ToString());
            }
        }


        private void addBt_Click(object sender, EventArgs e)
        {
            try
            {
                List<Book> book = manager.FindBook(idBook.SelectedItem.ToString());
                List<Student> s = issued.FindStudent(id : mssvTxt.Text);
                if(issued.countBook(s) > 3)
                {
                    MessageBox.Show("Sinh viên không được mượn quá 3 cuốn sách");
                }
                if (int.Parse(quantiTxt.Text) > 3)
                {
                    MessageBox.Show("Mỗi sinh viên chỉ được mượn tối đa 3 cuốn");
                }
                if(int.Parse(quantiTxt.Text) >= book[0].Quanti)
                {
                    MessageBox.Show("Số lượng sách không đủ");
                }
                else
                {
                    Student student = new Student(mssvTxt.Text, studentNameTxt.Text, classNameTxt.Text, book[0], int.Parse(quantiTxt.Text));
                    issued.addStudent(student);
                    this.addToGrid2(student);
                    this.addToGrid1(student);
                    issued.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\BorrowBook.xml");
                    mssvTxt.Text = studentNameTxt.Text = classNameTxt.Text = bookNameTxt.Text = quantiTxt.Text = idBook.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void Issued_Load(object sender, EventArgs e)
        {
            manager = new ManageBook();
            issued = new IssuedBook();
            manager.Books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
            issued.Students = issued.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\BorrowBook.xml");
            foreach (var item in manager.Books)
            {
                idBook.Items.Add(item.Id);
            }
            this.addToGrid1(issued.Students);
            this.addToGrid2(issued.Students);
        }

        private void updateCell(Student student,int index)
        {
            DataGridViewRow row = dataGridView1.Rows[index];
            row.SetValues(student.Id, student.Name, student.ClassName, student.Books.Id, student.Books.Title, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.AddDays(20).ToString("dd/MM/yyyy"), int.Parse(quantiTxt.Text));
            issued.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\BorrowBook.xml");
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                issued.Students[index].Name = studentNameTxt.Text;
                issued.Students[index].ClassName = classNameTxt.Text;
                issued.Students[index].Id = mssvTxt.Text;
                List<Book> book = manager.FindBook(idBook.SelectedItem.ToString());
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
            this.addToGrid1(students);
        }

        private void Issued_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                dataGridView1.Rows.Clear();
                manager.Books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
                issued.Students = issued.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\BorrowBook.xml");
                foreach (var item in manager.Books)
                {
                    idBook.Items.Add(item.Id);
                }
                this.addToGrid1(issued.Students);
            }
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            this.addToGrid1(issued.Students);
        }

        private void returnOneBt_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.Clear();
                dataGridView1.Rows.Clear();
                Student s = issued.FindStudent(id : returnIDtxt.Text,bookId : returnBookTxt.Text)[0];
                issued.removeStudent(s);
                this.addToGrid2(issued.Students);
                this.addToGrid1(issued.Students);
                issued.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\BorrowBook.xml");
            }
        }

        private void findInfoBt_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            List<Student> students = issued.FindStudent(id : returnIDtxt.Text, bookId: returnBookTxt.Text);
            this.addToGrid2(students);
        }

        private void returnAllBt_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            List<Student> s = issued.FindStudent(id: returnIDtxt.Text, bookId: returnBookTxt.Text);
            issued.removeStudent(s);
            this.addToGrid2(issued.Students);
            this.addToGrid1(issued.Students);
            issued.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\BorrowBook.xml");
        }
    }
}
