using System;
using System.Windows.Forms;

namespace QuanLyShopThoiTrang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new splashScreen());
            //Application.Run(new loginForm());
            Application.Run(new menuForm());
            //Application.Run(new employeeManagementForm());


            //Application.Run(new customerManagementForm());

            //Application.Run(new productManagement());

            //Application.Run(new Invoice());

            //Application.Run(new History());


            //singleton
        }
    }
}
