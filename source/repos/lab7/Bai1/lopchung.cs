using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class lopchung
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\source\repos\lab7\Bai1\Database1.mdf;Integrated Security=True");
        public DataTable Adapter(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand comm = new SqlCommand(sql,conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object ExecuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            var kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}
