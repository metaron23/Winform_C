using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Kiem_Tra_Giua_Ky
{
    internal class NhanVien_HopDong:NhanVien,ILuong
    {
        float mucluong;
        public NhanVien_HopDong() : base()
        {
        }
        public NhanVien_HopDong(string manv, string hoten, DateTime ngaysinh, string gioitinh, string cmnd, DateTime ngayvaolam,
            float mucluong) : base(manv, hoten, ngaysinh, gioitinh, cmnd, ngayvaolam)
        {
        }
        public float Mucluong { get => mucluong; set => mucluong = value; }
        public override void Nhap()
        {
            base.Nhap();
            while (true)
            {
                try
                {
                    Console.Write("Nhập mức lương: "); this.mucluong = float.Parse(Console.ReadLine());
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
            Console.WriteLine("----------Nhân viên hợp đồng----------");
            base.Xuat();
            Console.WriteLine("Mức lương là: {0}", this.mucluong);
            Console.WriteLine("Thâm niên là: {0}", TinhThamNien());
            Console.WriteLine("Phụ cấp là: {0}", TinhPhuCap());
            Console.WriteLine("Thực Lĩnh là: {0}", ThucLinh());
        }
        public override int TinhThamNien()
        {
            return DateTime.Today.Year - base.Ngayvaolam.Year + 1;
        }

        public float TinhPhuCap()
        {
            return mucluong / 10;
        }

        public float ThucLinh()
        {
            return mucluong + TinhPhuCap();
        }
    }
}
