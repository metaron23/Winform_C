using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_ten.Text) ||
                String.IsNullOrEmpty(txt_soluong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txt_ten.Text;
                lv1.Items.Add(item);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item,txt_soluong.Text);
                item.SubItems.Add(txt_soluong.Text);

                txt_ten.Clear();
                txt_soluong.Clear();
                txt_ten.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_them;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn xoá không?", "Hỏi người dùng",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dg == DialogResult.Yes)
                {
                    lv1.Items.Remove(lv1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Xoá lỗi");
            }
        }

        private void btn_xoahet_Click(object sender, EventArgs e)
        {
            lv1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi người dùng",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
