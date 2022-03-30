using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Winform
{
    public partial class frm_Cau2 : Form
    {
        public frm_Cau2()
        {
            InitializeComponent();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_thu.Text))
            {
                MessageBox.Show("Bạn để trống!Vui lòng nhập vào số >=2 và <=8");
            }
            else
            {
                int a = Convert.ToInt32(txt_thu.Text);
                if (a >= 2 && a <= 8)
                {
                    switch (a)
                    {
                        case 2:
                            MessageBox.Show("Thứ hai");
                            break;
                        case 3:
                            MessageBox.Show("Thứ ba");
                            break;
                        case 4:
                            MessageBox.Show("Thứ tư");
                            break;
                        case 5:
                            MessageBox.Show("Thứ năm");
                            break;
                        case 6:
                            MessageBox.Show("Thứ sáu");
                            break;
                        case 7:
                            MessageBox.Show("Thứ bảy");
                            break;
                        case 8:
                            MessageBox.Show("Chủ nhật");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vào số >=2 và <=8");
                }
            }
        }
        private void txt_thu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
