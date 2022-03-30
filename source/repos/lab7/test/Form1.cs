using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{    
    public partial class Form1 : Form
    {
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\HINHANH\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Mời chọn hình ảnh";
            open.Filter = "Picture File (*.jpg, *.png)|*.jpg;*.png|All File(*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(duongdan + txthinh.Text);
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = duongdan + txthinh.Text;
        }
    }
}
