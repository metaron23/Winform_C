using DTO_QuanLy;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_KhachHang : lopchung
    {
        public DataTable getDataTableKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "LayDuLieuKhachHang";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Connection = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getDataTableHang()
        {
            string sql = "exec LayDuLieuHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getDataTableTinh()
        {            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "LayDuLieuTinh";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Connection = conn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertData(DTO_KhachHang kh)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "NhapKH";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                comm.Parameters.Add("@makh", SqlDbType.NVarChar).Value = kh.KHACHHANG_MAKH;
                comm.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = kh.KHACHHANG_TENKH;
                comm.Parameters.Add("@ngaymuahang", SqlDbType.NVarChar).Value = kh.KHACHHANG_NGAYMUAHANG.ToString();
                comm.Parameters.Add("@hinhanh", SqlDbType.NVarChar).Value = kh.KHACHHANG_HINHANH;
                comm.Parameters.Add("@mahang", SqlDbType.NVarChar).Value = kh.KHACHHANG_MAHANG;
                comm.Parameters.Add("@soluong", SqlDbType.Int).Value = kh.KHACHHANG_SOLUONG;
                comm.Parameters.Add("@matinh", SqlDbType.NVarChar).Value = kh.KHACHHANG_MATINH;
                conn.Open();
                if (comm.ExecuteNonQuery() > 0) return true;
                conn.Close();
            }
            catch
            {
            }
            return false;
        }
        public bool updateData(DTO_KhachHang kh)
        {
            try
            {
                conn.Open();                
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "update_khachhang";
                comm.CommandType = CommandType.StoredProcedure;
                if (comm.ExecuteNonQuery() > 0) return true;
                conn.Close();
            }
            catch
            {
            }
            return false;
        }
        public bool deleteData(DTO_KhachHang kh)
        {
            try
            {
                conn.Open();
                String sqlXoa = String.Format("delete from khachhang where makh = '{0}' ", kh.KHACHHANG_MAKH);
                SqlCommand comm = new SqlCommand(sqlXoa, conn);
                if (comm.ExecuteNonQuery() > 0) return true;
                conn.Close();
            }
            catch
            {
            }

            return false;
        }
        public int countRowData()
        {
            string sqlDem = string.Format("select count(*) from khachhang");
            SqlCommand comm = new SqlCommand(sqlDem, conn);
            conn.Open();
            int kq = (int)comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable searchData(string chuoi)
        {
            string sqlSearch = String.Format("select * from khachhang where makh like '%{0}%' or tenkh like N'%{1}%'", chuoi, chuoi);
            SqlDataAdapter da = new SqlDataAdapter(sqlSearch, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
