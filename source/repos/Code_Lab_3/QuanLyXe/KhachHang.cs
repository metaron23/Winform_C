using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class KhachHang : Nguoi
    {
        string maKhachHang;

        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }
        DateTime hangBangLai;

        public DateTime HangBangLai
        {
            get { return hangBangLai; }
            set { hangBangLai = value; }
        }
        public override void Nhap()
        {
            Console.WriteLine("-----------------------------------------------Nhập thông tin khách hàng ---------------------");
            Console.Write("Nhập số CM: "); this.SoChungMinh = long.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: "); this.HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: "); this.DiaChi = Console.ReadLine();
            Console.Write("Nhập số điện thoại: "); this.DienThoai = Console.ReadLine();
            Console.Write("Nhập mã khách hàng: ");  this.MaKhachHang = Console.ReadLine();
            Console.Write("Nhập ngày hạng bằng lái: "); HangBangLai = DateTime.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("------------&&--&&-------&&--&&-----------------Xuất thông tin khách hàng -------------------------");
            Console.WriteLine("Số CM là: {0}", this.SoChungMinh);
            Console.WriteLine("Họ tên là: {0}", this.HoTen);
            Console.WriteLine("Địa chỉ là:" + this.DiaChi);
            Console.WriteLine("Số điện thoại là: " + this.DienThoai);
            Console.WriteLine("Mã khách hàng là: " + this.MaKhachHang);
            Console.WriteLine("Ngày hạng bằng lái là: " + this.HangBangLai);
            //Console.WriteLine(string.Format("Ngày hạng bằng lái là: {0: dd/MM/yyyy}", Hangbanglai));
        }
    }
}
