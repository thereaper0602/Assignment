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
    public partial class Main : Form
    {
        private ManageBook manager = new ManageBook();
        public Main()
        {
            //Login log = new Login();
            //log.ShowDialog();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //manage1.Visible = true;
            //find1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //manage1.Visible = true;
            //find1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //manage1.Visible = false;
            //find1.Visible = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            manager.SaveToFile("D:\\Y2S2\\GUI\\Assignment\\Assignment\\Assignment\\Books.xml");
        }
    }
}
