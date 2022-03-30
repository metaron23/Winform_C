using System.Data;
using System.Data.SqlClient;

namespace ThongTinKhachHang
{
    public class LopChung
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\source\repos\lab7\Bai1\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        public DataTable layDuLieuBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool NonQuery(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                if (comm.ExecuteNonQuery() > 0) return true;
            }
            catch { }
            conn.Close();
            return false;
        }
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public object dem()
        {
            string sql = "select dbo.demKhachHang()";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}
