using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    abstract class SinhVien
    {
        String mssv;
        public string Mssv { get => mssv; set => mssv = value; }
        String hoten;
        public string Hoten { get => hoten; set => hoten = value; }
        String diachi;
        public string Diachi { get => diachi; set => diachi = value; }
        DateTime ngaysinh;      
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public SinhVien()
        {
        }
        public SinhVien(string mssv, string hoten, string diachi, DateTime ngaysinh)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
        }
        abstract public double diemTB();
        public String tinhXepLoai()
        {
            if (diemTB() >= 8)
            {
                return "Giỏi";
            }
            if (diemTB() >= 6.5)
            {
                return "Khá";
            }
            if (diemTB() >= 6)
            {
                return "Trung Bình";
            }
            return "Yếu";
        }
        public virtual void nhap()
        {
            Console.Write("Nhập MSSV: "); mssv = Console.ReadLine();
            Console.Write("Nhập họ tên SV: "); Hoten = Console.ReadLine();
            Console.Write("Nhập địa chỉ SV: "); diachi = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Nhập ngày sinh theo dạng \"dd/mm/yyyy\": "); ngaysinh = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nhập sai định dạng!");
                }
            }            
        }
        public virtual void xuat()
        {
            Console.WriteLine("Mã số: "+mssv);
            Console.WriteLine("Họ tên: "+hoten);
            Console.WriteLine("Địa chỉ: "+diachi);
            Console.WriteLine(String.Format("Ngày sinh: {0: DD/MM/YYYY}",ngaysinh));
        }
    }
}
