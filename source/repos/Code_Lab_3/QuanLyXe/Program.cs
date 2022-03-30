using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class Program
    {
        static void Main(string[] args)
        {
            //DANHSACHXE DS = new DANHSACHXE();
            //DS.Nhap();
            //DS.Xuat();
            //DS.Tim();                                        ////////// Cách 1
            //Console.WriteLine("Nhập biển số cần tìm");                 //////////    Cách 2 chưa hòan thiện
            //string bienso = Console.ReadLine();
            //DS.Tim(bienso);
            //DS.Tim(bienso).Xuat();  

            //DS.Xoa();
            //DS.Xuat();
            //HopDongChoThue HDCT = new HopDongChoThue();
            //HDCT.Nhap();
            //HDCT.Xuat();
            SoHopDong SHD = new SoHopDong();
            SHD.Nhap();
            //SHD.Tim();
           // SHD.Xuat();
           // SHD.Xoa();
           // SHD.Xoa_Xuat();
            Console.WriteLine("**************Chương trình kết thúc**************"); 
            Console.ReadLine();
        }
    }
}
