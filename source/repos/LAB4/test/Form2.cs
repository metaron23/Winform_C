using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_so1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar <='9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            } 
        }

        private void txt_so2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar >= '0' && e.KeyChar <='9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_so1.Text) + Convert.ToInt32(txt_so2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_so1.Text) - Convert.ToInt32(txt_so2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_so1.Text) * Convert.ToInt32(txt_so2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(txt_so1.Text) / Convert.ToDouble(txt_so2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            txt_so1.Clear();
            txt_so2.Clear();
            txt_result.Clear();
            txt_so1.Select();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_nhap.Text))
            {
                lst_Box.Items.Add(txt_nhap.Text);
                txt_tong.Text = lst_Box.Items.Count.ToString();
                txt_nhap.Clear();
                txt_nhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btn_xoachon_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_tong.Text);
            if (lst_Box.SelectedItems.Count != 0)
            {
                lst_Box.Items.Remove(lst_Box.SelectedItems[0]);
                txt_tong.Text = (a - 1).ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn!");
            }
            
        }

        private void btn_xoadau_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_tong.Text);
            if(lst_Box.Items.Count != 0)
            {
                lst_Box.Items.RemoveAt(0);
                txt_tong.Text = (a - 1).ToString();
            }
            else
            {
                MessageBox.Show("Danh sách đã rỗng!");
            }         
        }

        private void btn_xoacuoi_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_tong.Text);
            if(lst_Box.Items.Count != 0)
            {
                lst_Box.Items.RemoveAt(lst_Box.Items.Count - 1);
                txt_tong.Text = (a - 1).ToString();
            }
            else
            {
                MessageBox.Show("Danh sách đã rỗng!");
            }
        }

        private void btn_xoafull_Click(object sender, EventArgs e)
        {
            lst_Box.Items.Clear();
            txt_tong.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbo_color.Text == "Yellow")
            {
                lbl_head.BackColor = Color.Red;
                lbl_head.ForeColor = Color.Yellow;
            }
            if (cbo_color.Text == "Red")
            {
                lbl_head.BackColor = Color.Yellow;
                lbl_head.ForeColor = Color.Red;
            }
            if (cbo_color.Text == "Blue")
            {
                lbl_head.BackColor = Color.Yellow;
                lbl_head.ForeColor = Color.Blue;
            }
            if (cbo_color.Text == "Black")
            {
                lbl_head.BackColor = Color.White;
                lbl_head.ForeColor = Color.Black;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi người dùng", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
