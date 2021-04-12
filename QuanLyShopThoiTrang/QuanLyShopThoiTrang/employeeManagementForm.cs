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
    public partial class employeeManagementForm : Form
    {
        string strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = majomiStore; Integrated Security = True";
        SqlConnection connector;

        public employeeManagementForm()
        {
            InitializeComponent();
        }

        private void ptbArrowsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menu = new menuForm();
            menu.Show();
        }

        private DataSet getAllEmployee()
        {
            DataSet data = new DataSet();
            //sqlconnection
            //Sau khi su dung xong se tu huy connection
            //int ID=2;
            //string query = "SELECT * FROM NHANVIEN"+ ID.toString());
            string query = "SELECT E.ID, E.Emp_Name,E.Sex,E.DOB,E.Emp_Address,E.Phone_Number,E.Email,E.Acadamic_Level,E.Language ,W.TitleWork,E.Start_Working_Day, W.Salary, E.Allowance FROM Employee E JOIN Work W ON E.IDWorkType = W.IDWorkType WHERE E.IDWorkType = ANY(SELECT IDWorkType FROM Work) ORDER BY E.ID ASC; ";

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
        private void countEmployee()
        {
            int total;
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Employee;", connector);
            total = (int)cmd.ExecuteScalar();
            totalEmployeeTextBox.Text = total.ToString();
            connector.Close();
        }

        private void setIDInTheIdButton()
        {
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM Employee", connector);
            string id = (string)cmd.ExecuteScalar(); //Lay ra nhung o dang chuoi(string)
            string id_lastNumber = id.Substring(2,3);
            int id_temp = int.Parse(id_lastNumber) +1; //CHuyen doi sang dang so(int)
            if (id_temp < 10)
            {
                idTextBox.Text = "NV00" + id_temp.ToString();
            }
            else if (id_temp >= 10 && id_temp < 100)
            {
                idTextBox.Text = "NV0" + id_temp.ToString();
            }
            else idTextBox.Text =  "NV"+ id_temp.ToString();
            connector.Close();
        }

        private void employeeManagementForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            //Xuat thong tin len bang lon
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllEmployee().Tables[0];

            //Dem so luong nhan vien
            countEmployee();

            //Set up ID
            setIDInTheIdButton();
        }


        //Sau khi bam chon Type work -> tu sinh ID work
        private void cmbWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titelWorkType = cmbWorkType.Text;

            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT IDWorkType FROM Work WHERE TitleWork=@titelWorkType;", connector);
            cmd.Parameters.AddWithValue("@titelWorkType", titelWorkType);
            string idWorkType = (string)cmd.ExecuteScalar(); //Lay ra nhung o dang chuoi(string)
            txtIDWorkType.Text = idWorkType;
            connector.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i= dataGridView.CurrentRow.Index;;
            idTextBox.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
            sexComboBox.Text = dataGridView.Rows[i].Cells[2].Value.ToString();
            dateTimePicker.Text = dataGridView.Rows[i].Cells[3].Value.ToString();
            addressTextBox.Text = dataGridView.Rows[i].Cells[4].Value.ToString();
            txtPhoneNumber.Text = dataGridView.Rows[i].Cells[5].Value.ToString();
            emailTextBox.Text = dataGridView.Rows[i].Cells[6].Value.ToString();
            acadamicLevelComboBox.Text = dataGridView.Rows[i].Cells[7].Value.ToString();
            cmbLanguage.Text = dataGridView.Rows[i].Cells[8].Value.ToString();
            cmbWorkType.Text = dataGridView.Rows[i].Cells[9].Value.ToString();
            dtpStartWorkingDay.Text = dataGridView.Rows[i].Cells[10].Value.ToString();
            txtAllowance.Text = dataGridView.Rows[i].Cells[12].Value.ToString();
        }

        //Chuyen doi thong tin nhap vao va tim kiem trong CSDL
        private void printInfoInTheTextBoxFromIDFinderRadio()
        {
            //In thong tin ra tung textbox nho trong groupbox Input Employee lay tu ID
            string id = txtIdFinder.Text.Substring(2, 3);
            int indexRowDatagridview = int.Parse(id) -1; //tri so cot xuat theo tu ID
            showInfoIntoTextBox(indexRowDatagridview);
        }

        //Xuat thong tin tu datagridview ra tung textbox
        private void showInfoIntoTextBox(int indexRowDatagridview)
        {
            int indexRow = indexRowDatagridview;
            idTextBox.Text = dataGridView.Rows[indexRow].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView.Rows[indexRow].Cells[1].Value.ToString();
            sexComboBox.Text = dataGridView.Rows[indexRow].Cells[2].Value.ToString();
            dateTimePicker.Text = dataGridView.Rows[indexRow].Cells[3].Value.ToString();
            addressTextBox.Text = dataGridView.Rows[indexRow].Cells[4].Value.ToString();
            txtPhoneNumber.Text = dataGridView.Rows[indexRow].Cells[5].Value.ToString();
            emailTextBox.Text = dataGridView.Rows[indexRow].Cells[6].Value.ToString();
            acadamicLevelComboBox.Text = dataGridView.Rows[indexRow].Cells[7].Value.ToString();
            cmbLanguage.Text = dataGridView.Rows[indexRow].Cells[8].Value.ToString();
            cmbWorkType.Text = dataGridView.Rows[indexRow].Cells[9].Value.ToString();
            dtpStartWorkingDay.Text = dataGridView.Rows[indexRow].Cells[10].Value.ToString();
            txtAllowance.Text = dataGridView.Rows[indexRow].Cells[12].Value.ToString();
            dataGridView.Rows[indexRow].Selected = true;
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap doi tuong");
            }
            else
            {
                //Them du lieu vao table.Employee 
                string queryAddEmployee = "INSERT INTO Employee VALUES(@id,@name,@sex,@dob,@address,@phoneNumber,@email,@edu,@language,@idWorkType,@startWorkingDay,@allowance);";
                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                SqlCommand commandAdd = new SqlCommand(queryAddEmployee, connector);

                //Thuc thi lenh them du lieu vao bang EmpInfo
                commandAdd.Parameters.AddWithValue("@id", idTextBox.Text);
                commandAdd.Parameters.AddWithValue("@name", nameTextBox.Text);
                commandAdd.Parameters.AddWithValue("@sex", sexComboBox.Text);
                commandAdd.Parameters.AddWithValue("@dob", dateTimePicker.Value);
                commandAdd.Parameters.AddWithValue("@address", addressTextBox.Text);
                commandAdd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
                commandAdd.Parameters.AddWithValue("@email", emailTextBox.Text);
                commandAdd.Parameters.AddWithValue("@edu", acadamicLevelComboBox.Text);
                commandAdd.Parameters.AddWithValue("@language", cmbLanguage.Text);
                commandAdd.Parameters.AddWithValue("@idWorkType", txtIDWorkType.Text);
                commandAdd.Parameters.AddWithValue("@startWorkingDay", dtpStartWorkingDay.Value);
                commandAdd.Parameters.AddWithValue("@allowance", txtAllowance.Text);
                commandAdd.ExecuteNonQuery();

                employeeManagementForm_Load(sender, e);
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
            if (nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Ban cho chon doi tuong can xoa");
            }
            else
            {
                string name = nameTextBox.Text;
                DialogResult dlr = MessageBox.Show("Ban co chac chan muon xoa " + name + " khoi he thong ko?", "Thông báo",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                if (dlr == DialogResult.No)
                {
                    ptbClear_Click(sender, e);
                }
                if (dlr == DialogResult.Yes)
                {
                    string queryDeleteTabelEmployee = "DELETE Employee WHERE ID=@id;";

                    connector = new SqlConnection(strDatabase);
                    connector.Open();
                    SqlCommand commandDelTabelEmployee = new SqlCommand(queryDeleteTabelEmployee, connector);
                    commandDelTabelEmployee.Parameters.AddWithValue("@id", idTextBox.Text);
                    commandDelTabelEmployee.ExecuteNonQuery();

                    employeeManagementForm_Load(sender, e);
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
            setIDInTheIdButton();
            nameTextBox.Clear();
            sexComboBox.ResetText();
            dateTimePicker.ResetText();
            addressTextBox.Clear();
            txtPhoneNumber.Clear();
            emailTextBox.Clear();
            acadamicLevelComboBox.ResetText();
            cmbLanguage.ResetText();
            cmbWorkType.ResetText();
            dtpStartWorkingDay.ResetText();
            txtIDWorkType.Clear();
            txtAllowance.Clear();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            ptbClear_Click(sender, e);
        }

        private void ptbModify_Click(object sender, EventArgs e)
        {
            //Them du lieu vao table.Employee
            string queryAdd = "UPDATE Employee SET Emp_Name=@name, Sex=@sex,DOB=@dob,Emp_Address=@address,Phone_Number=@phoneNumber,Email=@email,Acadamic_Level=@edu,Language=@language,IDWorkType = @idWorkType,Start_Working_Day=@startWorkingDay,Allowance = @allowance WHERE ID=@id;";

            connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand commandAdd = new SqlCommand(queryAdd, connector);

            //Thuc thi lenh them du lieu vao bang EmpInfo
            commandAdd.Parameters.AddWithValue("@id", idTextBox.Text);
            commandAdd.Parameters.AddWithValue("@name", nameTextBox.Text);
            commandAdd.Parameters.AddWithValue("@sex", sexComboBox.Text);
            commandAdd.Parameters.AddWithValue("@dob", dateTimePicker.Value);
            commandAdd.Parameters.AddWithValue("@address", addressTextBox.Text);
            commandAdd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
            commandAdd.Parameters.AddWithValue("@email", emailTextBox.Text);
            commandAdd.Parameters.AddWithValue("@edu", acadamicLevelComboBox.Text);
            commandAdd.Parameters.AddWithValue("@language", cmbLanguage.Text);
            commandAdd.Parameters.AddWithValue("@IDWorkType", txtIDWorkType.Text);
            commandAdd.Parameters.AddWithValue("@startWorkingDay", dtpStartWorkingDay.Value);
            commandAdd.Parameters.AddWithValue("@allowance", txtAllowance.Text);
            commandAdd.ExecuteNonQuery();

            employeeManagementForm_Load(sender, e);
            ptbClear_Click(sender, e);
            connector.Close();
        }

        private void lblModify_Click(object sender, EventArgs e)
        {
            ptbModify_Click(sender, e);
        }

        private void ptbFinder_Click(object sender, EventArgs e)
        {
            if (txtIdFinder.Text != null)
            {
                printInfoInTheTextBoxFromIDFinderRadio();
            }
            else MessageBox.Show("Ban chua nhap thong tin");
        }

        private void lblFinder_Click(object sender, EventArgs e)
        {
            ptbFinder_Click(sender,e);
        }

        private void ptbClearFinder_Click(object sender, EventArgs e)
        {
            txtIdFinder.Clear();
            
            string id = idTextBox.Text.Substring(2, 3);
            int indexRowDatagridview = int.Parse(id) - 1; //tri so cot xuat theo tu ID
            dataGridView.Rows[indexRowDatagridview].Selected = false;
            ptbClear_Click(sender, e);
        }

        private void lblClearFinder_Click(object sender, EventArgs e)
        {
            ptbClearFinder_Click(sender, e);
        }
    }
}