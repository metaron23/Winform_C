using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dal_tk = new DAL_ThongKe();
        public DataTable layDuLieuThongKe()
        {
            return dal_tk.layDuLieuThongKe();
        }

        public DataTable diemTheoMon(string masv)
        {
            return dal_tk.diemTheoMon(masv);
        }

        public DataTable layBangLop()
        {
            return dal_tk.layBangLop();
        }

        public DataTable layBangQLSinhVien()
        {
            return dal_tk.layBangQLSinhVien();
        }

        public bool suaDiem(DTO_ThongKe dto_tk)
        {
            return dal_tk.suaDiem(dto_tk);
        }
    }
}
