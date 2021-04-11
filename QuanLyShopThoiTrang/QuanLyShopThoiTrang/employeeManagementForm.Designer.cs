
namespace QuanLyShopThoiTrang
{
    partial class employeeManagementForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.totalEmployeeLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbWorkType = new System.Windows.Forms.ComboBox();
            this.workTypelabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.dtpStartWorkingDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.acadamicLevelComboBox = new System.Windows.Forms.ComboBox();
            this.acadamicLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.delButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.modifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFinder = new System.Windows.Forms.Button();
            this.txtIdFinder = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.ptbArrowsBack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDWorkType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrowsBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalEmployeeTextBox);
            this.groupBox2.Controls.Add(this.totalEmployeeLabel);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1885, 489);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // totalEmployeeTextBox
            // 
            this.totalEmployeeTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalEmployeeTextBox.Location = new System.Drawing.Point(78, 455);
            this.totalEmployeeTextBox.Name = "totalEmployeeTextBox";
            this.totalEmployeeTextBox.ReadOnly = true;
            this.totalEmployeeTextBox.Size = new System.Drawing.Size(64, 22);
            this.totalEmployeeTextBox.TabIndex = 2;
            // 
            // totalEmployeeLabel
            // 
            this.totalEmployeeLabel.AutoSize = true;
            this.totalEmployeeLabel.Location = new System.Drawing.Point(28, 460);
            this.totalEmployeeLabel.Name = "totalEmployeeLabel";
            this.totalEmployeeLabel.Size = new System.Drawing.Size(44, 17);
            this.totalEmployeeLabel.TabIndex = 1;
            this.totalEmployeeLabel.Text = "Total:";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1841, 414);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.txtAllowance);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtIDWorkType);
            this.groupBox3.Controls.Add(this.btnClearInput);
            this.groupBox3.Controls.Add(this.cmbLanguage);
            this.groupBox3.Controls.Add(this.txtPhoneNumber);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbWorkType);
            this.groupBox3.Controls.Add(this.workTypelabel);
            this.groupBox3.Controls.Add(this.languageLabel);
            this.groupBox3.Controls.Add(this.dtpStartWorkingDay);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.acadamicLevelComboBox);
            this.groupBox3.Controls.Add(this.acadamicLabel);
            this.groupBox3.Controls.Add(this.emailTextBox);
            this.groupBox3.Controls.Add(this.addressTextBox);
            this.groupBox3.Controls.Add(this.emailLabel);
            this.groupBox3.Controls.Add(this.addressLabel);
            this.groupBox3.Controls.Add(this.sexComboBox);
            this.groupBox3.Controls.Add(this.delButton);
            this.groupBox3.Controls.Add(this.dateTimePicker);
            this.groupBox3.Controls.Add(this.modifyButton);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(this.idTextBox);
            this.groupBox3.Location = new System.Drawing.Point(43, 544);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 477);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Employee";
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(342, 284);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(75, 23);
            this.btnClearInput.TabIndex = 31;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Tieng Anh ",
            "Tieng Phap",
            "Tieng Nga",
            "Tieng Trung",
            "Tieng Thai",
            "Tieng Nhat",
            "Tieng Han"});
            this.cmbLanguage.Location = new System.Drawing.Point(508, 110);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(186, 24);
            this.cmbLanguage.TabIndex = 30;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(151, 227);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(186, 22);
            this.txtPhoneNumber.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Phone Number";
            // 
            // cmbWorkType
            // 
            this.cmbWorkType.FormattingEnabled = true;
            this.cmbWorkType.Items.AddRange(new object[] {
            "Quan ly",
            "Ban hang",
            "Bao Ve",
            "Tap vu",
            "Nhan vien order",
            "Mau anh"});
            this.cmbWorkType.Location = new System.Drawing.Point(508, 149);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(111, 24);
            this.cmbWorkType.TabIndex = 25;
            this.cmbWorkType.SelectedIndexChanged += new System.EventHandler(this.cmbWorkType_SelectedIndexChanged);
            // 
            // workTypelabel
            // 
            this.workTypelabel.AutoSize = true;
            this.workTypelabel.Location = new System.Drawing.Point(372, 150);
            this.workTypelabel.Name = "workTypelabel";
            this.workTypelabel.Size = new System.Drawing.Size(77, 17);
            this.workTypelabel.TabIndex = 23;
            this.workTypelabel.Text = "Work Type";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(372, 111);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(72, 17);
            this.languageLabel.TabIndex = 22;
            this.languageLabel.Text = "Language";
            // 
            // dtpStartWorkingDay
            // 
            this.dtpStartWorkingDay.Location = new System.Drawing.Point(508, 189);
            this.dtpStartWorkingDay.Name = "dtpStartWorkingDay";
            this.dtpStartWorkingDay.Size = new System.Drawing.Size(186, 22);
            this.dtpStartWorkingDay.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Start Working Day";
            // 
            // acadamicLevelComboBox
            // 
            this.acadamicLevelComboBox.FormattingEnabled = true;
            this.acadamicLevelComboBox.Items.AddRange(new object[] {
            "Cao Hoc",
            "Dai Hoc",
            "Cao Dang",
            "Trung Cap",
            "Cap 3",
            "Cap 2",
            "Cap 1",
            "None"});
            this.acadamicLevelComboBox.Location = new System.Drawing.Point(508, 71);
            this.acadamicLevelComboBox.Name = "acadamicLevelComboBox";
            this.acadamicLevelComboBox.Size = new System.Drawing.Size(186, 24);
            this.acadamicLevelComboBox.TabIndex = 19;
            // 
            // acadamicLabel
            // 
            this.acadamicLabel.AutoSize = true;
            this.acadamicLabel.Location = new System.Drawing.Point(372, 72);
            this.acadamicLabel.Name = "acadamicLabel";
            this.acadamicLabel.Size = new System.Drawing.Size(107, 17);
            this.acadamicLabel.TabIndex = 18;
            this.acadamicLabel.Text = "Acadamic Level";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(508, 33);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(186, 22);
            this.emailTextBox.TabIndex = 17;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(151, 186);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(186, 22);
            this.addressTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(372, 33);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(28, 189);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.sexComboBox.Location = new System.Drawing.Point(151, 107);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(186, 24);
            this.sexComboBox.TabIndex = 13;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(232, 284);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 12;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(151, 147);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(186, 22);
            this.dateTimePicker.TabIndex = 12;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(134, 284);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 11;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(31, 284);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(151, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(186, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.idTextBox.Location = new System.Drawing.Point(151, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(186, 22);
            this.idTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnClearFinder);
            this.groupBox1.Controls.Add(this.txtIdFinder);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Location = new System.Drawing.Point(774, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 477);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnClearFinder
            // 
            this.btnClearFinder.Location = new System.Drawing.Point(180, 107);
            this.btnClearFinder.Name = "btnClearFinder";
            this.btnClearFinder.Size = new System.Drawing.Size(75, 23);
            this.btnClearFinder.TabIndex = 14;
            this.btnClearFinder.Text = "Clear";
            this.btnClearFinder.UseVisualStyleBackColor = true;
            this.btnClearFinder.Click += new System.EventHandler(this.btnClearFinder_Click);
            // 
            // txtIdFinder
            // 
            this.txtIdFinder.Location = new System.Drawing.Point(105, 46);
            this.txtIdFinder.Name = "txtIdFinder";
            this.txtIdFinder.Size = new System.Drawing.Size(208, 22);
            this.txtIdFinder.TabIndex = 3;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(68, 105);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 13;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // ptbArrowsBack
            // 
            this.ptbArrowsBack.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_back_to_100;
            this.ptbArrowsBack.Location = new System.Drawing.Point(12, 12);
            this.ptbArrowsBack.Name = "ptbArrowsBack";
            this.ptbArrowsBack.Size = new System.Drawing.Size(30, 30);
            this.ptbArrowsBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbArrowsBack.TabIndex = 11;
            this.ptbArrowsBack.TabStop = false;
            this.ptbArrowsBack.Click += new System.EventHandler(this.ptbArrowsBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(1023, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee Manager";
            // 
            // txtIDWorkType
            // 
            this.txtIDWorkType.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIDWorkType.Location = new System.Drawing.Point(625, 151);
            this.txtIDWorkType.Name = "txtIDWorkType";
            this.txtIDWorkType.ReadOnly = true;
            this.txtIDWorkType.Size = new System.Drawing.Size(69, 22);
            this.txtIDWorkType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Allowace";
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(508, 230);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(186, 22);
            this.txtAllowance.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "ID";
            // 
            // employeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbArrowsBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Name = "employeeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "employeeManagementForm";
            this.Load += new System.EventHandler(this.employeeManagementForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrowsBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.TextBox totalEmployeeTextBox;
        private System.Windows.Forms.Label totalEmployeeLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.DateTimePicker dtpStartWorkingDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox acadamicLevelComboBox;
        private System.Windows.Forms.Label acadamicLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label workTypelabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox cmbWorkType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdFinder;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button btnClearFinder;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.PictureBox ptbArrowsBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDWorkType;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}