using System;

namespace DTO
{
    public class DTO_QLSV_TTSV
    {
        private string masv;
        private string tensv;
        private DateTime ngaysinh;
        private bool phai;
        private string diachi;
        private string sdt;
        private string malop;
        private string matk;
        public DTO_QLSV_TTSV()
        {
        }
        public DTO_QLSV_TTSV(string masv, string tensv, DateTime ngaysinh, bool phai, string diachi, string sdt, string malop, string matk)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.ngaysinh = ngaysinh;
            this.phai = phai;
            this.diachi = diachi;
            this.sdt = sdt;
            this.malop = malop;
            this.matk = matk;
        }
        public string Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public bool Phai { get => phai; set => phai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Matk { get => matk; set => matk = value; }
    }
}
