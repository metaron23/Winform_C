using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Xe_Du_Lich:Xe
    {
        private int so_cho_ngoi;
        public Xe_Du_Lich():base()
        {
        }
        public Xe_Du_Lich(string bien_so, string ten_xe, int trong_tai, DateTime ngay_dang_kiem, int tieu_chuan, int so_cho_ngoi) 
            : base(bien_so, ten_xe, trong_tai, ngay_dang_kiem, tieu_chuan)
        {
            this.so_cho_ngoi = so_cho_ngoi;
        }
        public int So_cho_ngoi { get => so_cho_ngoi; set => so_cho_ngoi = value; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập số chỗ ngồi: ");
            So_cho_ngoi = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Số chỗ ngồi: {0}",So_cho_ngoi);
        }
    }
}
