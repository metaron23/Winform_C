using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DangNhap : KetNoi
    {
        public int kiemTraDangNhap(DTO_DNDangNhap a)
        {
            string sql = "checkDangnhap";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@matk", a.Matk);
            comm.Parameters.AddWithValue("@pass", a.Pass);
            int kq = -1;
            conn.Open();
            kq = (int)comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}
