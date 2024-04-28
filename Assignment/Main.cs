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
        public static ManageBook manager;
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
            manage1.Visible = true;
            find1.Visible = false;
            dashBoard1.Visible = false;
            issued1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manage1.Visible = true;
            find1.Visible = false;
            dashBoard1.Visible = false;
            issued1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage1.Visible = false;
            find1.Visible = true;
            dashBoard1.Visible = false;
            issued1.Visible = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            manage1.Visible = false;
            find1.Visible = false;
            dashBoard1.Visible = true;
            issued1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manage1.Visible = false;
            find1.Visible = false;
            dashBoard1.Visible = false;
            issued1.Visible = true;
        }
    }
}
