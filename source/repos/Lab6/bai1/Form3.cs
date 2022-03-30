using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VFGKUQC\KHO1;Initial Catalog=QL_SINHVIEN;Persist Security Info=True;User ID=sa;Password=123456");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadGrid()
        {
            int a = 1;
            string sqlfunc = "select dbo.chuyen_gt (" + a + ")";
            SqlCommand comm = new SqlCommand(sqlfunc, conn);
            conn.Open();
            string b = comm.ExecuteScalar().ToString();
            conn.Close();
            MessageBox.Show(b);
        }
    }
}
