using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frm_Thongtinkhachhang : Form
    {
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\HINHANH\";
        lopchung lopchung = new lopchung();
        public frm_Thongtinkhachhang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {            
            string sqlKH = "exec select_data_gridview";            
            dataGridView1.DataSource = lopchung.Adapter(sqlKH);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {            
            String sqlThem = "exec insert_khachhang '"+txt_makh.Text + "', N'" + txt_hoten.Text + 
                "','" + dateTimePicker1.Value + "' , '" + txt_hinhanh.Text + "', " +
                "'"+comboBox1.SelectedValue.ToString()+"', '"+txt_soluong.Text+"','"+listBox1.SelectedValue.ToString()+"'";
            try
            {
                int kq = lopchung.ExecuteNonQuery(sqlThem);
                if (kq >= 1)
                {
                    MessageBox.Show("Chèn thành công");
                    pictureBox1.Image.Save(duongdan + txt_hinhanh.Text);
                }
                else MessageBox.Show("Chèn thất bại");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Lỗi cú pháp chèn sql hoặc lỗi trùng mã");
            }           
        }

        private void frm_Thongtinkhachhang_Load(object sender, EventArgs e)
        {
            load_combobox();
            Load_ListBox();
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {            
            string sqlSua =
                "exec updatet_khachhang '" + txt_makh.Text + "', N'" + txt_hoten.Text +
                "','" + dateTimePicker1.Value + "' , '" + txt_hinhanh.Text + "', '" 
                + comboBox1.SelectedValue.ToString() + "', '" + txt_soluong.Text + "'," +
                "'" + listBox1.SelectedValue + "'";
            try
            {
                int result = lopchung.ExecuteNonQuery(sqlSua);
                if (result >= 1)
                {
                    MessageBox.Show("Update thành công");
                    pictureBox1.Image.Save(duongdan + txt_hinhanh.Text);
                }
                else MessageBox.Show("Update thất bại vì không tồn tại MAKH");
            }
            catch
            {
                MessageBox.Show("Lỗi cú pháp sql update");
            }
            LoadData();
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {           
            string sqlDem = "select count(*) from KHACHHANG";
            txt_dem.Text = lopchung.ExecuteScalar(sqlDem).ToString();
        }        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn ảnh khách hàng";
            open.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.png)|*.jpg; *.jpeg; *.jpe; *.png|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {          
            string sqlXoa = "delete from khachhang where makh = '"+txt_makh.Text+"'";
            DialogResult dg = MessageBox.Show("Bạn có thật sự muốn xoá", "Hỏi người dùng", MessageBoxButtons.YesNo);
            if(dg == DialogResult.Yes)
            {
                int result = lopchung.ExecuteNonQuery(sqlXoa);
                try
                {
                    if (result >= 1) MessageBox.Show("Xoá thành công");
                    else MessageBox.Show("Không tìm thấy mã kh");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cú pháp sql");
                }
            }            
            LoadData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dataGridView1.CurrentRow.Cells["MAKH"].Value.ToString();
            txt_hoten.Text = dataGridView1.CurrentRow.Cells["TENKH"].Value.ToString();
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["NGAYMUAHANG"].Value);
            }
            catch
            {
                MessageBox.Show("Dữ liệu rỗng");
            }            
            txt_hinhanh.Text = dataGridView1.CurrentRow.Cells["HINHANH"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_hinhanh.Text;
            comboBox1.Text = dataGridView1.CurrentRow.Cells["TENHANG"].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells["SOLUONG"].Value.ToString();
            listBox1.SelectedValue = dataGridView1.CurrentRow.Cells["MATINH"].Value.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có thật sự muốn thoát", "Hỏi người dùng", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void load_combobox()
        {           
            string sqlCombo = "select * from hang";
            comboBox1.DataSource = lopchung.Adapter(sqlCombo);
            comboBox1.DisplayMember = "TENHANG";
            comboBox1.ValueMember = "MAHANG";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string sqlTim = "select * from khachhang where makh LIKE '%" + txt_timkiem.Text + "%' or tenkh LIKE N'%" + txt_timkiem.Text + "%'";
            dataGridView1.DataSource = lopchung.Adapter(sqlTim);
        }

        public void Load_ListBox()
        {            
            string sqlList = "select * from TINH";           
            listBox1.DataSource = lopchung.Adapter(sqlList);
            listBox1.DisplayMember = "TENTINH";
            listBox1.ValueMember = "MATINH";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["soluong"], ListSortDirection.Ascending);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["soluong"], ListSortDirection.Descending);
        }

        private void btn_loadlaibang_Click(object sender, EventArgs e)
        {
            LoadData();
        }        
    }
}
