using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_DangNhap : Form
    {
        BUS_DangNhap busdn = new BUS_DangNhap();
        GUI_FromCha formcha;
        public GUI_DangNhap(GUI_FromCha fcha)
        {
            formcha = fcha; //Gọi lại form cha trung gian
            InitializeComponent();
        }
        // Tạo hàm mở form để truyền form vào mở dưới dạng form con
        public void moForm(Form a)
        {
            formcha.openForm(a);
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == "" || txt_pass.Text == "") //Kiểm tra mã mới và nhập lại mã mới trùng không
            {
                MessageBox.Show("Bạn phải điền đủ tài khoản và mật khẩu");
            }
            else
            {
                DTO_DNDangNhap dtodn = new DTO_DNDangNhap(txt_tk.Text, txt_pass.Text); //Tạo mới 1 đối tượng tài khoản
                if (busdn.kiemTraDangNhap(dtodn) == 1) //Trả về 1 là tài khoản của admin xử lý trong procedure
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công với tài khoảng admin");
                    // Gọi form ql sinh viên để truyền this là form đăng nhập sang, xử lý việc gọi form thông kê dưới dạng con formcha
                    GUI_QLSinhVien ql = new GUI_QLSinhVien(this);
                    this.Close();
                    moForm(ql);

                }
                if (busdn.kiemTraDangNhap(dtodn) == 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công với tài khoảng sinh viên");
                    GUI_SinhVien sv = new GUI_SinhVien(txt_tk.Text, txt_pass.Text);
                    this.Close();
                    moForm(sv);
                }
                if (busdn.kiemTraDangNhap(dtodn) == 2)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
        }
        // Đóng form đăng nhập
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("ban co muon dong form dang nhap?", "hoi nguoi dung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Xử lý ẩn hiện mật khẩu
        private void chk_hien_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hien.Checked == true)
            {
                txt_pass.PasswordChar = (char)0;
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }
        // mở form đổi mật khẩu
        private void lkl_quenpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txt_tk.Text == "admin")
            {
                MessageBox.Show("Không thể đổi mật khẩu admin");
            }
            else
            {
                GUI_DoiMatKhau doimk = new GUI_DoiMatKhau();
                doimk.ShowDialog();
            }
        }
        // Sau khi ấn enter mã code 13 thì sẽ select button đăng nhập tiện enter mở form
        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_dn.Select();
            }
        }
    }
}
