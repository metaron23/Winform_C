using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\source\repos\lab7\Bai1\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string ktra = "select count(*) from dangnhap where taikhoan = '" + txt_taikhoan.Text + "' and matkhau = " +
                "'" + txt_matkhau.Text + "'";
            SqlCommand comm = new SqlCommand(ktra, conn);
            conn.Open();
            int check = int.Parse(comm.ExecuteScalar().ToString());
            if (check != 0)
            {
                frm_Thongtinkhachhang a = new frm_Thongtinkhachhang();
                a.Show();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu");
            }
            conn.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có thật sự muốn thoát", "Hỏi người dùng", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
