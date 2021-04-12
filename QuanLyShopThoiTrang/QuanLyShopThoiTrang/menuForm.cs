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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void employeeManagement_Label_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            employeeManagementForm em = new employeeManagementForm();
            em.Show();
        }

        private void customerManagement_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerManagementForm customer = new customerManagementForm();
            customer.Show();
        }

        private void productManagement_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            productManagement customer = new productManagement();
            customer.Show();
        }

        private void invoices_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice customer = new Invoice();
            customer.Show();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void productManagement_Label_MouseHover(object sender, EventArgs e)
        {
            productManagement_Label.Font = new Font(" ", 32, FontStyle.Italic);
            //BackColor = Color.Red;
            BackgroundImage = Properties.Resources.product;
        }

        private void employeeManagement_Label_MouseHover(object sender, EventArgs e)
        {
            employeeManagement_Label.Font = new Font(" ", 32, FontStyle.Italic);
             //BackColor = Color.AntiqueWhite;
            BackgroundImage = Properties.Resources.employee;
        }

        private void customerManagement_Label_MouseHover(object sender, EventArgs e)
        {
            customerManagement_Label.Font = new Font(" ", 32, FontStyle.Italic);
           //BackColor = Color.Blue;
            BackgroundImage = Properties.Resources.customer;
        }

        private void invoices_Label_MouseHover(object sender, EventArgs e)
        {
            invoices_Label.Font = new Font(" ", 32, FontStyle.Italic);
            BackgroundImage = Properties.Resources.sales;
        }

        private void productManagement_Label_MouseLeave(object sender, EventArgs e)
        {
            productManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //BackColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
        }

        private void employeeManagement_Label_MouseLeave(object sender, EventArgs e)
        {
            employeeManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //BackColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
        }

        private void customerManagement_Label_MouseLeave(object sender, EventArgs e)
        {
            customerManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //BackColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
        }

        private void invoices_Label_MouseLeave(object sender, EventArgs e)
        {
            invoices_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //BackColor = Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
        }
    }
}
