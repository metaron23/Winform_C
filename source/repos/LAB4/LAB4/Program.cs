using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            QuanLySinhVien a = new QuanLySinhVien();
            a.nhap();
            a.xuat();
            Console.WriteLine("Số học sinh giỏi là: "+a.demSinhVien("giỏi"));
            Console.ReadKey();
        }
    }
}
