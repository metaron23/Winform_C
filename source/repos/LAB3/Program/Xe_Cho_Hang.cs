using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Xe_Cho_Hang : Xe
    {
        private double so_tan;
        public double So_tan { get => so_tan; set => so_tan = value; }
        public Xe_Cho_Hang() : base() { }
        public Xe_Cho_Hang(string bien_so, string ten_xe, int trong_tai, DateTime ngay_dang_kiem, int tieu_chuan,double so_tan) 
            : base(bien_so, ten_xe, trong_tai, ngay_dang_kiem, tieu_chuan)
        {
            this.so_tan = so_tan;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập số tấn: ");
            so_tan = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Số tấn: {0}", so_tan);
        }
    }
}
