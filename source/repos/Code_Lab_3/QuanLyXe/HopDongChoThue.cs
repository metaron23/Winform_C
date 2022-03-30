using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class HopDongChoThue
    {
        string soHopDong;

        public string SoHopDong
        {
            get { return soHopDong; }
            set { soHopDong = value; }
        }
        Xe xe;

        internal Xe Xe
        {
            get { return xe; }
            set { xe = value; }
        }

      
        Nguoi NhanVien;

        internal Nguoi NhanVien1
        {
            get { return NhanVien; }
            set { NhanVien = value; }
        }
        Nguoi KhachHang;

        internal Nguoi KhachHang1
        {
            get { return KhachHang; }
            set { KhachHang = value; }
        }
        int soNgayThue;

        public int SoNgayThue
        {
            get { return soNgayThue; }
            set { soNgayThue = value; }
        }
        double donGia;

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        DateTime ngayThue;

        public DateTime NgayThue
        {
            get { return ngayThue; }
            set { ngayThue = value; }
        }

        int h = 0;
        public void Nhap()
        {
            QuanLyXe quanlyxe = new QuanLyXe();
            quanlyxe.Nhap();
            quanlyxe.Xuat();
            quanlyxe.Tim();
            quanlyxe.Xoa();
            Xe = quanlyxe.Tim(); ///  Xe ở đây là để xác định giá trị của xe nào được tìm thấy (return xe) ở phương thức Tim() của lớp DANHSACHXE để 
                                        //đưa giá trị Xe vào phương thức ThanhTien(), nếu ko thì Xe ở phương thức ThanhTien = Null -> tính ko đc                                         
            
            if(quanlyxe.KiemTraTim() == true)            // Nếu tìm có biển số xe ở lớp DANHSACHXE thì mới nhập Nhân viên và Khách hàng
            {
                Console.WriteLine("---------------------------- Thông tin về HỢP ĐỒNG CHO THUÊ---------------");
                h = 1;
                NhanVien1 = new NhanVien();
                KhachHang1 = new KhachHang();
                NhanVien1.Nhap();
                KhachHang1.Nhap();
                Console.Write("Nhập sổ hợp đồng: "); this.SoHopDong = Console.ReadLine();
                Console.Write("Nhập số ngày thuê: "); this.SoNgayThue = int.Parse(Console.ReadLine());
                Console.Write("Nhập ngày thuê: "); this.NgayThue = DateTime.Parse(Console.ReadLine());
            }
            else {
                h = 0;  
            }
        }
        public bool KiemtraHopDong()
        {
            if (h == 1) return true;
            else return false;
        }
        public double ThanhTien()
        {    // nếu lúc này có nhiều xe thì dùng foreach (vì ở đây là tính tiền 1 xe)
            if (Xe is XeDuLich)
            {                       // lúc này Xe vẫn là XE chứ ko phải là XEDULICH nên phải Dowcasting,  // Vì item đang là đối tượng thuộc lớp cha (SinhVien) cho nên chúng ta phải dowcating
                // ép từ kiểu cha xuống kiểu con thì mới gọi được giá trị của phương thức của lớp con
                if (((XeDuLich)Xe).SoChoNgoi <= 5) { DonGia = 50000; }
                else if (((XeDuLich)Xe).SoChoNgoi <= 7) { DonGia = 70000; }
                else DonGia = 100000;
            }
            if (xe is XeChoHang)
            {
                DonGia = 500000;
            }
            return DonGia * SoNgayThue;
        }
        public void Xuat()
        {
            Console.WriteLine("**********************************************Thành tiền là: {0} *******************", this.ThanhTien());
            Console.WriteLine(" ----------------THÔNG TIN HỢP ĐỒNG CHO THUÊ-------------");
            Xe.Xuat();          // Chỉ xuất thông tin xe cho thuê, nếu để quanlyxe.Xuat() thì sẽ xuất ra tất cả xe       
            NhanVien1.Xuat();
            KhachHang1.Xuat();
            Console.WriteLine("Sổ hợp đồng là: {0}", this.SoHopDong);
            Console.WriteLine("Số ngày thuê là: {0}", this.SoNgayThue);
            Console.WriteLine("Ngày thuê là: {0}", this.NgayThue);
        }
    }
}
