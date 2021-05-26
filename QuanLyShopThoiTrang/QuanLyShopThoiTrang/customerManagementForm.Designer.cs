
namespace QuanLyShopThoiTrang
{
    partial class customerManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptbArrowsBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblFinder = new System.Windows.Forms.Label();
            this.ptbFinder = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblModify = new System.Windows.Forms.Label();
            this.ptbModify = new System.Windows.Forms.PictureBox();
            this.txtPhoneNumberFinder = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.ptbClear = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDel = new System.Windows.Forms.Label();
            this.ptbDel = new System.Windows.Forms.PictureBox();
            this.grbAdd = new System.Windows.Forms.GroupBox();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrowsBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinder)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModify)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClear)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDel)).BeginInit();
            this.grbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbArrowsBack
            // 
            this.ptbArrowsBack.BackColor = System.Drawing.Color.Transparent;
            this.ptbArrowsBack.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_back_to_100;
            this.ptbArrowsBack.Location = new System.Drawing.Point(12, 12);
            this.ptbArrowsBack.Name = "ptbArrowsBack";
            this.ptbArrowsBack.Size = new System.Drawing.Size(30, 30);
            this.ptbArrowsBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbArrowsBack.TabIndex = 12;
            this.ptbArrowsBack.TabStop = false;
            this.ptbArrowsBack.Click += new System.EventHandler(this.ptbArrowsBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vogue", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(869, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Manager";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(9, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1869, 489);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentDoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(30, 138);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 29);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 214);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(193, 29);
            this.lblPhoneNumber.TabIndex = 16;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(281, 140);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(420, 32);
            this.txtNameCustomer.TabIndex = 17;
            // 
            // txtPhoneNumberCustomer
            // 
            this.txtPhoneNumberCustomer.Location = new System.Drawing.Point(281, 216);
            this.txtPhoneNumberCustomer.Name = "txtPhoneNumberCustomer";
            this.txtPhoneNumberCustomer.Size = new System.Drawing.Size(420, 32);
            this.txtPhoneNumberCustomer.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.txtPhoneNumberFinder);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.grbAdd);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtPhoneNumberCustomer);
            this.groupBox1.Controls.Add(this.txtNameCustomer);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 662);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1878, 289);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controler";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 100);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblFinder);
            this.groupBox7.Controls.Add(this.ptbFinder);
            this.groupBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox7.Location = new System.Drawing.Point(1723, 52);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(138, 61);
            this.groupBox7.TabIndex = 46;
            this.groupBox7.TabStop = false;
            // 
            // lblFinder
            // 
            this.lblFinder.AutoSize = true;
            this.lblFinder.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinder.Location = new System.Drawing.Point(54, 23);
            this.lblFinder.Name = "lblFinder";
            this.lblFinder.Size = new System.Drawing.Size(47, 22);
            this.lblFinder.TabIndex = 36;
            this.lblFinder.Text = "Find";
            this.lblFinder.Click += new System.EventHandler(this.lblFinder_Click);
            // 
            // ptbFinder
            // 
            this.ptbFinder.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_find_user_male_100;
            this.ptbFinder.Location = new System.Drawing.Point(6, 12);
            this.ptbFinder.Name = "ptbFinder";
            this.ptbFinder.Size = new System.Drawing.Size(45, 45);
            this.ptbFinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFinder.TabIndex = 37;
            this.ptbFinder.TabStop = false;
            this.ptbFinder.Click += new System.EventHandler(this.ptbFinder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1397, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Phone Number";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblModify);
            this.groupBox6.Controls.Add(this.ptbModify);
            this.groupBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox6.Location = new System.Drawing.Point(1014, 87);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 61);
            this.groupBox6.TabIndex = 44;
            this.groupBox6.TabStop = false;
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModify.Location = new System.Drawing.Point(54, 23);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(72, 22);
            this.lblModify.TabIndex = 36;
            this.lblModify.Text = "Modify";
            this.lblModify.Click += new System.EventHandler(this.lblModify_Click);
            // 
            // ptbModify
            // 
            this.ptbModify.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_pen_100;
            this.ptbModify.Location = new System.Drawing.Point(6, 12);
            this.ptbModify.Name = "ptbModify";
            this.ptbModify.Size = new System.Drawing.Size(45, 45);
            this.ptbModify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbModify.TabIndex = 37;
            this.ptbModify.TabStop = false;
            this.ptbModify.Click += new System.EventHandler(this.ptbModify_Click);
            // 
            // txtPhoneNumberFinder
            // 
            this.txtPhoneNumberFinder.Location = new System.Drawing.Point(1401, 73);
            this.txtPhoneNumberFinder.Name = "txtPhoneNumberFinder";
            this.txtPhoneNumberFinder.Size = new System.Drawing.Size(309, 32);
            this.txtPhoneNumberFinder.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblClear);
            this.groupBox5.Controls.Add(this.ptbClear);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox5.Location = new System.Drawing.Point(881, 171);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(118, 61);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.Location = new System.Drawing.Point(54, 23);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(59, 22);
            this.lblClear.TabIndex = 36;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // ptbClear
            // 
            this.ptbClear.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_clear_symbol_100;
            this.ptbClear.Location = new System.Drawing.Point(6, 12);
            this.ptbClear.Name = "ptbClear";
            this.ptbClear.Size = new System.Drawing.Size(45, 45);
            this.ptbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClear.TabIndex = 37;
            this.ptbClear.TabStop = false;
            this.ptbClear.Click += new System.EventHandler(this.ptbClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDel);
            this.groupBox4.Controls.Add(this.ptbDel);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.Location = new System.Drawing.Point(1015, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 70);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDel.Location = new System.Drawing.Point(54, 23);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(70, 22);
            this.lblDel.TabIndex = 36;
            this.lblDel.Text = "Delete";
            this.lblDel.Click += new System.EventHandler(this.lblDel_Click);
            // 
            // ptbDel
            // 
            this.ptbDel.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_remove_96;
            this.ptbDel.Location = new System.Drawing.Point(6, 12);
            this.ptbDel.Name = "ptbDel";
            this.ptbDel.Size = new System.Drawing.Size(45, 45);
            this.ptbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDel.TabIndex = 37;
            this.ptbDel.TabStop = false;
            this.ptbDel.Click += new System.EventHandler(this.ptbDel_Click);
            // 
            // grbAdd
            // 
            this.grbAdd.Controls.Add(this.ptbAdd);
            this.grbAdd.Controls.Add(this.lblAdd);
            this.grbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbAdd.Location = new System.Drawing.Point(890, 98);
            this.grbAdd.Name = "grbAdd";
            this.grbAdd.Size = new System.Drawing.Size(100, 52);
            this.grbAdd.TabIndex = 41;
            this.grbAdd.TabStop = false;
            // 
            // ptbAdd
            // 
            this.ptbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAdd.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_plus_100;
            this.ptbAdd.Location = new System.Drawing.Point(6, 3);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(40, 40);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdd.TabIndex = 34;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(48, 12);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(51, 22);
            this.lblAdd.TabIndex = 35;
            this.lblAdd.Text = "Add";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(281, 64);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(420, 32);
            this.txtID.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(30, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 29);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalCustomer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1900, 565);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.Location = new System.Drawing.Point(19, 527);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.ReadOnly = true;
            this.txtTotalCustomer.Size = new System.Drawing.Size(111, 22);
            this.txtTotalCustomer.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Location = new System.Drawing.Point(1723, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 69);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_clear_symbol_100;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.Location = new System.Drawing.Point(66, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Clear";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // customerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyShopThoiTrang.Properties.Resources.stil_vdaJJbls3xE_unsplash;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbArrowsBack);
            this.Name = "customerManagementForm";
            this.Text = "customerManagementForm";
            this.Load += new System.EventHandler(this.customerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrowsBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFinder)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbModify)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClear)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDel)).EndInit();
            this.grbAdd.ResumeLayout(false);
            this.grbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbArrowsBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.TextBox txtPhoneNumberCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumberFinder;
        private System.Windows.Forms.TextBox txtTotalCustomer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.PictureBox ptbModify;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.PictureBox ptbClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.PictureBox ptbDel;
        private System.Windows.Forms.GroupBox grbAdd;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblFinder;
        private System.Windows.Forms.PictureBox ptbFinder;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}