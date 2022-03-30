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
    public partial class frm_cha : Form
    {
        public frm_cha()
        {
            InitializeComponent();
        }

        private void btn_con1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_con1"] == null)
            {
                frm_con1 a = new frm_con1();
                a.MdiParent = this;
                a.Show();
            }
            else Application.OpenForms["frm_con1"].Activate();
        }

        private void btn_con2_Click(object sender, EventArgs e)
        {
            frm_con2 a = new frm_con2();
            a.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frm_cha_Load(object sender, EventArgs e)
        {

        }
    }
}
