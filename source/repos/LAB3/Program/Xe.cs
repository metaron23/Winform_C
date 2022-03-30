using System;

namespace Program
{
    internal class  Xe
    {
        private String bien_so;
        private String ten_xe;
        private int trong_tai;
        private DateTime ngay_dang_kiem;
        private int tieu_chuan;
        public Xe()
        {
        }
        public Xe(string bien_so, string ten_xe, int trong_tai, DateTime ngay_dang_kiem, int tieu_chuan)
        {
            this.bien_so = bien_so;
            this.ten_xe = ten_xe;
            this.trong_tai = trong_tai;
            this.ngay_dang_kiem = ngay_dang_kiem;
            this.tieu_chuan = tieu_chuan;
        }
        public virtual void nhap()
        {
            Console.Write("Nhập biển số: "); bien_so = Console.ReadLine();
            Console.Write("Nhập tên xe: "); ten_xe = Console.ReadLine();
            Console.Write("Nhập trọng tải: "); trong_tai = int.Parse(Console.ReadLine());
            Console.Write("Nhập ngày đăng kiểm: "); ngay_dang_kiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập tiêu chuẩn: "); tieu_chuan = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Biển số: {0}\nTên xe: {1}\nTrọng tải: {2}\nNgày đăng kiểm: {3}\nTiêu chuẩn: {4}",
                bien_so,ten_xe,trong_tai,ngay_dang_kiem.ToShortDateString(),tieu_chuan);
        }
        //get-set
        public string Bien_so { get => bien_so; set => bien_so = value; }
        public string Ten_xe { get => ten_xe; set => ten_xe = value; }
        public int Trong_tai { get => trong_tai; set => trong_tai = value; }
        public DateTime Ngay_dang_kiem { get => ngay_dang_kiem; set => ngay_dang_kiem = value; }
        public int Tieu_chuan { get => tieu_chuan; set => tieu_chuan = value; }
    }
}
