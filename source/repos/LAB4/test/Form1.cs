using System;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn mở ứng dụng?", "Hỏi người dùng", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                Dispose();
        }

        private void btn_hoten1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + txt_hoten1.Text);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
                txt_hoten1.Text = "Phan Thanh Hùng";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("Bạn vừa click chuột trái!");
            if (e.Button == MouseButtons.Right)
                MessageBox.Show("Bạn vừa click chuột phải!");
            if (e.Button == MouseButtons.Middle)
                MessageBox.Show("Bạn vừa click chuột giữa!");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi người dùng", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
