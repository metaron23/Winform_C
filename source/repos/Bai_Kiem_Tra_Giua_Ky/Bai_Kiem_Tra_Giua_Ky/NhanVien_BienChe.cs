using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Kiem_Tra_Giua_Ky
{
    internal class NhanVien_BienChe : NhanVien,ILuong
    {
        float hesoluong, luongcoban;

        public NhanVien_BienChe():base()
        {
        }
        public NhanVien_BienChe(string manv, string hoten, DateTime ngaysinh, string gioitinh, string cmnd, DateTime ngayvaolam, 
            float hesoluong, float luongcoban) : base(manv, hoten, ngaysinh, gioitinh, cmnd, ngayvaolam)
        {
        }
        public float Hesoluong { get => hesoluong; set => hesoluong = value; }
        public float Luongcoban { get => luongcoban; set => luongcoban = value; }
        public override void Nhap()
        {
            base.Nhap();
            while (true)
            {
                try
                {
                    Console.Write("Nhập hệ số lương: "); this.hesoluong = float.Parse(Console.ReadLine());                    
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhập lỗi! Mời nhập lại!");
                }
            }
            while (true)
            {
                try
                {                    
                    Console.Write("Nhập lương cơ bản : "); this.luongcoban = float.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhập lỗi! Mời nhập lại!");
                }
            }
        }
        public override void Xuat()
        {
            Console.WriteLine("----------Nhân viên biên chế----------");
            base.Xuat();
            Console.WriteLine("Hệ số lương là: {0}", this.hesoluong);
            Console.WriteLine("Lương cơ bản là: {0}", this.luongcoban);
            Console.WriteLine("Thâm niên là: {0}", TinhThamNien());
            Console.WriteLine("Phụ cấp là: {0}", TinhPhuCap());
            Console.WriteLine("Thực Lĩnh là: {0}", ThucLinh());
        }
        public override int TinhThamNien()
        {
            return DateTime.Today.Year - base.Ngayvaolam.Year;
        }

        public float TinhPhuCap()
        {
            return luongcoban / 10;
        }

        public float ThucLinh()
        {
            return (hesoluong * luongcoban) + TinhPhuCap();
        }
    }
}
