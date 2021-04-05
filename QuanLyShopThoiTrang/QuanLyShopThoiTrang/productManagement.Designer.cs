
namespace QuanLyShopThoiTrang
{
    partial class productManagement
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
            this.ptbArrowsBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrowsBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbArrowsBack
            // 
            this.ptbArrowsBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbArrowsBack.Image = global::QuanLyShopThoiTrang.Properties.Resources.icons8_back_to_100;
            this.ptbArrowsBack.Location = new System.Drawing.Point(12, 12);
            this.ptbArrowsBack.Name = "ptbArrowsBack";
            this.ptbArrowsBack.Size = new System.Drawing.Size(30, 30);
            this.ptbArrowsBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbArrowsBack.TabIndex = 12;
            this.ptbArrowsBack.TabStop = false;
            this.ptbArrowsBack.Click += new System.EventHandler(this.ptbArrowsBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 973);
            this.panel1.TabIndex = 13;
            // 
            // productManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbArrowsBack);
            this.Name = "productManagement";
            this.Text = "productManagement";
            this.Load += new System.EventHandler(this.productManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrowsBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbArrowsBack;
        private System.Windows.Forms.Panel panel1;
    }
}