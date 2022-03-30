using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DoiMK : KetNoi
    {
        public int kiemTraMatKhauCu(DTO_DoiMK doimk)
        {
            string sql = "doiMatKhau";
            int kq = 0;
            SqlCommand comm = new SqlCommand(sql,conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@matk", doimk.Matk);
            comm.Parameters.AddWithValue("@passcu", doimk.Passcu);
            comm.Parameters.AddWithValue("@passmoi", doimk.Passmoi);
            try
            {
                conn.Open();
                kq = (int)comm.ExecuteNonQuery();
                conn.Close();
            }
            catch { }
            return kq;
        }
    }
}
