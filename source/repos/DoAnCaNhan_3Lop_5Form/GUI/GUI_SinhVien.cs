using BUS;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_SinhVien : Form
    {
        //khai báo matk, pass để khi GUI_DangNhap truyền dữ liệu qua thì 2 biến này sẽ nhận
        string matk, pass;
        //Khởi tạo bus để nhần data sau khi dal xử lý dữ liệu
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        //Đường dẫn của file ảnh lưu
        string linkAnh = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/HINHANH/";
        //Khi báo biến kiểu DTO_SVSinhVien
        DTO_SVSinhVien dto_sv;
        public GUI_SinhVien()
        {
            InitializeComponent();
        }
        // Tạo dối số để khi gọi từ GUI_DangNhap thì GUI_SinhVien sẽ nhần được tài khoản và mật khẩu từ các text box của bên GUI_DangNhap
        public GUI_SinhVien(string matk1, string pass1)
        {
            InitializeComponent();
            matk = matk1;
            pass = pass1;
        }
        // Xửa lý cho picture box chọn file show lên picture box
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Mời bạn chọn ảnh";
            open.Filter = "Picture File(*.jpg, *.png)|*.jpg;*.png|All File(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
        // Tạo 1 đối tượng DTO_SVSinhVien sinh viên để tiện tạo gói
        public DTO_SVSinhVien taoDTOSinhVien()
        {
            //Xử lý checkbox phai để lấy ra nam hay nữ dạng bool vì ta khai báo trong database dang bit true, false
            bool phai;
            if (rdb_nam.Checked == true)
            {
                phai = true;
            }
            else
            {
                phai = false;
            }
            //Khởi tạo đối tượng DTO_SinhVien
            dto_sv = new DTO_SVSinhVien(txt_masv.Text, txt_hoten.Text, dateTimePickerSV.Value, phai, txt_diachi.Text, txt_dienthoai.Text, txt_tenlop.Text, txt_hinhanh.Text);
            return dto_sv;
        }
        // Button : cập nhập lại thông tin cho sinh viên
        private void button4_Click(object sender, EventArgs e)
        {
            dto_sv = taoDTOSinhVien();
            if (bus_sv.suaThongTinSV(dto_sv))
            {
                MessageBox.Show("Sửa thành công");
                try
                {
                    pictureBox1.Image.Save(linkAnh + txt_hinhanh.Text);
                    btn_diemlan1.Select();
                    btn_diemlan1.PerformClick();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        // Load dữ liệu tự động khi mới cập nhập thông tin
        private void GUI_SinhVien_Load(object sender, EventArgs e)
        {
            loadThongTinSinhVien();
            btn_diemlan1.Select();
            btn_diemlan1.PerformClick();
        }
        // Làm mới lại dữ liệu sinh viên sau khi cập nhập để xem thay đổi đã đúng chưa
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            loadThongTinSinhVien();
        }
        //Button : điểm lần 1
        private void button1_Click(object sender, EventArgs e)
        {
            dto_sv = taoDTOSinhVien();
            dataGridView1.DataSource = bus_sv.layBangDiemLan1(dto_sv);
        }
        //Button : điểm lần 2
        private void button2_Click(object sender, EventArgs e)
        {
            dto_sv = taoDTOSinhVien();
            dataGridView1.DataSource = bus_sv.layBangDiemLan2(dto_sv);
        }
        //Button : điểm trung bình
        private void button3_Click(object sender, EventArgs e)
        {
            dto_sv = taoDTOSinhVien();
            dataGridView1.DataSource = bus_sv.layBangDiemTrungBinh(dto_sv);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn đóng không?", "Hỏi sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Lấy dữ liệu bảng thông tin sinh viên từ bus đổ lên dt và lúc các dữ liệu từ các cell trong hàng đổ lên các txt, chk
        public void loadThongTinSinhVien()
        {
            // Set width cho form SV từ động rộng bằng cha nó là formcha
            this.Width = Parent.Width;
            //Khởi tạod đối tượng DTO_SVTaikhoan
            DTO_SVTaiKhoan dto_tk = new DTO_SVTaiKhoan(matk, pass);
            DataTable dt = new DataTable();
            //Gửi dữ liệu về matk, pass nhận được từ formdangnhap để database trả về sinh viên tương ứng với matk này
            dt = bus_sv.layDuLieuSinhVien(dto_tk);
            //Foreach duyệt qua các hàng trong data table trả về
            foreach (DataRow dr in dt.Rows)
            {
                //datarow.Field<kiểu dữ liệu>("tên cột") để lấy ra các cell
                txt_masv.Text = dr.Field<string>("masv");
                txt_hoten.Text = dr.Field<string>("tensv");
                dateTimePickerSV.Value = dr.Field<DateTime>("ngaysinh");
                bool phai = dr.Field<bool>("phai");
                // Xử lý kết quả trả về của phái để xác định checked nam hay nữ
                if (phai == true)
                {
                    rdb_nam.Checked = true;
                }
                else
                {
                    rdb_nu.Checked = true;
                }
                txt_diachi.Text = dr.Field<string>("diachi");
                txt_dienthoai.Text = dr.Field<string>("dienthoai");
                txt_tenlop.Text = dr.Field<string>("tenlop");
                txt_hinhanh.Text = dr.Field<string>("hinhanh");
                //ImageLocation để load hình ảnh trên picture box tương ứng với tên ảnh trong txt_hinhanh.Text
                pictureBox1.ImageLocation = linkAnh + txt_hinhanh.Text;
            }
        }
    }
}
