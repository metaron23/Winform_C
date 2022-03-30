using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_SinhVien
    {
        DAL_SinhVien sv = new DAL_SinhVien();
        public DataTable layDuLieuSinhVien(DTO_SVTaiKhoan tk)
        {
            return sv.layDuLieuSinhVien(tk);
        }
        public bool suaThongTinSV(DTO_SVSinhVien dto_sv)
        {
            return sv.suaThongTinSV(dto_sv);
        }
        public DataTable layBangDiemLan1(DTO_SVSinhVien dto_sv)
        {
            return sv.layBangDiemLan1(dto_sv);
        }
        public DataTable layBangDiemLan2(DTO_SVSinhVien dto_sv)
        {
            return sv.layBangDiemLan2(dto_sv);
        }
        public DataTable layBangDiemTrungBinh(DTO_SVSinhVien dto_sv)
        {
            return sv.layBangDiemTrungBinh(dto_sv);
        }
    }
}
