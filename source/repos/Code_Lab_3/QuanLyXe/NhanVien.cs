using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class NhanVien : Nguoi
    {
        string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        DateTime ngayVaoCoQuan;
        public DateTime NgayVaoCoQuan
        {
            get { return ngayVaoCoQuan; }
            set { ngayVaoCoQuan = value; }
        }
        public NhanVien()
        { }
        public NhanVien(long soChungMinh, string hoTen, String diaChi, string dienThoai, string maNhanVien, DateTime ngayVaoCoQuan)
            : base(soChungMinh, hoTen, diaChi, dienThoai) 
        {
            this.MaNhanVien = maNhanVien;
            this.NgayVaoCoQuan = ngayVaoCoQuan;
        }
        public override void Nhap()
        {
            Console.WriteLine("--------------------------Nhập thông tin nhân viên--------------------------------");
            Console.Write("Nhập số CM: "); this.SoChungMinh = long.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên: "); this.HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: "); this.DiaChi = Console.ReadLine();
            Console.Write("Nhập số điện thoại: "); this.DienThoai = Console.ReadLine();
            Console.Write("Nhập mã nhân viên: "); this.MaNhanVien = Console.ReadLine();
            Console.Write("Nhập ngày vào cơ quan: "); this.NgayVaoCoQuan = DateTime.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("---------&&--&&-------&&--&&---------Xuất thông tin nhân viên--------------------------------");
            Console.WriteLine("Số CM là: {0}", this.SoChungMinh);
            Console.WriteLine("Họ tên là: {0}", this.HoTen);
            Console.WriteLine("Địa chỉ là:" + this.DiaChi);
            Console.WriteLine("Số điện thoại là: " + this.DienThoai);
            Console.WriteLine("Mã nhân viên là: " + this.MaNhanVien);
            Console.WriteLine("Ngày vào cơ quan: " + this.NgayVaoCoQuan);
            Console.WriteLine(string.Format("Ngày vào cơ quan là: {0: dd/MM/yyyy}", this.NgayVaoCoQuan));
        }   
    }
}
