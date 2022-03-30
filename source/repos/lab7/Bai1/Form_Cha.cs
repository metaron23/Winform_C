using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frm_Form_Cha : Form
    {
        public frm_Form_Cha()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemTraFromCon("frm_DSSV") == false)
            {
                frm_DSSV a = new frm_DSSV();
                a.MdiParent = this;
                a.Show();
            }        
        }
        public bool kiemTraFromCon(string form_name)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals(form_name))
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemTraFromCon("frm_Thongtinkhachhang") == false)
            {
                frm_Thongtinkhachhang a = new frm_Thongtinkhachhang();
                a.MdiParent = this;
                a.Show();
            }
        }

        private void frm_Form_Cha_Load(object sender, EventArgs e)
        {

        }
    }
}
