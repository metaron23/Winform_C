using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class SoHopDong
    {
        Dictionary<string, HopDongChoThue> soCai;
        internal Dictionary<string, HopDongChoThue> SoCai
        {
            get { return soCai; }
            set { soCai = value; }
        }
        public SoHopDong()
        {
            soCai = new Dictionary<string, HopDongChoThue>();
        }
        public void Nhap()
        {
            HopDongChoThue HDCT = new HopDongChoThue();
            HDCT.Nhap();
            if (HDCT.KiemtraHopDong() == true)
            {
                this.SoCai.Add(HDCT.SoHopDong, HDCT);
                Console.WriteLine(String.Format("---------------------Da luu hop dong {0}!---------", HDCT.SoHopDong));
                Console.WriteLine("------------------------------------------------Danh sách hợp đồng---------------------");
                foreach (HopDongChoThue item in this.SoCai.Values)
                item.Xuat();
                Tim();         
                Xoa();
       
            }
        }

        
        public void Tim()
        {
            int p = 0;
            Console.WriteLine("*************Nhập SỐ sổ hợp đồng để tìm***************");
            string soHopDong = Console.ReadLine();
            HopDongChoThue HDCT = null;
            foreach(HopDongChoThue item in this.SoCai.Values)
            {
                if (item.SoHopDong == soHopDong)
                {
                    HDCT = item;
                    Console.WriteLine("***************************************Có sổ hợp đồng cần tìm**********************");
                    Console.WriteLine("*******Thông tin hợp đồng cần tìm*******");
                    HDCT.Xuat();
                    p = 1; 
                    break;
                }
                else 
                    p = 0;
            }
            if (p == 0)
                Console.WriteLine("Không có hợp đồng cần tìm");    
        }
        public void Xoa()
        {
            Console.WriteLine("*************Nhập SỐ sổ hợp đồng để Xóa***************");
            string soHopDong = Console.ReadLine();
            if (this.SoCai.ContainsKey(soHopDong))
            {
                this.SoCai.Remove(soHopDong);
                Console.WriteLine("*******Đã xóa sổ hợp đồng********");
            }
            else
            {
                Console.WriteLine("Không có sổ hợp đồng để xóa");
            }
            Console.WriteLine("Danh sách sau khi xóa sổ hợp đồng");
            foreach (HopDongChoThue item in SoCai.Values)                  // ở hàm xuất SoHopDong này phải dùng foreach (HopDongChoThue item in Socai.Values)
            {                                                                // để lấy giá trị của HopDongChoThue
                item.Xuat();
            }
        }
    }
}
