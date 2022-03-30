using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_ThemSV : Form
    {
        GUI_QLSinhVien gui_qlsv;
        public GUI_ThemSV()
        {
            InitializeComponent();
        }

        public GUI_ThemSV(GUI_QLSinhVien a)
        {
            InitializeComponent();
            gui_qlsv = a;
        }
        // Xử lý thêm tài khoản và thêm sinh viên từ chính form thêm sinn viên
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == "" || txt_mk.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ tài khoản và mật khẩu");
            }
            else
            {
                gui_qlsv.themSinhVien(txt_tk.Text, txt_mk.Text);
                this.Close();
            }
        }
    }
}
