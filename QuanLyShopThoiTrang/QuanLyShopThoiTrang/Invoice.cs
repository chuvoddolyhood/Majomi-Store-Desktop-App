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
using iTextSharp.text.pdf;
using iTextSharp.text;

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

        private string setIDInvoiceInTheIdButton()
        {
            string printIDInvoice;
            try
            {
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
            }
            catch (Exception)
            {
                printIDInvoice="HD000";
            }
            return printIDInvoice;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            //auto setup ID
            txtIDInvoice.Text = setIDInvoiceInTheIdButton();
            txtIDInvoiceDataGridView.Text = setIDInvoiceInTheIdButton();

            //Xuat thong tin len bang lon
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.DataSource = getAllProduct().Tables[0];

            setIDInvoiceInTheIdButton();
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

        private void txtQuantity_Click(object sender, EventArgs e)
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
            if (!txtPhoneNumberCustomer.Text.Equals(""))
                loadCustomerToDataGridView();
            else MessageBox.Show("Vui long nhap so dien thoai khach hang");
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

        private string getIDProduct()
        {
            int i = int.Parse(txtTotalProduct.Text) - 1; //Lay gia tri hang(row) cua bang dataGridView
            string IDProduct = dataGridViewProduct.Rows[i].Cells[0].Value.ToString();
            return IDProduct;
        }

        private string getQuantityProduct()
        {
            int i = int.Parse(txtTotalProduct.Text) - 1; //Lay gia tri hang(row) cua bang dataGridView
            string IDProduct = dataGridViewProduct.Rows[i].Cells[2].Value.ToString();
            return IDProduct;
        }

        private int updateAmount;//Cap nhat so luong con lai sau khi mua hang
        private void updateAmountProduct()
        {
            string queryAmount = "SELECT Amount_Product FROM Product WHERE ID_Product=@idProduct;";
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand commandGetAmount = new SqlCommand(queryAmount, connector);

            commandGetAmount.Parameters.AddWithValue("@idProduct", getIDProduct());
            int amountProduct = Convert.ToInt32(commandGetAmount.ExecuteScalar()); //lay so luong trong kho
            updateAmount = amountProduct - int.Parse(getQuantityProduct()); //Cap nhat so luong con lai sau khi mua hang

            //Co BUG van ko tru duoc so hang sau khi mua
            string queryUpdateAmountInTheProductTable = "UPDATE Product SET Amount_Product=7 WHERE ID_Product=@idProduct;";
            SqlCommand commandUpdate = new SqlCommand(queryUpdateAmountInTheProductTable, connector);
            //commandUpdate.Parameters.AddWithValue("@updateAmountProduct", updateAmountProduct);
            commandUpdate.Parameters.AddWithValue("@idProduct", getIDProduct());
            connector.Close(); 
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

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            txtIDInvoice.Text = setIDInvoiceInTheIdButton();
            txtIDInvoiceDataGridView.Text = setIDInvoiceInTheIdButton();
            ptbClear_Click(sender, e);
            txtPhoneNumberCustomer.Clear();
            ((DataTable)dataGridViewProduct.DataSource).Rows.Clear();
            ((DataTable)dataGridViewCustomer.DataSource).Rows.Clear();
            txtNameCustomer.Clear();
            txtNameCustomerDGV.Clear();
            txtIDCustomerDGV.Clear();
            txtTotalProduct.Text = "0";
            txtCost.Clear();
        }

        private void ptbAddCustomer_Click(object sender, EventArgs e)
        {
            txtNameCustomerDGV.Text = txtNameCustomer.Text;
            txtIDCustomerDGV.Text = IDCustomer;
        }

        //Tinh tong tien
        private int grandTotal() => int.Parse(txtUnitPrice.Text) * int.Parse(txtQuantity.Text);

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            if (txtTitleProduct.Text.Equals(""))
                MessageBox.Show("Ban chua nhap doi tuong");
            else
            {
                try
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
                    updateAmountProduct();
                    ptbClear_Click(sender, e);
                    connector.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi thong tin. Vui long kiem tra lai");
                }
            }
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            ptbAdd_Click(sender, e);
        }

        private void ptbModify_Click(object sender, EventArgs e)
        {
            if (txtTitleProduct.Text.Equals(""))
                MessageBox.Show("Ban chua nhap doi tuong");
            else
            {
                try
                {
                    string queryAdd = "UPDATE Invoice SET Quantity_Product=@quantity, GrandTotal=@grandTotal WHERE ID_Invoice=@idInvoice AND ID_Customer=@idCustomer AND ID_Product=@idProduct;";
                    SqlConnection connector = new SqlConnection(strDatabase);
                    connector.Open();
                    SqlCommand commandAdd = new SqlCommand(queryAdd, connector);

                    commandAdd.Parameters.AddWithValue("@idInvoice", txtIDInvoice.Text);
                    commandAdd.Parameters.AddWithValue("@idCustomer", txtIDCustomerDGV.Text);
                    commandAdd.Parameters.AddWithValue("@idProduct", txtIDProduct.Text);
                    commandAdd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    commandAdd.Parameters.AddWithValue("@grandTotal", grandTotal().ToString());
                    commandAdd.ExecuteNonQuery();

                    loadProductToDataGridView();
                    countProduct();
                    updateAmountProduct();
                    ptbClear_Click(sender, e);
                    connector.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi thong tin. Vui long kiem tra lai");
                }
            }
        }

        private void lblModify_Click(object sender, EventArgs e)
        {
            ptbModify_Click(sender, e);
        }

        private void ptbClear_Click(object sender, EventArgs e)
        {
            txtIDProduct.Clear();
            txtTitleProduct.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            ptbClear_Click(sender, e);
        }

        private void ptbDel_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text.Equals(""))
            {
                MessageBox.Show("Ban chua chon doi tuong can xoa");
            }
            else
            {
                try
                {
                    string queryDel = "DELETE Invoice WHERE ID_Invoice = @idInvoice AND ID_Customer = @idCustomer AND ID_Product = @idProduct;";

                    SqlConnection connector = new SqlConnection(strDatabase);
                    connector.Open();
                    SqlCommand commandDelTabelCustomer = new SqlCommand(queryDel, connector);
                    commandDelTabelCustomer.Parameters.AddWithValue("@idInvoice", txtIDInvoice.Text);
                    commandDelTabelCustomer.Parameters.AddWithValue("@idCustomer", txtIDCustomerDGV.Text);
                    commandDelTabelCustomer.Parameters.AddWithValue("@idProduct", txtIDProduct.Text);
                    commandDelTabelCustomer.ExecuteNonQuery();

                    Invoice_Load(sender, e);
                    ptbClear_Click(sender, e);
                    connector.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi thong tin. Vui long kiem tra lai");
                }
            }
        }

        private void lblDel_Click(object sender, EventArgs e)
        {
            ptbDel_Click(sender, e);
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i= dataGridViewProduct.CurrentRow.Index;;
            txtIDProduct.Text = dataGridViewProduct.Rows[i].Cells[0].Value.ToString();
            txtTitleProduct.Text = dataGridViewProduct.Rows[i].Cells[1].Value.ToString();
            txtQuantity.Text = dataGridViewProduct.Rows[i].Cells[2].Value.ToString();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xac nhan thanh toan hoa don voi so tien " + txtCost.Text, "Thanh toan",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dlr == DialogResult.Yes)
            {
                MessageBox.Show("Da thanh toan va In hoa don");

                if (dataGridViewProduct.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "Invoice "+ setIDInvoiceInTheIdButton() + ".pdf";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Lỗi:" + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dataGridViewProduct.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dataGridViewProduct.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dataGridViewProduct.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Da xuat Bill", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
                }
            }
        }
    }
}
