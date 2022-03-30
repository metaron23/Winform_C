using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ThongKe : KetNoi
    {
        public DataTable layDuLieuThongKe()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = "layDuLieuThongKe";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public DataTable diemTheoMon(string masv)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = "diemTheoMon";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@masv", masv);
            da.Fill(dt);
            return dt;
        }

        public DataTable layBangLop()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = "layBangLop";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public DataTable layBangQLSinhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = "layBangQLSinhVien";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }

        public bool suaDiem(DTO_ThongKe dto_tk)
        {
            string sql = "suaDiem";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@masv", dto_tk.Masv);
            comm.Parameters.AddWithValue("@mamh", dto_tk.Mamon);
            comm.Parameters.AddWithValue("@diemlan1", dto_tk.Diemlan1);
            comm.Parameters.AddWithValue("@diemlan2", dto_tk.Diemlan2);
            try
            {
                conn.Open();
                if (comm.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
            }
            catch { }
            return false;
        }
    }
}
