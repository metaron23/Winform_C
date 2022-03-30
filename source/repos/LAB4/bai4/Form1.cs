using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();// lbl_Nghiem.Visible = false;
        }
        int a = 0, b = 0, c = 0;
        // Cách 1 dùng TryParse
        public bool NhapSo()
        {
            if (int.TryParse(txt_HesoA.Text, out a))
            {
                if (int.TryParse(txt_HesoB.Text, out b))
                {
                    if (int.TryParse(txt_HesoC.Text, out c))
                    {
                        return true;
                    }
                    else
                    { MessageBox.Show("So C vừa nhập không đúng định dạng"); return false; }
                    return true;
                }
                else
                { MessageBox.Show("So B vừa nhập không đúng định dạng"); return false; }
                return true;
            }
            else
            { MessageBox.Show("So A vừa nhập không đúng định dạng"); return false; }
        }
        // Cách 2  /////////////////////// chưa ổn
        /* public int NhapSoABC(char i) 
         {
             int u = 0;
                 try
                 {
                     if (i == 'A') u = int.Parse(txt_HesoA.Text);
                     if (i == 'B') u = int.Parse(txt_HesoB.Text);
                     if (i == 'C') u = int.Parse(txt_HesoC.Text);
                 }
                 catch (Exception e)
                 {
                     MessageBox.Show("Nhập hệ số " + i + " sai định dạng");
                 }
             return u;
         }*/
        private void button1_Click(object sender, EventArgs e)
        {
            /*int a = NhapSoABC('A');
            int b = NhapSoABC('B');
            int c = NhapSoABC('C');*/
            double x1, x2;
            //lbl_Nghiem.Visible = false; //? ham khoi tao
            if (NhapSo() == true)
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;//khai báo biến delta 
                if (a == 0)
                {
                    lbl_Nghiem.Visible = false;
                    MessageBox.Show("Đây không phải là phương trình bậc 2. Nghiệm của phương trình là " + Math.Round((double)-c / b, 2));
                    if (a == 0 && b == 0)
                    {
                        MessageBox.Show("Phương trình vô nghiệm");
                    }
                }
                else
                {
                    if (delta > 0)
                    {
                        x1 = Math.Round((-b - Math.Sqrt(delta)) / 2 * a, 3);
                        x2 = Math.Round((-b + Math.Sqrt(delta)) / 2 * a, 2);
                        lbl_Nghiem.Text = "Phương trình có 2 nghiệm phân biệt là: " + x1.ToString() + " và " + x2.ToString();
                        lbl_Nghiem.Visible = true;
                    }
                    else if (delta == 0)
                    {
                        x1 = x2 = -b / (2.0 * a);
                        lbl_Nghiem.Text = "Phương trình có nghiệm kép là: " + x2.ToString();
                        // MessageBox.Show("Phươ
                        ng trình có nghiệm kép\n X1 = X2 = " + x2.ToString());
                     lbl_Nghiem.Visible = true;
                    }
                    else if (delta < 0)
                    {
                        lbl_Nghiem.Text = "Phương trình vô nghiệm";
                        lbl_Nghiem.Visible = true;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_HesoA_TabIndexChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_Giai;
        }
    }
}
