using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_QLSinhVien
    {
        DAL_QLSinhVien dal_qlsv = new DAL_QLSinhVien();
        public DataTable layBangLop()
        {
            return dal_qlsv.layBangLop();
        }

        public DataTable layBangQLSinhVien()
        {
            return dal_qlsv.layBangQLSinhVien();
        }

        public bool chenDuLieuVaoBangTaiKhoan(DTO_DNDangNhap dto_dn)
        {
            return dal_qlsv.chenDuLieuVaoBangTaiKhoan(dto_dn);
        }
        public bool chenDuLieuQLSinhVien(DTO_QLSV_TTSV dto_sv)
        {
            return dal_qlsv.chenDuLieuQLSinhVien(dto_sv);
        }

        public bool suaDuLieuBangQLSinhVien(DTO_QLSV_TTSV dto_sv)
        {
            return dal_qlsv.suaDuLieuBangQLSinhVien(dto_sv);
        }

        public bool xoaSinhVienVaTK(DTO_QLSV_TTSV dto_sv)
        {
            return dal_qlsv.xoaSinhVienVaTK(dto_sv);
        }

        public DataTable timKiem(string chuoi)
        {
            return dal_qlsv.timKiem(chuoi);
        }
    }
}
