using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopThoiTrang
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (userName_textBox.Text.Equals("nghia") && passwd_textbox.Text.Equals("nghia123"))
            {
                //MessageBox.Show("Dang nhap thanh cong");
                this.Hide();
                menuForm f = new menuForm();
                f.Show();
            }
            else if (userName_textBox.Text.Equals("nghia") && !passwd_textbox.Text.Equals("nghia123"))
            {
                MessageBox.Show("Sai Mat Khau");
            }
            else MessageBox.Show("Dang nhap khong thanh cong");
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            userName_textBox.Clear();
            passwd_textbox.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passwd_textbox.UseSystemPasswordChar = false;
            
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwd_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwd_textbox.UseSystemPasswordChar = true;
            }
        }

        private void passwd_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button_Click(sender, e);
            }
        }
    }
}
