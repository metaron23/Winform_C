using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\source\repos\DoAnCaNhan_3Lop_5Form\GUI\DoAn.mdf;Integrated Security=True");
            string sql = "themLop";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@malop", txt_malop.Text);
            comm.Parameters.AddWithValue("@tenlop", txt_tenlop.Text);
            comm.Parameters.AddWithValue("@cvht", txt_cvht.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
