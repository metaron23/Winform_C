using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Quan_Ly_Xe a = new Quan_Ly_Xe();
            Console.WriteLine("0.Thoát\n1. Nhập danh sách\n2. Xuất danh sách\n3. Tìm xe theo mã\n4. Xoá xe theo mã");
            int check = 0;            
            while (true)
            {
                Console.Write("Nhập số: ");
                check = int.Parse(Console.ReadLine());
                if (check == 0)
                {
                    break;
                }
                if(check == 1)
                {
                    a.nhap();
                }
                if (check == 2)
                {
                    a.xuatDS();
                }
                if (check == 3)
                {
                    a.timXe();
                }
                if (check == 4)
                {
                    a.xoaXe();
                }
            }                                        
            Console.ReadLine();
        }
    }
}
