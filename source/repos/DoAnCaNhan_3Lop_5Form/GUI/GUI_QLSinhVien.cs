using BUS;
using DTO;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_QLSinhVien : Form
    {
        BUS_QLSinhVien bus_qlsv = new BUS_QLSinhVien();
        //Đường dẫn của file ảnh lưu
        string linkAnh = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/HINHANH/";
        //Khai báo form đăng nhập
        GUI_DangNhap gui_dn;
        //Tạo constructor nhận form đăng nhập, xử lý việc mở form thống kê từ this dưới dạng con form cha
        public GUI_QLSinhVien(GUI_DangNhap a)
        {
            InitializeComponent();
            gui_dn = a;
        }

        public GUI_QLSinhVien()
        {
            InitializeComponent();
        }

        private void GUI_QLSinhVien_Load(object sender, EventArgs e)
        {
            this.Width = Parent.Width;
            loadComboBox();
            loadDataGridView();
        }

        public void loadComboBox()
        {
            comboBox_tenlop.DataSource = bus_qlsv.layBangLop(); //Nhận datatable lớp
            comboBox_tenlop.DisplayMember = "tenlop";
            comboBox_tenlop.ValueMember = "malop";
        }

        public void loadDataGridView()
        {
            dataGridView1.DataSource = bus_qlsv.layBangQLSinhVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dataGridView1.CurrentRow.Cells["masv"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["tensv"].Value.ToString();
            txt_diachi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txt_dienthoai.Text = dataGridView1.CurrentRow.Cells["dienthoai"].Value.ToString();
            dateTimePickerSV.Value = (DateTime)dataGridView1.CurrentRow.Cells["ngaysinh"].Value;
            bool phai = (bool)dataGridView1.CurrentRow.Cells["phai"].Value;
            if (phai == true)
            {
                rdb_nam.Checked = true;
            }
            else
            {
                rdb_nu.Checked = true;
            }
            string tenanh = dataGridView1.CurrentRow.Cells["hinhanh"].Value.ToString();
            pictureBox1.ImageLocation = linkAnh + tenanh;
        }
        // Button : Thêm sinh viên mới
        private void button1_Click(object sender, EventArgs e)
        {
            //Khởi tạo form thêm sinh viên truyền this là form ql sinh viên sang để xử lý thêm sinh viên bằng form thêm sinh viên
            GUI_ThemSV gui_themsv = new GUI_ThemSV(this);
            gui_themsv.ShowDialog();
        }
        // tạo hàm thêm sinh viên
        public void themSinhVien(string matk, string pass)
        {
            //khởi tạo đối tượng chứa matk và pass, trong trường hợp này gọi sang form thêm sinh viên thì đối số là các text box trong form thêm sinh viên
            DTO_DNDangNhap dto_dn = new DTO_DNDangNhap(matk, pass);
            if (bus_qlsv.chenDuLieuVaoBangTaiKhoan(dto_dn))
            {
                MessageBox.Show("Tạo tài khoản thành công");
                bool phai;
                if (rdb_nam.Checked == true)
                {
                    phai = true;
                }
                else
                {
                    phai = false;
                }
                //tạo đối tượng chứa thông tin sinh viên cần thêm vào database
                DTO_QLSV_TTSV dto_qlsv = new DTO_QLSV_TTSV(txt_masv.Text, txt_hoten.Text, dateTimePickerSV.Value, phai, txt_diachi.Text, txt_dienthoai.Text, comboBox_tenlop.SelectedValue.ToString(), matk);
                if (bus_qlsv.chenDuLieuQLSinhVien(dto_qlsv))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Thêm mới sinh viên thất bại");
                }
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
            }
        }
        //Cập nhập sinh viên sau khi sửa trong các ô text box
        private void btn_capnhap_Click(object sender, EventArgs e)
        {
            bool phai;
            if (rdb_nam.Checked == true)
            {
                phai = true;
            }
            else
            {
                phai = false;
            }
            DTO_QLSV_TTSV dto_qlsv = new DTO_QLSV_TTSV(txt_masv.Text, txt_hoten.Text, dateTimePickerSV.Value, phai, txt_diachi.Text, txt_dienthoai.Text, comboBox_tenlop.SelectedValue.ToString(), "");
            if (bus_qlsv.suaDuLieuBangQLSinhVien(dto_qlsv))
            {
                MessageBox.Show("Sửa dữ liệu sinh viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu sinh viên thất bại");
            }
        }
        //Button : Làm mới: lấy dữ liệu trực tiếp từ kho load lên datagridview để check dữ liệu sửa đổi chưa
        private void button1_Click_1(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        //Button: xoá sinh viên
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool phai;
            if (rdb_nam.Checked == true)
            {
                phai = true;
            }
            else
            {
                phai = false;
            }
            DTO_QLSV_TTSV dto_qlsv = new DTO_QLSV_TTSV(txt_masv.Text, txt_hoten.Text, dateTimePickerSV.Value, phai, txt_diachi.Text, txt_dienthoai.Text, comboBox_tenlop.SelectedValue.ToString(), "");
            if (bus_qlsv.xoaSinhVienVaTK(dto_qlsv))
            {
                MessageBox.Show("Xoá sinh viên thành công");
            }
            else
            {
                MessageBox.Show("Xoá sinh viên thất bại");
            }
        }
        //BUtton: đóng form
        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn đóng không?", "Hỏi sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // xử lý sắp xếp
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["tensv"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["tensv"], System.ComponentModel.ListSortDirection.Descending);
        }
        // xử lý tìm kiếm
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus_qlsv.timKiem(txt_timkiem.Text);
        }
        // mở form xếp loại
        private void button3_Click(object sender, EventArgs e)
        {
            GUI_ThongKeXepLoai a = new GUI_ThongKeXepLoai();
            //gọi mở form từ form đăng nhập để mở form thống kê dưới dạng con của form cha
            gui_dn.moForm(a);
        }
    }
}
