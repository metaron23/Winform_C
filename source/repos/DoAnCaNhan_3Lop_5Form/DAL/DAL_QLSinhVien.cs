using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_QLSinhVien : KetNoi
    {
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

        public bool chenDuLieuVaoBangTaiKhoan(DTO_DNDangNhap dto_dn)
        {
            string sql = "chenDuLieuVaoBangTaiKhoan";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@matk", dto_dn.Matk);
            comm.Parameters.AddWithValue("@pass", dto_dn.Pass);
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

        public bool chenDuLieuQLSinhVien(DTO_QLSV_TTSV dto_sv)
        {
            string sql = "chenDuLieuQLSinhVien";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@masv", dto_sv.Masv);
            comm.Parameters.AddWithValue("@tensv", dto_sv.Tensv);
            comm.Parameters.AddWithValue("@ngaysinh", dto_sv.Ngaysinh.ToString());
            comm.Parameters.AddWithValue("@phai", dto_sv.Phai);
            comm.Parameters.AddWithValue("@diachi", dto_sv.Diachi);
            comm.Parameters.AddWithValue("@dienthoai", dto_sv.Sdt);
            comm.Parameters.AddWithValue("@malop", dto_sv.Malop);
            comm.Parameters.AddWithValue("@hinhanh", "");
            comm.Parameters.AddWithValue("@matk", dto_sv.Matk);
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
        public bool suaDuLieuBangQLSinhVien(DTO_QLSV_TTSV dto_sv)
        {
            string sql = "suaDuLieuBangQLSinhVien";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@masv", dto_sv.Masv);
            comm.Parameters.AddWithValue("@tensv", dto_sv.Tensv);
            comm.Parameters.AddWithValue("@ngaysinh", dto_sv.Ngaysinh.ToString());
            comm.Parameters.AddWithValue("@phai", dto_sv.Phai);
            comm.Parameters.AddWithValue("@diachi", dto_sv.Diachi);
            comm.Parameters.AddWithValue("@dienthoai", dto_sv.Sdt);
            comm.Parameters.AddWithValue("@malop", dto_sv.Malop);
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

        public bool xoaSinhVienVaTK(DTO_QLSV_TTSV dto_sv)
        {
            string sql = "xoaSinhVienVaTK";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@masv", dto_sv.Masv);
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
        //public bool xoaSinhVienvaTK(DTO_QLSV_TTSV dt)
        //{ }
        public DataTable timKiem(string chuoi)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = "timKiem";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("chuoitim", chuoi);
            da.Fill(dt);
            return dt;
        }

    }
}
