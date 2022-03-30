using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    abstract class Nguoi
    {
        long soChungMinh;
        public long SoChungMinh
        {
            get { return soChungMinh; }
            set { soChungMinh = value; }
        }
        string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        string dienThoai;
        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }             
        }
        public Nguoi()
        { }
        public Nguoi(long soChungMinh, string hoTen, String diaChi, string dienThoai)
        {
            this.SoChungMinh = soChungMinh;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }
        abstract public void Nhap();
        abstract public void Xuat();

    }
}
