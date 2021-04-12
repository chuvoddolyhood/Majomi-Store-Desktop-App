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
    public partial class customerManagementForm : Form
    {
        string strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = majomiStore; Integrated Security = True";
        public customerManagementForm()
        {
            InitializeComponent();
        }

        private void ptbArrowsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menu = new menuForm();
            menu.Show();
        }

        private DataSet getAllCustomer()
        {
            DataSet data = new DataSet();
            //sqlconnection
            //Sau khi su dung xong se tu huy connection
            string query = "SELECT * FROM Customer ORDER BY ID_Customer ASC;";

            using (SqlConnection connection = new SqlConnection(strDatabase))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                //sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void countCustomer()
        {
            int total;
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Customer;", connector);
            total = (int)cmd.ExecuteScalar();
            txtTotalCustomer.Text = total.ToString();
            connector.Close();
        }

        private void setIDInTheIdButton()
        {
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Customer) FROM Customer", connector);
            string id_temp = (string)cmd.ExecuteScalar(); //Lay ra nhung o dang chuoi(string)
            string getTheLastNumberOfID = id_temp.Substring(2, 3); //Lay ky tu 3 so cuoi cung
            int id = int.Parse(getTheLastNumberOfID) + 1; //CHuyen doi sang dang so(int)
            if (id < 10)
            {
                txtID.Text = "KH" + "00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                txtID.Text = "KH" + "0" + id.ToString();
            }
            else txtID.Text = "KH" + id.ToString();
            connector.Close();
        }

        private void customerManagementForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            //Xuat thong tin len bang lon
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllCustomer().Tables[0];

            //Dem so luong nhan vien
            countCustomer();

            //Set up ID
            setIDInTheIdButton();
        }


        //Bam vo 1 dong trong datagridview thi tu hien thi ra tung textbox
        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView.CurrentRow.Index;
            txtID.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
            txtNameCustomer.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
            txtPhoneNumberCustomer.Text = dataGridView.Rows[i].Cells[2].Value.ToString();
        }

        private void showInfoIntoTextBox(int indexRowDatagridview)
        {
            int indexRow = indexRowDatagridview;
            txtID.Text = dataGridView.Rows[indexRow].Cells[0].Value.ToString();
            txtNameCustomer.Text = dataGridView.Rows[indexRow].Cells[1].Value.ToString();
            txtPhoneNumberCustomer.Text = dataGridView.Rows[indexRow].Cells[2].Value.ToString();
            dataGridView.Rows[indexRow].Selected = true;
        }


        //Ham ho tro button finer de goi toi in thong tin ra cac textbox
        //vi ham tren co event e ko su dung duoc
        private void dataGridView_CellContentClick(int index)
        {
            index = dataGridView.CurrentRow.Index;
            txtID.Text = dataGridView.Rows[index].Cells[0].Value.ToString();
            txtNameCustomer.Text = dataGridView.Rows[index].Cells[1].Value.ToString();
            txtPhoneNumberCustomer.Text = dataGridView.Rows[index].Cells[2].Value.ToString();
            
            //To sang o trong datagridview khi duoc tim
            dataGridView.Rows[index].Selected = true;
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap doi tuong");
            }
            else
            {
                //Them du lieu vao table.EmpInfo
                string queryAdd = "INSERT INTO Customer VALUES (@id,@name,@phoneNumber);";
                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                SqlCommand commandAdd = new SqlCommand(queryAdd, connector);

                //Thuc thi lenh them du lieu vao bang EmpInfo
                commandAdd.Parameters.AddWithValue("@id", txtID.Text);
                commandAdd.Parameters.AddWithValue("@name", txtNameCustomer.Text);
                commandAdd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumberCustomer.Text);
                commandAdd.ExecuteNonQuery();

                customerManagementForm_Load(sender, e);
                ptbClear_Click(sender, e);
                connector.Close();
            }
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            ptbAdd_Click(sender, e);
        }

        private void ptbDel_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text.Equals(""))
            {
                MessageBox.Show("Ban chua chon doi tuong can xoa");
            }
            else
            {
                string name = txtNameCustomer.Text;
                DialogResult dlr = MessageBox.Show("Ban co chac chan muon xoa " + name + " khoi he thong ko?", "Thông báo",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                if (dlr == DialogResult.No)
                {
                    ptbClear_Click(sender, e);
                }
                if (dlr == DialogResult.Yes)
                {
                    string queryDeleteTabelCustomer = "DELETE Customer WHERE ID_Customer=@id;";

                    SqlConnection connector = new SqlConnection(strDatabase);
                    connector.Open();
                    //Thuc thi tren table.EmpInfo
                    SqlCommand commandDelTabelCustomer = new SqlCommand(queryDeleteTabelCustomer, connector);
                    commandDelTabelCustomer.Parameters.AddWithValue("@id", txtID.Text);
                    commandDelTabelCustomer.ExecuteNonQuery();

                    customerManagementForm_Load(sender, e);
                    ptbClear_Click(sender, e);
                    connector.Close();
                }
            }
        }

        private void lblDel_Click(object sender, EventArgs e)
        {
            ptbDel_Click(sender, e);
        }

        private void ptbClear_Click(object sender, EventArgs e)
        {
            txtNameCustomer.Clear();
            txtPhoneNumberCustomer.Clear();
            setIDInTheIdButton();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            ptbClear_Click(sender, e);
        }

        private void ptbModify_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap doi tuong");
            }
            else
            {
                string queryModify = "UPDATE Customer SET Name_Customer=@name, PhoneNumber_Customer=@phoneNumber WHERE ID_Customer=@id;";
                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                SqlCommand commandModify = new SqlCommand(queryModify, connector);

                commandModify.Parameters.AddWithValue("@id", txtID.Text);
                commandModify.Parameters.AddWithValue("@name", txtNameCustomer.Text);
                commandModify.Parameters.AddWithValue("@phoneNumber", txtPhoneNumberCustomer.Text);
                commandModify.ExecuteNonQuery();

                customerManagementForm_Load(sender, e);
                ptbClear_Click(sender, e);
                connector.Close();
            }
        }

        private void lblModify_Click(object sender, EventArgs e)
        {
            ptbModify_Click(sender, e);
        }

        private void ptbFinder_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumberFinder.Text != null)
            {
                //In thong tin ra tung textbox nho trong groupbox Input Employee lay tu ID
                string query = "SELECT ID_Customer FROM Customer WHERE PhoneNumber_Customer=@phoneNumber;";
                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                SqlCommand command = new SqlCommand(query, connector);
                command.Parameters.AddWithValue("@phoneNumber", txtPhoneNumberFinder.Text);
                string id = (string)command.ExecuteScalar();
                string id_number = id.Substring(2, 3);
                int indexRowDatagridview = int.Parse(id_number) - 1; //tri so cot xuat theo tu ID
                showInfoIntoTextBox(indexRowDatagridview);
            }
            else MessageBox.Show("Ban chua nhap thong tin tim kiem");
        }

        private void lblFinder_Click(object sender, EventArgs e)
        {
            ptbFinder_Click(sender, e);
        }
    }
}