using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI_DangNhap());
            //Application.Run(new GUI_FromCha());
            //Application.Run(new GUI_QLSinhVien());
            //Application.Run(new GUI_SinhVien());
            //Application.Run(new GUI_QLSinhVien());
            Application.Run(new GUI_FromCha());
        }
    }
}
