using System;
using System.Windows.Forms;

namespace Test_Winform
{
    public partial class frm_Cau3 : Form
    {
        public frm_Cau3()
        {
            InitializeComponent();
        }


        private void txt_tendn_TextChanged(object sender, EventArgs e)
        {

        }
        private int a = 0;
        private void btn_dn_Click(object sender, EventArgs e)
        {            
            if (txt_tendn.Text.ToLower() == "admin" && txt_mk.Text.ToLower() == "123456")
            {
                Form b = new frm_QLSV();
                b.Show();
            }
            else
            {
                a++;
                lbl_Thongbao.Visible = true;
                lbl_Thongbao.Text = "Bạn đã nhập sai " + a + " lần!";
                if (a == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai quá " + a + " lần!");
                    Application.Exit();
                }
                MessageBox.Show("Bạn nhập sai tên hoặc mật khẩu!");
            }            
        }
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_tendn.Clear();
            txt_mk.Clear();
            txt_tendn.Focus();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát hay không?", "Hỏi người dùng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }
        private void txt_mk_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_dn;
        }

        private void frm_Cau3_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Thongbao_Click(object sender, EventArgs e)
        {

        }
    }
}
