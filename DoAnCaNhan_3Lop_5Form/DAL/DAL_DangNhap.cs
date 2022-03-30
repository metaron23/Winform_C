using DTO;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DangNhap : KetNoi
    {
        public int kiemTraDangNhap(DTO_DNDangNhap a)
        {
            string sql = "checkDangnhap";
            int kq = -1;
            try
            {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = sql;
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@matk", a.Matk);
            comm.Parameters.AddWithValue("@pass", a.Pass);
            comm.Connection = conn;
            conn.Open();
            kq = (int)comm.ExecuteScalar();
            conn.Close();
            }
            catch { }
            return kq;
        }
    }
}
