using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_DoiMatKhau : Form
    {
        BUS_DoiMK bus_doimk = new BUS_DoiMK();
        public GUI_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (txt_mkmoi.Text.Equals(txt_nhaplaimkmoi.Text))
            {
                //Khởi tạo đối tượng để truyền đi chao dal xửa lý
                DTO_DoiMK dTO_DNDangNhap = new DTO_DoiMK(txt_tk.Text, txt_mkcu.Text, txt_nhaplaimkmoi.Text);
                if (bus_doimk.kiemTraMatKhauCu(dTO_DNDangNhap) > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu mới không trùng nhau");
            }
        }
        // Xử lý checkbox hiện
        private void chk_hien_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hien.Checked == true)
            {
                txt_mkcu.PasswordChar = (char)0;
                txt_mkmoi.PasswordChar = (char)0;
                txt_nhaplaimkmoi.PasswordChar = (char)0;
            }
            else
            {
                txt_mkcu.PasswordChar = '*';
                txt_mkmoi.PasswordChar = '*';
                txt_nhaplaimkmoi.PasswordChar = '*';
            }
        }
    }
}
