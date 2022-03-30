using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeChoHang : Xe
    {
        double soTan;
        public double SoTan
        {
            get { return soTan;}
            set { soTan = value; }
        }
        public XeChoHang() 
        { }
        public XeChoHang(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang, double soTan) : base(bienSo, tenXe, trongTai, ngayDangKiem, tieuChuanBang)
        {
            this.SoTan = soTan;
        }
        public override void Nhap()
        {
            Console.WriteLine("-----------------------------Nhập thông tin xe CHO HANG-----------------");
            base.Nhap();
            Console.Write("Nhập số tấn: "); this.SoTan = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("------&&--&&-------&&--&&---&&----------Xuất thông tin xe CHO HANG----------&&--&&---&&----------");
            base.Xuat();
            Console.WriteLine("Số tấn là: {0}", this.SoTan); 
        }
    }
}
