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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userTxt.Text == "" || passTxt.Text != "123456" || userTxt.Text != "admin")
            {
                warningLb.Text = "* Vui lòng nhập đúng tài khoản mật khẩu";
                return;
            }
            this.Close();
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            warningLb.Text = "";
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            warningLb.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passTxt.PasswordChar = (checkBox1.Checked) ? '\0' : '*';
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = SystemColors.Control;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(27, 74, 168);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 37, 110);
        }
    }
}
