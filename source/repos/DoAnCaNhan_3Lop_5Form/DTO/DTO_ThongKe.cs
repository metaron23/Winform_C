namespace DTO
{
    public class DTO_ThongKe
    {
        private string masv;
        private string mamon;
        private float diemlan1;
        private float diemlan2;

        public DTO_ThongKe()
        {
        }

        public DTO_ThongKe(string masv, string mamon, float diemlan1, float diemlan2)
        {
            this.masv = masv;
            this.mamon = mamon;
            this.diemlan1 = diemlan1;
            this.diemlan2 = diemlan2;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Mamon { get => mamon; set => mamon = value; }
        public float Diemlan1 { get => diemlan1; set => diemlan1 = value; }
        public float Diemlan2 { get => diemlan2; set => diemlan2 = value; }
    }
}
