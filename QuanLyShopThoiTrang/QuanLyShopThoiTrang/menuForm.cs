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
            employeeManagement_Label.Font= new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoices_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //BackColor = Color.Red;
            BackgroundImage = global::QuanLyShopThoiTrang.Properties.Resources.product;
        }

        private void employeeManagement_Label_MouseHover(object sender, EventArgs e)
        {
            employeeManagement_Label.Font = new Font(" ", 32, FontStyle.Italic);
            customerManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoices_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //BackColor = Color.AntiqueWhite;
            BackgroundImage = global::QuanLyShopThoiTrang.Properties.Resources.employee;
        }

        private void customerManagement_Label_MouseHover(object sender, EventArgs e)
        {
            customerManagement_Label.Font = new Font(" ", 32, FontStyle.Italic);
            productManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoices_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //BackColor = Color.Blue;
            BackgroundImage = global::QuanLyShopThoiTrang.Properties.Resources.customer;
        }

        private void invoices_Label_MouseHover(object sender, EventArgs e)
        {
            invoices_Label.Font = new Font(" ", 32, FontStyle.Italic);
            customerManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //BackColor = Color.White;
            BackgroundImage = global::QuanLyShopThoiTrang.Properties.Resources.sales;
        }
    }
}
