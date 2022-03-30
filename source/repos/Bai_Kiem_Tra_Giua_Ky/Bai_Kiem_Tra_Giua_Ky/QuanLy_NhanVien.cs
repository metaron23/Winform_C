using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Kiem_Tra_Giua_Ky
{
    internal class QuanLy_NhanVien
    {
        Dictionary<string, NhanVien> ds = new Dictionary<string, NhanVien>();
        public void Nhap()
        {
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát!\nNhập\"H\" để nhập nhân viên hợp đồng!\nNhập\"B\" để nhập nhân biên chế!");
                String option = Console.ReadLine().ToUpper();
                if (option == "0") break;
                if(option == "H")
                {
                    NhanVien a = new NhanVien_HopDong();
                    while (true)
                    {
                        try
                        {
                            a.Nhap();
                            ds.Add(a.Manv, a);
                            break;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Nhập lỗi! Mời nhập lại!");
                        }
                    }                    
                }
                if (option == "B")
                {
                    NhanVien a = new NhanVien_BienChe();
                    while (true)
                    {
                        try
                        {
                            a.Nhap();
                            ds.Add(a.Manv, a);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Nhập lỗi! Mời nhập lại!");
                        }
                    }                    
                }
            }                    
        }
        public void Xuat()
        {
            foreach(NhanVien a in ds.Values)
            {
                a.Xuat();
            }
        }
        public void Tim_NhanVien()
        {
            Console.Write("Nhập vào mã nhân viên cần tìm: ");
            String manv_tim = Console.ReadLine();
            foreach(NhanVien a in ds.Values)
            {
                if (a.Manv == manv_tim)
                {
                    Console.WriteLine("Có nhân viên cần tìm!");
                    a.Xuat();
                    break;
                }else
                {
                    Console.WriteLine("Nhân viên này không có trong danh sách!");
                }
            }
        }
        public void Xoa_NhanVien()
        {
            Console.Write("Nhập vào mã nhân viên cần xoá: ");
            String manv_xoa = Console.ReadLine();
            int check = 0;
            foreach (NhanVien a in ds.Values)
            {
                if (a.Manv == manv_xoa)
                {                    
                    ds.Remove(manv_xoa);
                    check = 1;
                    break;
                }                
            }
            if (check == 1)
            {
                Console.WriteLine("Có mã nhân viên cần xoá và đây là Danh sách sau khi xoá!");
                this.Xuat();
            }
            if (check == 0)
            {
                Console.WriteLine("Không có nhân viên cần xoá!");
            }
        }
        public void Tong_QuyLuong()
        {
            float s = 0;
            foreach(NhanVien a in ds.Values)
            {
                if(a is NhanVien_HopDong)
                {
                    s = s + ((NhanVien_HopDong)a).ThucLinh();
                }
                if (a is NhanVien_BienChe)
                {
                    s = s + ((NhanVien_BienChe)a).ThucLinh();
                }
            }
            Console.WriteLine("Tổng quỹ lương của tất cả nhân viên là: {0}",s);
        }
        public void TimNV_MayMan()
        {
            Console.Write("Nhập vào mã nhân viên may mắn: ");
            String manv_mayman = Console.ReadLine();
            int check = 0;
            foreach(NhanVien a in ds.Values)
            {
                if(a.Manv == manv_mayman)
                {
                    check = 1;
                    Console.WriteLine("Có mã nhân viên may mắn và thông tin nhân viên đó là: ");
                    a.Xuat();
                    if(a is NhanVien_HopDong)
                    {
                        if (((NhanVien_HopDong)a).TinhThamNien() > 10)
                        {
                            Console.WriteLine("Số tiền thưởng của nhân viên là: {0}", 1000000);
                            break;
                        }
                        if (((NhanVien_HopDong)a).TinhThamNien() > 5)
                        {
                            Console.WriteLine("Số tiền thưởng của nhân viên là: {0}", 500000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nhân viên may mắn - Không có thưởng!");
                            break;
                        }
                    }
                    if (a is NhanVien_BienChe)
                    {
                        if (((NhanVien_BienChe)a).TinhThamNien() <3)
                        {
                            Console.WriteLine("Số tiền thưởng của nhân viên là: {0}", 500000);
                            break;
                        }else
                        {
                            Console.WriteLine("Nhân viên may mắn - Không có thưởng!");
                            break;
                        }
                    }                    
                }
            }
            if(check == 0)
            {
                Console.WriteLine("Không có mã nhân viên may mắn trong danh sách!");
            }
        }
    }
}
