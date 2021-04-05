using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; //them thu vien

namespace QuanLyShopThoiTrang
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void spashScreen(object sender, PaintEventArgs e)
        {
            Graphics gradient = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(229, 230, 232));

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(229, 230, 232), Color.FromArgb(234, 235, 237), LinearGradientMode.Vertical);//230, 231, 233
            gradient.FillRectangle(lgb, area); 
            gradient.DrawRectangle(pen, area);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            progressBar.Increment(2);
            if (progressBar.Value == 100)
            {
                timer.Enabled = false;
                loginForm log = new loginForm();
                log.Show();
                this.Hide();
            }
        }
    }
}
