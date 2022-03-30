using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ThongTinKhachHang
{
    public partial class ThongTinKhachHang : Form
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"/hinhanh/";
        LopChung lc = new LopChung();
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Mời chọn hình ảnh";
            open.Filter = "Picture File(*.jpg, *.png)|*.jpg;*.png|All File(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadDuLieu();
            tim = 1;
        }

        public void loadDuLieu()
        {
            String sqlLoad = "select * from khachhang";
            dataGridView1.DataSource = lc.layDuLieuBang(sqlLoad);
        }

        public void loadComboBox()
        {
            string sqlHang = "select * from hang";
            comboBox1.DataSource = lc.layDuLieuBang(sqlHang);
            comboBox1.DisplayMember = "tenhang";
            comboBox1.ValueMember = "mahang";
        }
        public void loadListBox()
        {
            string sqlTinh = "select * from tinh";
            listBox1.DataSource = lc.layDuLieuBang(sqlTinh);
            listBox1.DisplayMember = "tentinh";
            listBox1.ValueMember = "matinh";
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadListBox();
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            //string sqlDem = "select count(*) from khachhang";
            txt_dem.Text = lc.dem().ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "")
            {
                string sqlThem = String.Format("insert into khachhang values ('{0}','{1}',convert(datetime,'{2}',103),'{3}','{4}','{5}','{6}')",
                txt_makh.Text, txt_hoten.Text, dateTimePicker1.Value, txt_hinhanh.Text, comboBox1.SelectedValue.ToString(), txt_soluong.Text, listBox1.SelectedValue.ToString());
                if (lc.NonQuery(sqlThem))
                {
                    MessageBox.Show("Thêm thành công");
                    pictureBox1.Image.Save(path + txt_hinhanh.Text);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống mã sinh viên");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "")
            {
                string sqlThem = String.Format("update khachhang set makh = '{0}',tenkh = N'{1}', ngaymuahang = convert(datetime,'{2}',103),hinhanh = '{3}',mahang = '{4}',soluong = '{5}',matinh = '{6}' where makh = '{7}'",
                txt_makh.Text, txt_hoten.Text, dateTimePicker1.Value, txt_hinhanh.Text, comboBox1.SelectedValue.ToString(), txt_soluong.Text, listBox1.SelectedValue.ToString(), txt_makh.Text);
                if (lc.NonQuery(sqlThem))
                {
                    MessageBox.Show("Sửa thành công");
                    pictureBox1.Image.Save(path + txt_hinhanh.Text);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống mã sinh viên");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "")
            {
                string sqlXoa = "delete from khachhang where makh = '" + txt_makh.Text + "'";
                if (lc.NonQuery(sqlXoa))
                {
                    MessageBox.Show("Xoá thành công");
                    File.Delete(path + txt_hinhanh.Text);
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống mã sinh viên");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn đóng ứng dụng", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string sqlTim = String.Format("select * from khachhang where makh like '%{0}%' or tenkh like '%{0}%'", txt_timkiem.Text);
            if (txt_timkiem.Text == "")
            {
                loadDuLieu();
            }
            else
            {
                dataGridView1.DataSource = lc.layDuLieuBang(sqlTim);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["soluong"], ListSortDirection.Ascending);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["soluong"], ListSortDirection.Descending);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sqlTim = String.Format("select * from khachhang where mahang = '{0}'", comboBox1.SelectedValue);
            dataGridView1.DataSource = lc.layDuLieuBang(sqlTim);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 1 && dataGridView1.DataSource != null)
            {
                string sqlTim = String.Format("select * from khachhang where mahang = '{0}'", comboBox1.SelectedValue);
                dataGridView1.DataSource = lc.layDuLieuBang(sqlTim);
            }
            tim = 1;
        }
        int tim = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dataGridView1.CurrentRow.Cells["makh"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["tenkh"].Value.ToString();
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["ngaymuahang"].Value);
            }
            catch
            {
                MessageBox.Show("Dữ liệu click đang trống");
            }

            txt_hinhanh.Text = dataGridView1.CurrentRow.Cells["hinhanh"].Value.ToString();
            tim = 0;
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells["mahang"].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells["soluong"].Value.ToString();
            tim = 0;
            listBox1.SelectedValue = dataGridView1.CurrentRow.Cells["matinh"].Value.ToString();
            pictureBox1.ImageLocation = path + txt_hinhanh.Text;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tim == 1 && dataGridView1.DataSource != null)
            {
                string sqlTim = String.Format("select * from khachhang where matinh = '{0}'", listBox1.SelectedValue);
                dataGridView1.DataSource = lc.layDuLieuBang(sqlTim);
            }
            tim = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
