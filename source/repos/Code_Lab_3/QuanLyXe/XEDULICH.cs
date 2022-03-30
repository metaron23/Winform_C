using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeDuLich : Xe
    {
        int soChoNgoi;
        public int SoChoNgoi
        {
            get { return soChoNgoi;}
            set { soChoNgoi = value; }
        }
        public XeDuLich() 
        { }
        public XeDuLich(string Bienso, string Tenxe, int Trongtai, DateTime Ngaydangkiem, int Tieuchuanbang, int Sochongoi) : base(Bienso, Tenxe, Trongtai, Ngaydangkiem, Tieuchuanbang)
        {
            this.SoChoNgoi = soChoNgoi;
        }
        public override void Nhap()
        {
            Console.WriteLine("------------------------------Nhập thông tin xe DU LỊCH------------------");
            base.Nhap();
            Console.Write("Nhập số chỗ ngồi: "); this.SoChoNgoi = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("--&&--&&---&&-----&&--&&-------&&--&&-------Xuất thông tin xe DU LỊCH----------&&--&&---&&----------");
            base.Xuat();
            Console.WriteLine("Số chỗ ngồi là: {0}", this.SoChoNgoi); 
        }
    }
}
