using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Kiem_Tra_Giua_Ky
{
    abstract class NhanVien
    {
        String manv, hoten;
        DateTime ngaysinh;
        String gioitinh, cmnd;
        DateTime ngayvaolam;
        public NhanVien()
        {
        }
        public NhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, string cmnd, DateTime ngayvaolam)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.ngayvaolam = ngayvaolam;
        }
        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mã nhân viên: "); this.manv = Console.ReadLine();
            Console.Write("Nhập họ tên : "); this.hoten = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Nhập ngày sinh: "); this.ngaysinh = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhập lỗi! Mời nhập lại!");
                }
            }            
            Console.Write("Nhập giới tính (nam hoặc nữ): "); this.gioitinh = Console.ReadLine();
            Console.Write("Nhập CMND: "); this.cmnd = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Nhập ngày vào làm: "); this.ngayvaolam = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhập lỗi! Mời nhập lại!");
                }
            }            
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mã nhân viên là: {0}", this.manv);
            Console.WriteLine("Họ tên nhân viên là: {0}", this.hoten);
            Console.WriteLine(string.Format("Ngày sinh là: {0: dd/MM/yyyy}", this.ngaysinh));                        
            Console.WriteLine("Giới tính là: {0}", this.gioitinh);
            Console.WriteLine("CMND là: {0}", this.cmnd);
            Console.WriteLine(string.Format("Ngày vào làm là: {0: dd/MM/yyyy}", this.ngayvaolam));                                  
        }
        abstract public int TinhThamNien();
    }
}
