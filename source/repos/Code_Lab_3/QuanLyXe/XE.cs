using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class Xe
    {
        //Ở lớp CHA, lúc khia báo các trường thì ko nên để protected bởi vì sẽ bị lỗi khi ta đưa trường đó vào phương thức chứa Dictionary, bởi vì protected chỉ gọi đc ở phương thức cha con. 
        string bienSo;

        public string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }
        string tenXe;

        public string TenXe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }
        int trongTai;

        public int TrongTai
        {
            get { return trongTai; }
            set { trongTai = value; }
        }
        DateTime ngayDangKiem;

        public DateTime NgayDangKiem
        {
            get { return ngayDangKiem; }
            set { ngayDangKiem = value; }
        }
        int tieuChuanBang;

        public int TieuChuanBang
        {
            get { return tieuChuanBang; }
            set { tieuChuanBang = value; }
        }
        public Xe()
        { }
        public Xe(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang)
        {
            this.BienSo = bienSo;
            this.TenXe = tenXe;
            this.TrongTai = trongTai;
            this.NgayDangKiem = ngayDangKiem;
            this.TieuChuanBang = tieuChuanBang;
        }
        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập biển số: "); this.BienSo = Console.ReadLine();
            Console.Write("Nhập tên xe: "); this.TenXe = Console.ReadLine();
            Console.Write("Nhập trọng tải: "); this.TrongTai = int.Parse(Console.ReadLine());
            Console.Write("Nhập ngày đăng kiểm: "); this.NgayDangKiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập tiêu chuẩn bằng: "); this.TieuChuanBang = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Biển số là: {0}", this.BienSo);
            Console.WriteLine("Tên xe là: {0}", this.TenXe);
            Console.WriteLine("Trọng tải là: {0}", this.TrongTai);
            //Console.WriteLine("Ngày đăng kiểm là: {0}", this.NgayDangKiem);
            Console.WriteLine(string.Format("Ngày đăng kiểm là: {0: dd/MM/yyyy}", this.NgayDangKiem));
            Console.WriteLine("Tiêu chuẩn bằng là: {0}", this.TieuChuanBang);
        }

    }
}
