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
    public partial class DashBoard : UserControl
    {
        private ManageBook manager;
        public DashBoard()
        {
            InitializeComponent();
        }

        private void makeCount(ManageBook manager)
        {
            try
            {
                GiaoTrinhlb.Text = (manager.FindBook(category: "Giáo trình").Count()).ToString();
                thamKhaolb.Text = (manager.FindBook(category: "Sách tham khảo").Count()).ToString();
                doAnlb.Text = manager.FindBook(category: "Đồ án ngành").Count().ToString();
                baoTapChi.Text = manager.FindBook(category: "Báo - Tạp chí").Count().ToString();
                khoaLuanlb.Text = manager.FindBook(category: "Khóa luận").Count().ToString();
                luanVanlb.Text = manager.FindBook(category: "Luận văn").Count().ToString();
            }
            catch { }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            manager = new ManageBook();
            List<Book> books = manager.ReadFromFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
            manager.Books = books;
            makeCount(manager);
        }

        private void DashBoard_VisibleChanged(object sender, EventArgs e)
        {
            makeCount(manager);
        }
    }
}
