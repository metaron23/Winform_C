using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongTinKhachHang
{
    public partial class FormCha : Form
    {
        public FormCha()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang a = new ThongTinKhachHang();
            if (kiemTraFormCon(a.Name) == false)
            {                
                a.MdiParent = this;
                a.Show();
            }            
        }
        public bool kiemTraFormCon(String name)
        {
            foreach(Form form in this.MdiChildren)
            {
                if(form.Name.Equals(name))
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
    }
}
