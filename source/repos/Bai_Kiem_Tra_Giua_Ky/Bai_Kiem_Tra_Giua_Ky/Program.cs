using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Kiem_Tra_Giua_Ky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            QuanLy_NhanVien a = new QuanLy_NhanVien();
            a.Nhap();
            a.Xuat();
            a.Tim_NhanVien();
            a.Xoa_NhanVien();
            a.Tong_QuyLuong();
            a.TimNV_MayMan();
            Console.ReadLine();
        }
    }
}
