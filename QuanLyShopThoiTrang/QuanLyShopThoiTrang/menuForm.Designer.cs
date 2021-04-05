
namespace QuanLyShopThoiTrang
{
    partial class menuForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeManagement_Label = new System.Windows.Forms.Label();
            this.optionsComboBox = new System.Windows.Forms.ComboBox();
            this.invoices_Label = new System.Windows.Forms.Label();
            this.customerManagement_Label = new System.Windows.Forms.Label();
            this.productManagement_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(95)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(474, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nghia";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.employeeManagement_Label);
            this.panel1.Controls.Add(this.optionsComboBox);
            this.panel1.Controls.Add(this.invoices_Label);
            this.panel1.Controls.Add(this.customerManagement_Label);
            this.panel1.Controls.Add(this.productManagement_Label);
            this.panel1.Location = new System.Drawing.Point(769, -26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 1093);
            this.panel1.TabIndex = 2;
            // 
            // employeeManagement_Label
            // 
            this.employeeManagement_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeManagement_Label.AutoSize = true;
            this.employeeManagement_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeManagement_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeManagement_Label.Location = new System.Drawing.Point(146, 424);
            this.employeeManagement_Label.Name = "employeeManagement_Label";
            this.employeeManagement_Label.Size = new System.Drawing.Size(733, 70);
            this.employeeManagement_Label.TabIndex = 5;
            this.employeeManagement_Label.Text = "Employee Management";
            this.employeeManagement_Label.Click += new System.EventHandler(this.employeeManagement_Label_Click_1);
            // 
            // optionsComboBox
            // 
            this.optionsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.optionsComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.optionsComboBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.optionsComboBox.FormattingEnabled = true;
            this.optionsComboBox.Items.AddRange(new object[] {
            "Log out",
            "Info"});
            this.optionsComboBox.Location = new System.Drawing.Point(894, 50);
            this.optionsComboBox.Name = "optionsComboBox";
            this.optionsComboBox.Size = new System.Drawing.Size(102, 29);
            this.optionsComboBox.TabIndex = 4;
            this.optionsComboBox.Text = "Options";
            this.optionsComboBox.SelectedIndexChanged += new System.EventHandler(this.optionsComboBox_SelectedIndexChanged);
            // 
            // invoices_Label
            // 
            this.invoices_Label.AutoSize = true;
            this.invoices_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoices_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoices_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invoices_Label.Location = new System.Drawing.Point(146, 744);
            this.invoices_Label.Name = "invoices_Label";
            this.invoices_Label.Size = new System.Drawing.Size(490, 70);
            this.invoices_Label.TabIndex = 2;
            this.invoices_Label.Text = "Search Invoices";
            // 
            // customerManagement_Label
            // 
            this.customerManagement_Label.AutoSize = true;
            this.customerManagement_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManagement_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerManagement_Label.Location = new System.Drawing.Point(146, 584);
            this.customerManagement_Label.Name = "customerManagement_Label";
            this.customerManagement_Label.Size = new System.Drawing.Size(721, 70);
            this.customerManagement_Label.TabIndex = 1;
            this.customerManagement_Label.Text = "Customer Management";
            this.customerManagement_Label.Click += new System.EventHandler(this.customerManagement_Label_Click);
            // 
            // productManagement_Label
            // 
            this.productManagement_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productManagement_Label.AutoSize = true;
            this.productManagement_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productManagement_Label.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productManagement_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productManagement_Label.Location = new System.Drawing.Point(146, 264);
            this.productManagement_Label.Name = "productManagement_Label";
            this.productManagement_Label.Size = new System.Drawing.Size(666, 70);
            this.productManagement_Label.TabIndex = 0;
            this.productManagement_Label.Text = "Product Management";
            this.productManagement_Label.Click += new System.EventHandler(this.productManagement_Label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vogue", 50F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(180, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 75);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hello";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vogue", 37F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(170, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(523, 56);
            this.label4.TabIndex = 11;
            this.label4.Text = "what would you";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vogue", 37F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(170, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "want to do?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyShopThoiTrang.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(180, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerManagement_Label;
        private System.Windows.Forms.Label productManagement_Label;
        private System.Windows.Forms.Label invoices_Label;
        private System.Windows.Forms.ComboBox optionsComboBox;
        private System.Windows.Forms.Label employeeManagement_Label;
    }
}