using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_FromCha : Form
    {
        public GUI_FromCha()
        {
            InitializeComponent();
        }
        // Hàm kiểm tra có form con nào đang mở hay không -  để bắt sự kiện đang dùng form QLSV thì không thể ấn đăng nhập được
        public int checkFormCon()
        {
            int dem = 0;
            foreach (Form mdiForm in this.MdiChildren)
                dem++;
            return dem;
        }
        // Hàm đóng toàn bộ form con - để khi ấn đăng xuất đóng toàn bộ form và mở form đăng nhập
        private void dongform()
        {
            foreach (Form mdiForm in this.MdiChildren)
                mdiForm.Close();
        }
        // Ấn đăng nhập
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DangNhap dn = new GUI_DangNhap(this);
            openForm(dn);
        }
        // hàm kiểm tra form đang mở thì chỉ active chứ không show
        public bool checkFormOpen(string tenform)
        {
            foreach (Form a in this.MdiChildren)
            {
                if (a.Name.Equals(tenform))
                {
                    a.Activate();
                    return true;
                }
            }
            return false;
        }
        // hàm để mở form, gọi hàm checkFormCon xử lý nút đăng nhâp và tiến hành show các form
        public void openForm(Form a)
        {
            if (checkFormCon() == 0 || a.Name.Equals("GUI_ThongKeXepLoai"))
            {
                if (checkFormOpen(a.Name) == false)
                {
                    a.MdiParent = this;
                    a.Show();
                }
            }
            else
            {
                foreach (Form b in this.MdiChildren)
                {
                    if (b.Name.Equals(a.Name))
                    {
                        a.Activate();
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải đăng xuất đã!");
                    }
                }
            }
        }
        // Ấn đóng
        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn đóng không?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Ấn đăng xuất
        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DangNhap dn = new GUI_DangNhap(this);
            foreach (Form b in this.MdiChildren)
            {
                if (b.Name.Equals(dn.Name))
                {
                    dn.Activate();
                    MessageBox.Show("Bạn chưa đăng nhập");
                }
                else
                {
                    dongform();
                    GUI_DangNhap a = new GUI_DangNhap(this);
                    openForm(a);
                }
            }
        }
    }
}
