using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class SinhVienKCNTT : SinhVien
    {
        double DiemCS414, DiemIS311, DiemCS311;
        public SinhVienKCNTT():base()
        {
        }
        public SinhVienKCNTT(string mssv, string hoten, string diachi, DateTime ngaysinh, double DiemCS414, double DiemIS311, double DiemCS311) 
            : base(mssv, hoten, diachi, ngaysinh)
        {
            this.DiemCS414 = DiemCS414;
            this.DiemCS311 = DiemCS311;
            this.DiemIS311 = DiemIS311;
        }
        public double DiemCS4141 { get => DiemCS414; set => DiemCS414 = value; }
        public double DiemIS3111 { get => DiemIS311; set => DiemIS311 = value; }
        public double DiemCS3111 { get => DiemCS311; set => DiemCS311 = value; }

        public override double diemTB()
        {
            return (DiemCS311 + DiemCS414 + DiemIS311) / 3;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập điểm CS414: "); DiemCS414 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm IS311: "); DiemIS311 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm CS311: "); DiemCS311 = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("----------Sinh viên CNTT----------");
            base.xuat();
            Console.WriteLine("Điểm CS414: " + DiemCS414);
            Console.WriteLine("Điểm IS311: " + DiemIS311);
            Console.WriteLine("Điểm CS311: " + DiemCS311);
            Console.WriteLine("Điểm trung bình là: " + this.diemTB());
            Console.WriteLine("Xếp loại: " + base.tinhXepLoai());
        }
    }
}
