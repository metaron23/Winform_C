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
            Application.Run(new Lop());

            //DialogResult dg = new DialogResult();
            //dg = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dg == DialogResult.Yes)
            //{
            //    this.Close();
            //}


            //SqlDataAdapter da = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            //string sql = "layDuLieuThongKe";
            //da.SelectCommand = new SqlCommand(sql, conn);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.Fill(dt);
            //return dt;

        }
    }
}
