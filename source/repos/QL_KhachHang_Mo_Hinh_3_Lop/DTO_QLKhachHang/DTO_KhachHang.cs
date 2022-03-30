using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        private string _KHACHHANG_MAKH;
        private string _KHACHHANG_TENKH;
        private DateTime _KHACHHANG_NGAYMUAHANG;
        private string _KHACHHANG_HINHANH;
        private string _KHACHHANG_MAHANG;
        private int _KHACHHANG_SOLUONG;
        private string _KHACHHANG_MATINH;
        public DTO_KhachHang()
        {
        }
        public DTO_KhachHang(string kHACHHANG_MAKH, string kHACHHANG_TENKH, DateTime kHACHHANG_NGAYMUAHANG, 
            string kHACHHANG_HINHANH, string kHACHHANG_MAHANG, int kHACHHANG_SOLUONG, string kHACHHANG_MATINH)
        {
            _KHACHHANG_MAKH = kHACHHANG_MAKH;
            _KHACHHANG_TENKH = kHACHHANG_TENKH;
            _KHACHHANG_NGAYMUAHANG = kHACHHANG_NGAYMUAHANG;
            _KHACHHANG_HINHANH = kHACHHANG_HINHANH;
            _KHACHHANG_MAHANG = kHACHHANG_MAHANG;
            _KHACHHANG_SOLUONG = kHACHHANG_SOLUONG;
            _KHACHHANG_MATINH = kHACHHANG_MATINH;
        }
        public string KHACHHANG_MAKH { get => _KHACHHANG_MAKH; set => _KHACHHANG_MAKH = value; }
        public string KHACHHANG_TENKH { get => _KHACHHANG_TENKH; set => _KHACHHANG_TENKH = value; }
        public DateTime KHACHHANG_NGAYMUAHANG { get => _KHACHHANG_NGAYMUAHANG; set => _KHACHHANG_NGAYMUAHANG = value; }
        public string KHACHHANG_HINHANH { get => _KHACHHANG_HINHANH; set => _KHACHHANG_HINHANH = value; }
        public string KHACHHANG_MAHANG { get => _KHACHHANG_MAHANG; set => _KHACHHANG_MAHANG = value; }
        public int KHACHHANG_SOLUONG { get => _KHACHHANG_SOLUONG; set => _KHACHHANG_SOLUONG = value; }
        public string KHACHHANG_MATINH { get => _KHACHHANG_MATINH; set => _KHACHHANG_MATINH = value; }

    }
}
