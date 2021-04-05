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

        private void optionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optionsComboBox.SelectedItem.Equals("Log out"))
            {
                this.Hide();
                loginForm login = new loginForm();
                login.Show();
            }
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
    }
}
