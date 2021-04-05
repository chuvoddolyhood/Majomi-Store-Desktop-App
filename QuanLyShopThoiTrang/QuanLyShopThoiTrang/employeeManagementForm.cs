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
        private DataSet getAllEmployee()
        {
            DataSet data = new DataSet();
            //sqlconnection
            //Sau khi su dung xong se tu huy connection
            //int ID=2;
            //string query = "SELECT * FROM NHANVIEN"+ ID.toString());
            string query = "SELECT * FROM EmpInfo ORDER BY ID ASC;";

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
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM EmpInfo;", connector);
            total = (int)cmd.ExecuteScalar();
            totalEmployeeTextBox.Text = total.ToString();
            connector.Close();
        }

        private void setIDInTheIdButton()
        {
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT MAX(id) FROM EmpInfo", connector);
            string id_temp = (string)cmd.ExecuteScalar(); //Lay ra nhung o dang chuoi(string)
            int id = int.Parse(id_temp)+1; //CHuyen doi sang dang so(int)
            if (id < 10)
            {
                idTextBox.Text = "00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                idTextBox.Text = "0" + id.ToString();
            }
            else idTextBox.Text =  id.ToString();
            connector.Close();
        }

        private void employeeManagementForm_Load(object sender, EventArgs e)
        {
            //Xuat thong tin len bang lon
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllEmployee().Tables[0];

            //Dem so luong nhan vien
            countEmployee();

            //Set up ID
            setIDInTheIdButton();
        }

        private DataSet findEmployee()
        {
            DataSet data2 = new DataSet();
            string queryID = "SELECT * FROM EmpInfo WHERE id=@txtID";
            string queryPhone = "SELECT * FROM EmpInfo WHERE Phone_Number=@txtPhoneNumberFinder";
            string queryName = "SELECT * FROM EmpInfo WHERE Emp_Name=@txtNameFinder";

            using (SqlConnection connector = new SqlConnection(strDatabase))
            {
                connector.Open();
                //sqlCommand
                SqlCommand cmdID = new SqlCommand(queryID, connector);
                SqlCommand cmdPhone = new SqlCommand(queryPhone, connector);
                SqlCommand cmdName = new SqlCommand(queryName, connector);
                cmdID.Parameters.AddWithValue("@txtID", txtIdFinder.Text);
                cmdPhone.Parameters.AddWithValue("@txtPhoneNumberFinder", txtPhoneNumberFinder.Text);
                cmdName.Parameters.AddWithValue("@txtNameFinder", txtNameFinder.Text);
                //sqldataAdapter
                SqlDataAdapter adapterID = new SqlDataAdapter(cmdID);
                SqlDataAdapter adapterPhone = new SqlDataAdapter(cmdPhone);
                SqlDataAdapter adapterName = new SqlDataAdapter(cmdName);
                adapterID.Fill(data2);
                adapterPhone.Fill(data2);
                adapterName.Fill(data2);
                connector.Close();
            }
            return data2;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            //Xuat thong tin len bang nho
            findDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            findDataGridView.DataSource = findEmployee().Tables[0];

            //Xuat thong tin ra cac txt
            printInfoInTheTextBox();
        }

        //Chuyen doi thong tin nhap vao va tim kiem trong CSDL
        private void printInfoInTheTextBox()
        {
            //In thong tin ra tung textbox nho trong groupbox Input Employee lay tu ID
            string getID = txtIdFinder.Text;
            int indexRow = int.Parse(getID)-1; //tri so cot xuat theo tu ID
            showInfoIntoTextBox(indexRow);

            ////In thong tin ra tung textbox nho trong groupbox Input Employee lay tu name
            //string queryGetIDFromName = "SELECT ID FROM EmpInfo WHERE Emp_Name=@name;";
            //connector = new SqlConnection(strDatabase);
            //connector.Open();
            //SqlCommand commandFindIDFromName = new SqlCommand(queryGetIDFromName, connector);
            //commandFindIDFromName.Parameters.AddWithValue("@name", txtNameFinder.Text);
            //showInfoIntoTextBox(indexRow);
        }

        private void btnClearFinder_Click(object sender, EventArgs e)
        {
            txtIdFinder.Clear();
            txtNameFinder.Clear();
            txtPhoneNumberFinder.Clear();
            rdbID.Checked = false;
            rdbName.Checked = false;
            rdbPhoneNumber.Checked = false;
            txtIdFinder.Visible = false;
            txtNameFinder.Visible = false;
            txtPhoneNumberFinder.Visible = false;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap doi tuong");
            }
            else
            {
            //Them du lieu vao table.EmpInfo
            string queryAdd = "INSERT INTO EmpInfo VALUES(@id,@name,@sex,@dob,@address,@phoneNumber,@email,@edu,@language,@workType,@startWorkingDay);";
            //Them du lieu vao table.Employee
            string queryUpdate = "INSERT INTO Employee SELECT I.ID, I.Emp_Name,I.Sex,I.DOB,I.Emp_Address,I.Phone_Number,I.Email, I.Acadamic_Level,L.ID_Language, W.ID_Work,I.Start_Working_Day FROM EmpInfo I JOIN Employee_Language L ON I.Title_Language = L.Title JOIN Work W ON I.Title_Work = W.Title_Work WHERE ID = @id; ";
            connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand commandAdd = new SqlCommand(queryAdd, connector);

            //Thuc thi lenh them du lieu vao bang EmpInfo
            commandAdd.Parameters.AddWithValue("@id",idTextBox.Text);
            commandAdd.Parameters.AddWithValue("@name", nameTextBox.Text);
            commandAdd.Parameters.AddWithValue("@sex", sexComboBox.Text);
            commandAdd.Parameters.AddWithValue("@dob", dateTimePicker.Value);
            commandAdd.Parameters.AddWithValue("@address", addressTextBox.Text);
            commandAdd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
            commandAdd.Parameters.AddWithValue("@email", emailTextBox.Text);
            commandAdd.Parameters.AddWithValue("@edu", acadamicLevelComboBox.Text);
            commandAdd.Parameters.AddWithValue("@language", cmbLanguage.Text);
            commandAdd.Parameters.AddWithValue("@workType", cmbWorkType.Text);
            commandAdd.Parameters.AddWithValue("@startWorkingDay", dtpStartWorkingDay.Value);
            commandAdd.ExecuteNonQuery();

            //Thuc thi lenh update them du lieu vao bang Employee
            SqlCommand commandUpdate = new SqlCommand(queryUpdate, connector);
            commandUpdate.Parameters.AddWithValue("@id", idTextBox.Text);
            commandUpdate.ExecuteNonQuery();

            employeeManagementForm_Load(sender, e);
            btnClearInput_Click(sender, e);
            connector.Close();
            }
        }

        private void delButton_Click(object sender, EventArgs e)
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
                    btnClearInput_Click(sender, e);
                }
                if (dlr == DialogResult.Yes)
                {
                    string queryDeleteTabelEmpInfo = "DELETE EmpInfo WHERE ID=@id;";
                    string queryDeleteTabelEmployee = "DELETE Employee WHERE ID=@id;";

                    connector = new SqlConnection(strDatabase);
                    connector.Open();
                    //Thuc thi tren table.EmpInfo
                    SqlCommand commandDelTabelEmpInfo = new SqlCommand(queryDeleteTabelEmpInfo, connector);
                    commandDelTabelEmpInfo.Parameters.AddWithValue("@id", idTextBox.Text);
                    commandDelTabelEmpInfo.ExecuteNonQuery();

                    //Thuc thi tren table.Emlpoyee
                    SqlCommand commandDelTabelEmployee = new SqlCommand(queryDeleteTabelEmployee, connector);
                    commandDelTabelEmployee.Parameters.AddWithValue("@id", idTextBox.Text);
                    commandDelTabelEmployee.ExecuteNonQuery();

                    employeeManagementForm_Load(sender, e);
                    btnClearInput_Click(sender, e);
                    connector.Close();
                }
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            //Them du lieu vao table.EmpInfo
            string queryAdd = "UPDATE EmpInfo SET Emp_Name='@name', Sex='@sex',DOB='@dob',Emp_Address='@address',Phone_Number='@phoneNumber',Email='@email',Acadamic_Level='@edu',Title_Language='@language',Title_Work='@workType',Start_Working_Day='@startWorkingDay' WHERE ID='@id';";
            //Them du lieu vao table.Employee
            //string queryUpdate = "INSERT INTO Employee SELECT I.ID, I.Emp_Name,I.Sex,I.DOB,I.Emp_Address,I.Phone_Number,I.Email, I.Acadamic_Level,L.ID_Language, W.ID_Work,I.Start_Working_Day FROM EmpInfo I JOIN Employee_Language L ON I.Title_Language = L.Title JOIN Work W ON I.Title_Work = W.Title_Work WHERE ID = @id; ";
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
            commandAdd.Parameters.AddWithValue("@workType", cmbWorkType.Text);
            commandAdd.Parameters.AddWithValue("@startWorkingDay", dtpStartWorkingDay.Value);
            commandAdd.ExecuteNonQuery();

            //Thuc thi lenh update them du lieu vao bang Employee
            //SqlCommand commandUpdate = new SqlCommand(queryUpdate, connector);
            //commandUpdate.Parameters.AddWithValue("@id", idTextBox.Text);
            //commandUpdate.ExecuteNonQuery();

            employeeManagementForm_Load(sender, e);
            btnClearInput_Click(sender, e);
            connector.Close();

        }

        private void btnClearInput_Click(object sender, EventArgs e)
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
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            outputSalary();
        }

        private DataSet outputSalary()
        {
            DataSet dataSalary = new DataSet();
            string querySalary = "SELECT E.Emp_Name, W.Title_Work, W.Salary FROM Employee E JOIN Work W ON E.ID_Work = W.ID_Work; ";

            using (SqlConnection connector = new SqlConnection(strDatabase))
            {
                connector.Open();
                //sqlCommand
                SqlCommand commandAdd = new SqlCommand(querySalary, connector);
                //sqldataAdapter
                SqlDataAdapter adapterSalary = new SqlDataAdapter(commandAdd);
                adapterSalary.Fill(dataSalary);
                connector.Close();
            }
            return dataSalary;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView.CurrentRow.Index;
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
        }

        //Xuat thong tin tu datagridview ra tung textbox
        private void showInfoIntoTextBox(int indexDataGridView)
        {
            int i = indexDataGridView;
            indexDataGridView = dataGridView.CurrentRow.Index;
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
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbID.Checked = true)
            {
                txtIdFinder.Visible = true;
            }
        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbName.Checked = true)
            {
                txtNameFinder.Visible = true;
            }
        }

        private void rdbPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPhoneNumber.Checked = true)
            {
                txtPhoneNumberFinder.Visible = true;
            }
        }

        private void ptbArrowsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menu = new menuForm();
            menu.Show();
        }
    }
}
