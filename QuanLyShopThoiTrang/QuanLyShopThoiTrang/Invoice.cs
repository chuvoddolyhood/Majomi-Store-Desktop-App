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
using System.IO;

namespace QuanLyShopThoiTrang
{
    public partial class Invoice : Form
    {
        string strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = majomiStore; Integrated Security = True";
        public Invoice()
        {
            InitializeComponent();
        }

        private void ptbArrowsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menu = new menuForm();
            menu.Show();
        }

        private string setIDInTheIdButton()
        {
            string printIDInvoice;
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Invoice) FROM INVOICE;", connector);
            string id_temp = (string)cmd.ExecuteScalar(); //Lay ra nhung o dang chuoi(string)
            string getTheLastNumberOfID = id_temp.Substring(2, 3); //Lay ky tu 3 so cuoi cung
            int id = int.Parse(getTheLastNumberOfID) + 1; //CHuyen doi sang dang so(int)
            if (id < 10)
            {
                printIDInvoice = "HD" + "00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                printIDInvoice = "HD" + "0" + id.ToString();
            }
            else printIDInvoice = "HD" + id.ToString();
            connector.Close();
            return printIDInvoice;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            //auto setup ID
            txtIDInvoice.Text= setIDInTheIdButton();
            txtIDInvoiceDataGridView.Text= setIDInTheIdButton();
        }

        private void setTitleProductInTheTitleButton()
        {
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT Title_Product FROM Product WHERE ID_Product=@idProduct;", connector);
            cmd.Parameters.AddWithValue("@idProduct", txtIDProduct.Text);
            string titleProduct = (string)cmd.ExecuteScalar(); //Lay ra nhung o dang chuoi(string)
            txtTitleProduct.Text = titleProduct;
            connector.Close();
        }

        private void setUnitPriceInTheButton()
        {
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT UnitPrice FROM Product WHERE ID_Product=@idProduct;", connector);
            cmd.Parameters.AddWithValue("@idProduct", txtIDProduct.Text);
            int costProduct= Convert.ToInt32(cmd.ExecuteScalar());
            txtUnitPrice.Text = costProduct.ToString();
            connector.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            setTitleProductInTheTitleButton();
            setUnitPriceInTheButton();
        }

        private void txtIDProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setTitleProductInTheTitleButton();
                setUnitPriceInTheButton();
            }
        }
        
        private DataSet getAllProduct()
        {
            DataSet data = new DataSet();
            string query = "SELECT I.ID_Product,P.Title_Product, Quantity_Product,I.UnitPrice,I.GrandTotal,P.Image_Product FROM INVOICE I JOIN Product P ON I.ID_Product = P.ID_Product WHERE I.ID_Invoice = @idInvoice;";

            using (SqlConnection connection = new SqlConnection(strDatabase))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idInvoice",txtIDInvoice.Text);
                //sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void loadProductToDataGridView()
        {
            //Xuat thong tin len bang lon
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.DataSource = getAllProduct().Tables[0];
        }

        private DataSet getAllCustomerFollowPhoneNumber()
        {
            DataSet data = new DataSet();
            string query = "SELECT * FROM Customer WHERE PhoneNumber_Customer=@phoneNumber;";

            using (SqlConnection connection = new SqlConnection(strDatabase))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@phoneNumber",txtPhoneNumberCustomer.Text);
                //sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void loadCustomerToDataGridView()
        {
            //Xuat thong tin len bang lon
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.DataSource = getAllCustomerFollowPhoneNumber().Tables[0];
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            loadCustomerToDataGridView();
        }

        //Dem so luong hang hoa them vao
        private void countProduct()
        {
            int total;
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM INVOICE WHERE ID_Invoice=@idInvoice;", connector);
            cmd.Parameters.AddWithValue("@idInvoice",txtIDInvoiceDataGridView.Text);
            total = (int)cmd.ExecuteScalar();
            txtTotalProduct.Text = total.ToString();
            connector.Close();
        }

        //private int discount; //Luu gia tri discount

        //Tinh tong tien
        private int grandTotal() =>  int.Parse(txtUnitPrice.Text) * int.Parse(txtQuantity.Text);
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            if (txtTitleProduct.Text.Equals(""))
                MessageBox.Show("Ban chua nhap doi tuong");

            else
            {
                string queryAdd = "INSERT INTO INVOICE VALUES(@idInvoice,@date,@idCustomer,@idProduct,@quantity,@unitPrice,@grandTotal);";
                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                SqlCommand commandAdd = new SqlCommand(queryAdd, connector);

                commandAdd.Parameters.AddWithValue("@idInvoice", txtIDInvoiceDataGridView.Text);
                commandAdd.Parameters.AddWithValue("@date", dateTimePicker.Value);
                commandAdd.Parameters.AddWithValue("@idCustomer", txtIDCustomerDGV.Text);
                commandAdd.Parameters.AddWithValue("@idProduct", txtIDProduct.Text);
                commandAdd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                commandAdd.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
                commandAdd.Parameters.AddWithValue("@grandTotal", grandTotal().ToString());
                commandAdd.ExecuteNonQuery();

                loadProductToDataGridView();
                countProduct();
                btnClearProduct_Click(sender, e);
                connector.Close();
            }
        }

        private string IDCustomer; //Lay ID trong DatagridviewCustomer
        //private int markOfReward;//Lay diem thuong tich luy trong DatagridviewCustomer
        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i= dataGridViewCustomer.CurrentRow.Index;
            IDCustomer = dataGridViewCustomer.Rows[i].Cells[0].Value.ToString();
            txtNameCustomer.Text = dataGridViewCustomer.Rows[i].Cells[1].Value.ToString();
            //string getMarkOfReward = dataGridViewCustomer.Rows[i].Cells[3].Value.ToString();
            //markOfReward = int.Parse(getMarkOfReward);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            txtNameCustomerDGV.Text = txtNameCustomer.Text;
            txtIDCustomerDGV.Text = IDCustomer;

            //In label discount
            //if (markOfReward < 15)
            //    lblShowDiscount.Visible = false;
            //else if (markOfReward >= 15 && markOfReward < 20)
            //{
            //    lblShowDiscount.Visible = true;
            //    lblShowDiscount.Text = "Khách hàng nhận được discount giảm giá 15000đ";
            //    btnUseDiscount.Visible = true;
            //}
            //else if (markOfReward >= 20)
            //{
            //    lblShowDiscount.Visible = true;
            //    lblShowDiscount.Text = "Khách hàng nhận được discount giảm giá 20000đ";
            //    btnUseDiscount.Visible = true;
            //}
        }

        //private void btnUseDiscount_Click(object sender, EventArgs e)
        //{
        //    if (markOfReward < 15)
        //        discount = 0;
        //    if (markOfReward >= 15 && markOfReward < 20)
        //    {
        //        DialogResult dlr = MessageBox.Show("Sử dụng discount giảm giá 15000 ", "Thông báo",
        //                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
        //        if (dlr == DialogResult.No)
        //        {
        //            //txtShowDiscount.Visible = false;
        //        }
        //        if (dlr == DialogResult.Yes)
        //        {
        //            discount = 15000;
        //            MessageBox.Show("Da su dung "+discount);
        //        }
        //    }
        //    if (markOfReward >= 20)
        //    {
        //        DialogResult dlr = MessageBox.Show("Sử dụng discount giảm giá 20000 ", "Thông báo",
        //                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
        //        if (dlr == DialogResult.No)
        //        {
        //            //txtShowDiscount.Visible = false;
        //        }
        //        if (dlr == DialogResult.Yes)
        //        {
        //            discount = 20000;
        //            MessageBox.Show("Da su dung " + discount);
        //        }
        //    }
        //}

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            txtIDProduct.Clear();
            txtTitleProduct.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtIDInvoice.Text = setIDInTheIdButton();
            txtIDInvoiceDataGridView.Text = setIDInTheIdButton();
            btnClearProduct_Click(sender, e);
            txtPhoneNumberCustomer.Clear();
            ((DataTable)dataGridViewProduct.DataSource).Rows.Clear();
            ((DataTable)dataGridViewCustomer.DataSource).Rows.Clear();
            txtNameCustomer.Clear();
            txtNameCustomerDGV.Clear();
            txtIDCustomerDGV.Clear();
            txtTotalProduct.Text = "0";
            txtCost.Clear();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            string querySumMoney = "SELECT SUM(GrandTotal) FROM Invoice WHERE ID_Invoice=@idInvoice;";

            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand commandAdd = new SqlCommand(querySumMoney, connector);

            commandAdd.Parameters.AddWithValue("@idInvoice", txtIDInvoiceDataGridView.Text);
            int costSum = Convert.ToInt32(commandAdd.ExecuteScalar());
            txtCost.Text = costSum.ToString();
            connector.Close();
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }
    }
}
