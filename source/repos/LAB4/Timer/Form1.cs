using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class frm_Timer : Form
    {
        public frm_Timer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbl_time.Text = String.Format("{0:hh:mm:ss tt}", dt);
            lbl_ngay.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            prb_load.Increment(1);
            lbl_load.Text = "Connecting to from " + prb_load.Value.ToString();
            if (prb_load.Value == prb_load.Maximum)
            {
                timer2.Enabled = false;
                a.ShowDialog();
            }
        }

        private void btb_show_Click(object sender, EventArgs e)
        {
            if (prb_load.Enabled == true)
            {
                prb_load.Enabled = false;
                timer1.Start();
                timer2.Start();
            }
            else
            {
                prb_load.Enabled = true;
                timer1.Stop();
                timer2.Stop();
            }                     
        }
    }
}
