using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_SinhVien : KetNoi
    {
        //Lấy ra bảng chứ thông tin sinh viên để lọc dữ liệu show lên textbox
        public DataTable layDuLieuSinhVien(DTO_SVTaiKhoan tk)
        {
            string sql = "layDuLieuSinhVien";
            DataTable dt = null;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                dt = new DataTable();
                conn.Open();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@matk", tk.Matk);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        //Sửa thông tin sinh viên khi ấn vào cập nhập
        public bool suaThongTinSV(DTO_SVSinhVien dto_sv)
        {
            string sql = "suaThongTinSV";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@masv", dto_sv.Masv);
            comm.Parameters.AddWithValue("@ngaysinh", dto_sv.Ngaysinh.ToString());
            comm.Parameters.AddWithValue("@gioitinh", dto_sv.Phai);
            comm.Parameters.AddWithValue("@diachi", dto_sv.Diachi);
            comm.Parameters.AddWithValue("@dienthoai", dto_sv.Sdt);
            comm.Parameters.AddWithValue("@hinhanh", dto_sv.Hinhanh);
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
        public DataTable layBangDiemLan1(DTO_SVSinhVien dto_sv)
        {
            string sql = "layBangDiemLan1";
            DataTable dt = null;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                dt = new DataTable();
                conn.Open();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@masv", dto_sv.Masv);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable layBangDiemLan2(DTO_SVSinhVien dto_sv)
        {
            string sql = "layBangDiemLan2";
            DataTable dt = null;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                dt = new DataTable();
                conn.Open();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@masv", dto_sv.Masv);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
        public DataTable layBangDiemTrungBinh(DTO_SVSinhVien dto_sv)
        {
            string sql = "layBangDiemTrungBinh";
            DataTable dt = null;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                dt = new DataTable();
                conn.Open();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@masv", dto_sv.Masv);
                da.Fill(dt);
                conn.Close();
            }
            catch { }
            return dt;
        }
    }
}
