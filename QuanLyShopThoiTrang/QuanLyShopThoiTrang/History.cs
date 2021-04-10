using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyShopThoiTrang
{
    public partial class History : Form
    {

        string strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = majomiStore; Integrated Security = True";
        public History()
        {
            InitializeComponent();
        }

        private DataSet getAllCustomerFollowPhoneNumber()
        {
            DataSet data = new DataSet();
            string query = "SELECT I.ID_Invoice,I.Invoice_Day,C.ID_Customer,C.Name_Customer,I.ID_Product,I.Quantity_Product,I.UnitPrice,I.GrandTotal FROM Invoice I JOIN Customer C ON I.ID_Customer = C.ID_Customer WHERE C.Name_Customer = @name ORDER BY I.ID_Invoice ASC; ";

            using (SqlConnection connection = new SqlConnection(strDatabase))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txtNameCustomer.Text);
                //sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Xuat thong tin len bang lon
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllCustomerFollowPhoneNumber().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
