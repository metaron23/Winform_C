using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SVSinhVien
    {
        private string masv;
        private string tensv;
        private DateTime ngaysinh;
        private bool phai;
        private string diachi;
        private string sdt;
        private string tenlop;
        private string hinhanh;

        public DTO_SVSinhVien()
        {
        }

        public DTO_SVSinhVien(string masv, string tensv, DateTime ngaysinh, bool phai, string diachi, string sdt, string tenlop, string hinhanh)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.ngaysinh = ngaysinh;
            this.phai = phai;
            this.diachi = diachi;
            this.sdt = sdt;
            this.tenlop = tenlop;
            this.hinhanh = hinhanh;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public bool Phai { get => phai; set => phai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
    }
}
