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
    public partial class productManagement : Form
    {
        string strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = majomiStore; Integrated Security = True";
        public productManagement()
        {
            InitializeComponent();
        }

        private void ptbArrowsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm menu = new menuForm();
            menu.Show();
        }

        private DataSet getAllProduct()
        {
            DataSet data = new DataSet();
            //sqlconnection
            //Sau khi su dung xong se tu huy connection
            string query = "SELECT * FROM Product ORDER BY ID_Product ASC;";

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

        private void countProduct()
        {
            int total;
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Product;", connector);
            total = (int)cmd.ExecuteScalar();
            txtTotalProduct.Text = total.ToString();
            connector.Close();
        }

        private void setIDInTheIdButton()
        {
            string type = cmbTypeProduct.Text;
            string subCharactersID = type.Substring(0, 2);
            
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            //Mac dinh lay gia tri cuoi danh sach trong CSDL
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Product) FROM Product WHERE Type_Product=@type;", connector);
            cmd.Parameters.AddWithValue("@type",type);
            string id_temp = (string)cmd.ExecuteScalar(); //Lay ra nhung o dang chuoi(string)
            string getTheLastNumberOfID = id_temp.Substring(2, 3); //Lay ky tu 3 so cuoi cung
            int id = int.Parse(getTheLastNumberOfID) + 1; //CHuyen doi sang dang so(int)
            if (id < 10)
            {
                txtIDProduct.Text = subCharactersID + "00" + id.ToString();
            }
            else if (id >= 10 && id < 100)
            {
                txtIDProduct.Text = subCharactersID + "0" + id.ToString();
            }
            else txtIDProduct.Text = subCharactersID + id.ToString();
            connector.Close();
        }

        private void productManagement_Load(object sender, EventArgs e)
        {
            //Xuat thong tin len bang lon
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllProduct().Tables[0];

            //Dem so luong nhan vien
            countProduct();
        }
        
        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            productManagement_Load(sender, e);
        }

        private void rdbAo_CheckedChanged(object sender, EventArgs e)
        {
            string ao = rdbAo.Text;

            //Xuat thong tin len bang lon datagridview
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllType(ao).Tables[0];

            //Dem so luong loai
            countType(ao);
        }

        private void rdbQuan_CheckedChanged(object sender, EventArgs e)
        {
            string quan = rdbQuan.Text;

            //Xuat thong tin len bang lon datagridview
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllType(quan).Tables[0];

            //Dem so luong loai
            countType(quan);
        }

        private void rdbVay_CheckedChanged(object sender, EventArgs e)
        {
            string vay = rdbVay.Text;

            //Xuat thong tin len bang lon datagridview
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllType(vay).Tables[0];

            //Dem so luong loai
            countType(vay);
        }

        private void rdbGiay_CheckedChanged(object sender, EventArgs e)
        {
            string giay = rdbGiay.Text;

            //Xuat thong tin len bang lon datagridview
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllType(giay).Tables[0];

            //Dem so luong loai
            countType(giay);
        }

        private void rdbTuiXach_CheckedChanged(object sender, EventArgs e)
        {
            string tuiXach = rdbTuiXach.Text;

            //Xuat thong tin len bang lon datagridview
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = getAllType(tuiXach).Tables[0];

            //Dem so luong loai
            countType(tuiXach);
        }

        #region Code Sap xep theo tung loai co tham so doc tu Radio Text

        //string type se duoc truyen vao tu text radio Ao, Quan, Vay, Giay, Tui xach,...
        //Se duoc nhan parameter de truyen vao query CSDL

        private DataSet getAllType(string type)
        {
            DataSet data = new DataSet();
            string query = "SELECT * FROM Product WHERE Type_Product=@type ORDER BY ID_Product ASC;;";

            using (SqlConnection connection = new SqlConnection(strDatabase))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@type", type);
                //sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void countType(string type)
        {
            int total;
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Product WHERE Type_Product=@type;", connector);
            cmd.Parameters.AddWithValue("@type", type);
            total = (int)cmd.ExecuteScalar();
            txtTotalProduct.Text = total.ToString();
            connector.Close();
        }

        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Show hộp thoại open file ra
            // Nhận kết quả trả về qua biến kiểu DialogResult
            DialogResult result = openFileDialog.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog.FileName);
                //Duong dan link hinh anh luu vao -> openFileDialog.FileName

                // Gán ảnh
                ptbProduct.Image = img;
            }
        }

        //public Image Resize(Image img, float percentage)
        //{
        //    //lấy kích thước ban đầu của bức ảnh
        //    int originalW = img.Width;
        //    int originalH = img.Height;

        //    //tính kích thước cho ảnh mới theo tỷ lệ đưa vào
        //    int resizedW = (int)(originalW * percentage);
        //    int resizedH = (int)(originalH * percentage);

        //    //tạo 1 ảnh Bitmap mới theo kích thước trên
        //    Bitmap bmp = new Bitmap(resizedW, resizedH);
        //    //tạo 1 graphic mới từ Bitmap
        //    Graphics graphic = Graphics.FromImage((Image)bmp);
        //    //vẽ lại ảnh ban đầu lên bmp theo kích thước mới
        //    graphic.DrawImage(img, 0, 0, resizedW, resizedH);
        //    //giải phóng tài nguyên mà graphic đang giữ
        //    graphic.Dispose();
        //    //return the image
        //    return (Image)bmp;
        //}

        //Doi du lieu hinh anh sang byte
        private byte[] converImgToByte()
        {
            FileStream fs;
            
            fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

            //Chuyen du lieu hinh anh thu nho size hinh anh lai -> tao dung luong byte moi
            //Image img = Resize(Image.FromFile(openFileDialog.FileName), 0.1F);

            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, (int)fs.Length);
            fs.Close();
            return picbyte;
        }



        //Co BUG
        //Chuyen du lieu Byte thanh Image
        private Image ByteToImg(string byteString)
        {
            //string input = "some text";
            //byte[] array = Encoding.ASCII.GetBytes(input);

            byte[] imgBytes = Encoding.ASCII.GetBytes(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDProduct.Clear();
            txtTitleProduct.Clear();
            cmbTypeProduct.ResetText();
            txtCostProduct.Clear();
            txtAmountProduct.Clear();
            txtManuProduct.Clear();
            ptbProduct.Image = null;
            txtColorProduct.Clear();
            cmbSex.ResetText();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtTitleProduct.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap doi tuong");
            }
            else
            {
                string queryModify = "UPDATE Product SET Title_Product=@title, Type_Product=@type, Sex_Product=@sex, Cost_Product=@cost, " +
                    "Amount_Product=@amount, Manufacturer=@manu, Color_Porduct=@color WHERE ID_Product=@id;";
                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                SqlCommand commandModify = new SqlCommand(queryModify, connector);

                commandModify.Parameters.AddWithValue("@id", txtIDProduct.Text);
                commandModify.Parameters.AddWithValue("@title", txtTitleProduct.Text);
                commandModify.Parameters.AddWithValue("@type", cmbTypeProduct.Text);
                commandModify.Parameters.AddWithValue("@sex", cmbSex.Text);
                commandModify.Parameters.AddWithValue("@cost", txtCostProduct.Text);
                commandModify.Parameters.AddWithValue("@amount", txtAmountProduct.Text);
                commandModify.Parameters.AddWithValue("@manu", txtManuProduct.Text);
                commandModify.Parameters.AddWithValue("@color", txtColorProduct.Text);
                //image
                //commandModify.Parameters.AddWithValue("@image", cmbSex.Text);
                commandModify.ExecuteNonQuery();

                productManagement_Load(sender, e);
                btnClear_Click(sender, e);
                connector.Close();
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT Image_Product FROM Product WHERE ID_Product=@id;";
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            SqlCommand command = new SqlCommand(query, connector);
            command.Parameters.AddWithValue("@id", txtIDProduct.Text);


            int i;
            i = dataGridView.CurrentRow.Index;
            txtIDProduct.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
            txtTitleProduct.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
            cmbTypeProduct.Text = dataGridView.Rows[i].Cells[2].Value.ToString();
            cmbSex.Text = dataGridView.Rows[i].Cells[3].Value.ToString();
            txtCostProduct.Text = dataGridView.Rows[i].Cells[4].Value.ToString();
            txtAmountProduct.Text = dataGridView.Rows[i].Cells[5].Value.ToString();
            txtManuProduct.Text = dataGridView.Rows[i].Cells[6].Value.ToString();
            txtColorProduct.Text = dataGridView.Rows[i].Cells[7].Value.ToString();
            //image
            //getPictureFromDatabase(txtIDProduct.Text);

            //CO BUG
            //ptbProduct.Image = ByteToImg(query);
        }

        private void cmbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sau khi chon Type moi xuat ID ra ID Button
            //Set up ID
            setIDInTheIdButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitleProduct.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap doi tuong");
            }
            else
            {
                //Them du lieu vao table.EmpInfo
                string queryAdd = "INSERT INTO Product VALUES (@id,@title,@type,@sex,@cost,@amount,@manu,@color,@image);";

                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                SqlCommand commandAdd = new SqlCommand(queryAdd, connector);

                //Thuc thi lenh them du lieu vao bang Product
                commandAdd.Parameters.AddWithValue("@id", txtIDProduct.Text);
                commandAdd.Parameters.AddWithValue("@title", txtTitleProduct.Text);
                commandAdd.Parameters.AddWithValue("@type", cmbTypeProduct.Text);
                commandAdd.Parameters.AddWithValue("@sex", cmbSex.Text);
                commandAdd.Parameters.AddWithValue("@cost", txtCostProduct.Text); //Kieu String
                commandAdd.Parameters.AddWithValue("@amount", txtAmountProduct.Text); //Kieu String
                commandAdd.Parameters.AddWithValue("@manu", txtManuProduct.Text);
                commandAdd.Parameters.AddWithValue("@color", txtColorProduct.Text);
                //Và sau đó mất chỉ 10 phút để sửa sai dcm =((((((
                commandAdd.Parameters.AddWithValue("@image", converImgToByte());
                
                //Link hinh anh da duoc chuyen doi sang dang byte code

                //Tôi đã mất 3 tiếng đồng hồ để viết cái hàm ngu xuẩn này đm :((((
                //Nó convert từ byte sang dạng quần què gì đéo hiểu nvarchar :((((
                //String linkImage= Convert.ToBase64String(converImgToByte()); 

                commandAdd.ExecuteNonQuery();

                productManagement_Load(sender, e);
                btnClear_Click(sender, e);
                connector.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtTitleProduct.Text.Equals(""))
            {
                MessageBox.Show("Ban chua chon doi tuong can xoa");
            }
            else
            {
                string name = txtTitleProduct.Text;
                DialogResult dlr = MessageBox.Show("Ban co chac chan muon xoa " + name + " khoi he thong ko?", "Thông báo",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                if (dlr == DialogResult.No)
                {
                    btnClear_Click(sender, e);
                }
                if (dlr == DialogResult.Yes)
                {
                    string queryDeleteTabelCustomer = "DELETE Product WHERE ID_Product=@id;";

                    SqlConnection connector = new SqlConnection(strDatabase);
                    connector.Open();
                    //Thuc thi tren table.EmpInfo
                    SqlCommand commandDelTabelProduct = new SqlCommand(queryDeleteTabelCustomer, connector);
                    commandDelTabelProduct.Parameters.AddWithValue("@id", txtIDProduct.Text);
                    commandDelTabelProduct.ExecuteNonQuery();

                    productManagement_Load(sender, e);
                    btnClear_Click(sender, e);
                    connector.Close();
                }
            }
        }



        //Con BUG o button Find

        private void btnFinder_Click(object sender, EventArgs e)
        {
            if (txtFinderProduct.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap thong tin can tim");
            }
            else
            {
                string queryFinder = "SELECT * FROM Product WHERE Title_Product=@tile;";
                int i = dataGridView.CurrentRow.Index;

                SqlConnection connector = new SqlConnection(strDatabase);

                connector.Open();
                SqlCommand command = new SqlCommand(queryFinder, connector);
                command.Parameters.AddWithValue("@title",txtFinderProduct);

                //////// BUG  Phai tra ve vi tri gi do moi ra duoc
                dataGridView_CellContentClick(i);

            }
        }

        private void dataGridView_CellContentClick(int i)
        {
            i = dataGridView.CurrentRow.Index;
            txtIDProduct.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
            txtTitleProduct.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
            cmbTypeProduct.Text = dataGridView.Rows[i].Cells[2].Value.ToString();
            cmbSex.Text = dataGridView.Rows[i].Cells[3].Value.ToString();
            txtCostProduct.Text = dataGridView.Rows[i].Cells[4].Value.ToString();
            txtAmountProduct.Text = dataGridView.Rows[i].Cells[5].Value.ToString();
            txtManuProduct.Text = dataGridView.Rows[i].Cells[6].Value.ToString();
            txtColorProduct.Text = dataGridView.Rows[i].Cells[7].Value.ToString();
            //image
            //cmbTypeProduct.Text = dataGridView.Rows[i].Cells[8].Value.ToString();

            //To sang o trong datagridview khi duoc tim
            dataGridView.Rows[i].Selected = true;
        }
    }
}