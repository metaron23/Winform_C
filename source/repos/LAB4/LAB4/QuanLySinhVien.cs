using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class QuanLySinhVien
    {
        Dictionary<string, SinhVien> ds = new Dictionary<string, SinhVien>();
        public void nhap()
        {
            while (true)
            {
                Console.WriteLine("Nhập \"0\" để Thoát! Nhập \"D\" để nhập sinh viên điện tử! Nhập " +
                    "\"C\" để nhập sinh viên công nghệ thông tin1");
                String option = Console.ReadLine().ToUpper();
                if (option == "0") break;
                if (option == "C")
                {
                    SinhVien x = new SinhVienKCNTT();
                    while (true)
                    {
                        try
                        {
                            x.nhap();
                            ds.Add(x.Mssv,x);
                            break;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Nhập bị lỗi hoặc trùng mã!");
                        }                        
                    }
                }
                if (option == "D")
                {
                    SinhVien x = new SinhVienDienTu();
                    while (true)
                    {
                        try
                        {
                            x.nhap();
                            ds.Add(x.Mssv, x);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Nhập bị lỗi hoặc trùng mã!");
                        }
                    }
                }
            }
        }
        public void xuat()
        {
            foreach(SinhVien x in ds.Values)
            {
                x.xuat();
            }
        }
        public int demSinhVien(String xeploai)
        {
            int dem = 0;
            foreach(SinhVien x in ds.Values)
            {
                if (x.tinhXepLoai().ToLower().Equals(xeploai))
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
