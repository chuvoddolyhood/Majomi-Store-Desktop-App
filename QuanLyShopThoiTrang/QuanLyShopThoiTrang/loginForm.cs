using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopThoiTrang
{
    public partial class loginForm : Form
    {
        string strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = majomiStore; Integrated Security = True";
        public loginForm()
        {
            InitializeComponent();
        }

        //Kiem tra thong tin nhap day du hay ko
        private bool confirmInfo()
        {
            bool check = true;
            if (passwd_textbox.Text.Equals(""))
            {
                MessageBox.Show("Chua nhap mat khau");
                check = false;
            }
            else if (userName_textBox.Text.Equals("") == true)
            {
                MessageBox.Show("Chua nhap Ten dang nhap");
                check = false;
            }
            return check;
        }

        private string getPasswordDTB;
        private bool isPasswordCorrect()
        {
            bool isCorrect = false;
            String passwordFromDatabase;

            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand cmd = new SqlCommand("SELECT User_Password FROM Account WHERE UserName=@username;", connector);
            cmd.Parameters.AddWithValue("@username", userName_textBox.Text);
            passwordFromDatabase = (string)cmd.ExecuteScalar();
            if (passwordFromDatabase.Equals("") == false)
            {
                if (passwd_textbox.Text.Equals(passwordFromDatabase)) {
                    isCorrect = true;
                    getPasswordDTB = passwordFromDatabase;
                }
                else
                {
                    isCorrect = false;
                    MessageBox.Show("Sai mat khau");
                }
                    
            }
            connector.Close();

            return isCorrect;
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if (confirmInfo() == true)
            {
                if (isPasswordCorrect() == true)
                {
                    String idWorkType;
                    SqlConnection connector = new SqlConnection(strDatabase);
                    connector.Open();
                    SqlCommand cmd = new SqlCommand("SELECT IDWorkType FROM Account A JOIN Employee E ON A.ID=E.ID WHERE UserName=@username AND User_Password=@userpass", connector);
                    cmd.Parameters.AddWithValue("@username", userName_textBox.Text);
                    cmd.Parameters.AddWithValue("@userpass", getPasswordDTB);
                    idWorkType = (string)cmd.ExecuteScalar();
                    if (idWorkType.Equals("CV01"))
                    {
                        menuForm f = new menuForm();
                        f.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Ban khong phai admin");

                    connector.Close();
                }
            }
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
