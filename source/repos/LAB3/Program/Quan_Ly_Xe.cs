using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Quan_Ly_Xe
    {
        Dictionary<string, Xe> ds = new Dictionary<string, Xe>();
        public void nhap()
        {
            while (true)
            {
                Console.WriteLine("Nhap 0 de thoat___ Nhap H cho Xe Cho Hang___ Nhap D cho Xe Du Lich");
                string n = Console.ReadLine().ToUpper();
                if (n == "0") break;
                if (n == "H")
                {
                    Console.WriteLine("Nhập thông tin xe chở hàng!");
                    Xe xch = new Xe_Cho_Hang();
                    xch.nhap();
                    ds.Add(xch.Bien_so, xch);
                }
                if (n == "D")
                {
                    Console.WriteLine("Nhập thông tin xe du lịch!");
                    Xe xdl = new Xe_Du_Lich();
                    xdl.nhap();
                    ds.Add(xdl.Bien_so, xdl);
                }
            }
        }
        public void xuatDS()
        {
            foreach (Xe item in ds.Values)
            {
                item.xuat();
            }
        }
        public void timXe()
        {
            Console.Write("Nhập biển số xe cần tìm: ");
            string bs_can_tim = Console.ReadLine();
            int tim = 0;
            Xe timXe = null;
            foreach (Xe item in ds.Values)
            {
                if (item.Bien_so == bs_can_tim)
                {
                    Console.WriteLine("Có biển số cần tìm!");
                    tim = 1;
                    timXe = item;
                }
            }
            if (tim == 0)
                Console.WriteLine("Không có biển số cần tìm!");
            if (tim == 1) timXe.xuat();
        }
        public void xoaXe()
        {
            Console.Write("Nhập biển số xe cần xoá: ");
            string bs_can_xoa = Console.ReadLine();
            int tim = 0;
            foreach (Xe item in ds.Values)
            {
                if (item.Bien_so == bs_can_xoa)
                {
                    Console.WriteLine("Có biển số cần xoá!");
                    this.ds.Remove(bs_can_xoa);
                    tim += 1;
                }
            }
            if (tim == 0)
                Console.WriteLine("Không có biển số cần xoá!");
        }
    }
}
