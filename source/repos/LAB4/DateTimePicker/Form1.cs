using System;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txt_ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                || e.KeyChar == ' ' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp1.MinDate = DateTime.Now;
            int dayofmont = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtp1.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmont);
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text) || string.IsNullOrEmpty(txt_sdt.Text)||
                string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("You haven't entered enough information");
            }
            else
            {
                MessageBox.Show("Chúc mừng bạn " + txt_ten.Text + " có số điện thoại: " + txt_sdt.Text
                    + " đã đăng ký thành công lúc " + dtp1.Value.ToShortDateString());
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            txt_start.Text = moc1.SelectionStart.ToShortDateString();
            txt_end.Text = moc1.SelectionEnd.ToShortDateString();
            txt_min.Text = moc1.MinDate.ToShortDateString();
            txt_max.Text = moc1.MaxDate.ToShortDateString();
            txt_today.Text = moc1.TodayDate.ToShortDateString();
        }

        private void btn_countday_Click(object sender, EventArgs e)
        {
            int numdays;
            numdays = Convert.ToInt32((moc1.SelectionEnd - moc1.SelectionStart).TotalDays);
            txt_countday.Text = numdays.ToString();
        }

        private void btn_counthour_Click(object sender, EventArgs e)
        {
            int numhours;
            numhours = Convert.ToInt32((moc1.SelectionEnd - moc1.SelectionStart).TotalHours);
            txt_counthour.Text = numhours.ToString();
        }
    }
}
