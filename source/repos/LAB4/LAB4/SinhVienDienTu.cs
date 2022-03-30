using System;

namespace LAB4
{
    class SinhVienDienTu : SinhVien
    {
        double DiemEE200, DiemEE201, DiemEE205;
        public SinhVienDienTu() : base()
        {
        }
        public SinhVienDienTu(string mssv, string hoten, string diachi, DateTime ngaysinh, double DiemEE200, double DiemEE201, double DiemEE205) 
            : base(mssv, hoten, diachi, ngaysinh)
        {
            this.DiemEE200 = DiemEE200;
            this.DiemEE201 = DiemEE201;
            this.DiemEE205 = DiemEE205;
        }
        public double DiemEE2001 { get => DiemEE200; set => DiemEE200 = value; }
        public double DiemEE2011 { get => DiemEE201; set => DiemEE201 = value; }
        public double DiemEE2051 { get => DiemEE205; set => DiemEE205 = value; }
        public override double diemTB()
        {
            return (DiemEE200 + DiemEE201 + DiemEE205) / 3;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhập điểm EE200: "); DiemEE200 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm EE201: "); DiemEE201 = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm EE205: "); DiemEE205 = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("----------Sinh viên điện tử----------");
            base.xuat();
            Console.WriteLine("Điểm EE200: " + DiemEE200);
            Console.WriteLine("Điểm EE201: " + DiemEE201);
            Console.WriteLine("Điểm EE205: " + DiemEE205);
            Console.WriteLine("Điểm trung bình là: " + this.diemTB());
            Console.WriteLine("Xếp loại: " + base.tinhXepLoai());
        }
    }
}
