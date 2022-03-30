using BUS;
using DTO;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace GUI
{
    public partial class GUI_ThongKeXepLoai : Form
    {
        BUS_ThongKe bus_tk = new BUS_ThongKe();
        string linkAnh = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/HINHANH/";
        public GUI_ThongKeXepLoai()
        {
            InitializeComponent();
        }

        private void GUI_ThongKeXepLoai_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadComboBoxLop();
        }
        public void loadDataGridView()
        {
            dataGridView1.DataSource = bus_tk.layDuLieuThongKe();
        }

        public void loadComboBoxLop()
        {
            comboBox_tenlop.DataSource = bus_tk.layBangLop();
            comboBox_tenlop.DisplayMember = "tenlop";
            comboBox_tenlop.ValueMember = "malop";
        }

        public void loadComboBoxMon()
        {
            comboBox_tenmon.DataSource = bus_tk.diemTheoMon(txt_masv.Text);
            comboBox_tenmon.DisplayMember = "tenmh";
            comboBox_tenmon.ValueMember = "mamh";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.Text = dataGridView1.CurrentRow.Cells["masv"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["tensv"].Value.ToString();
            bool phai = (bool)dataGridView1.CurrentRow.Cells["phai"].Value;
            if (phai == true)
            {
                rdb_nam.Checked = true;
            }
            else
            {
                rdb_nu.Checked = true;
            }
            string tenanh = "";
            DataTable dt = new DataTable();
            dt = bus_tk.diemTheoMon(dataGridView1.CurrentRow.Cells["masv"].Value.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                //datarow.Field<kiểu dữ liệu>("tên cột") để lấy ra các cell                
                tenanh = dr.Field<string>("hinhanh");
                //ImageLocation để load hình ảnh trên picture box tương ứng với tên ảnh trong txt_hinhanh.Text
                pictureBox1.ImageLocation = linkAnh + tenanh;
            }
            comboBox_tenlop.SelectedValue = dataGridView1.CurrentRow.Cells["malop"].Value.ToString();
            loadComboBoxMon();
            txt_diemtb.Text = dataGridView1.CurrentRow.Cells["diemtb"].Value.ToString();
            txt_xeploai.Text = dataGridView1.CurrentRow.Cells["xeploai"].Value.ToString();
        }
        // xử lý lấy điểm lần 1 và lần 2 khi chọn 1 môn học trong combobox môn
        private void comboBox_tenmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bus_tk.diemTheoMon(dataGridView1.CurrentRow.Cells["masv"].Value.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                if (comboBox_tenmon.SelectedValue.Equals(dr.Field<string>("mamh")))
                {
                    txt_diemlan1.Text = dr.Field<double>("diemlan1").ToString();
                    txt_diemlan2.Text = dr.Field<double>("diemlan2").ToString();
                }
            }
        }
        // Button : sửa dữ liệu trong các ô text box và điểm lần 1 và 2
        private void button4_Click(object sender, EventArgs e)
        {
            DTO_ThongKe dto_tk = new DTO_ThongKe(txt_masv.Text, comboBox_tenmon.SelectedValue.ToString(), float.Parse(txt_diemlan1.Text), float.Parse(txt_diemlan2.Text));
            if (bus_tk.suaDiem(dto_tk))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn đóng không?", "Hỏi sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
