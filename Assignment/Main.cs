using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Main : Form
    {
        public static ManageBook manager;
        public Main()
        {
            Login log = new Login();
            log.ShowDialog();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void Main_Load(object sender, EventArgs e)
        {
            manage1.Visible = true;
            find1.Visible = false;
            dashBoard1.Visible = false;
            issued1.Visible = false;
        }

        // Chuyển đổi visible cho các control
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

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 37, 110);
        }
    }
}
