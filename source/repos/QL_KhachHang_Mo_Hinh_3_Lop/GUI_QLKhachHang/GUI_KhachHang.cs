using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang buskhachhang = new BUS_KhachHang();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\HINHANH\";
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {

            loadComboBox();
            loadListBox();
            //loadKhachHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang(txt_makh.Text, txt_hoten.Text, dateTimePicker1.Value, txt_hinhanh.Text, comboBox1.SelectedValue.ToString(), Convert.ToInt32(txt_soluong.Text), listBox1.SelectedValue.ToString());
            if (buskhachhang.updateData(kh))
            {
                MessageBox.Show("Sửa thành công");
                pictureBox1.Image.Save(duongdan + txt_hinhanh.Text);
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            loadKhachHang();
        }
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
                MessageBox.Show("Dữ liệu bị null");
            }            
            txt_hinhanh.Text = dataGridView1.CurrentRow.Cells["hinhanh"].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells["mahang"].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells["soluong"].Value.ToString();
            listBox1.SelectedValue = dataGridView1.CurrentRow.Cells["matinh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_hinhanh.Text;
        }

        public void loadComboBox()
        {
            comboBox1.DataSource = buskhachhang.getDataTableHang();
            comboBox1.ValueMember = "mahang";
            comboBox1.DisplayMember = "tenhang";
        }

        public void loadListBox()
        {
            listBox1.DataSource = buskhachhang.getDataTableTinh();
            listBox1.ValueMember = "matinh";
            listBox1.DisplayMember = "tentinh";
        }

        public void loadKhachHang()
        {
            dataGridView1.DataSource = buskhachhang.getDataTableKhachHang();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang(txt_makh.Text, txt_hoten.Text, dateTimePicker1.Value, txt_hinhanh.Text, comboBox1.SelectedValue.ToString(), Convert.ToInt32(txt_soluong.Text), listBox1.SelectedValue.ToString());
            if (buskhachhang.insertData(kh))
            {
                MessageBox.Show("Thêm thành công");
                pictureBox1.Image.Save(duongdan + txt_hinhanh.Text);
            }
            else
            {
                MessageBox.Show("Thêm thất bại");

            }
            loadKhachHang();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Mời chọn ảnh";
            open.Filter = "Picture File(*.jpg, *.png)|*.jpg;*.png|AllFile(*.*)|*.*;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang(txt_makh.Text, txt_hoten.Text, dateTimePicker1.Value, txt_hinhanh.Text, comboBox1.SelectedValue.ToString(), Convert.ToInt32(txt_soluong.Text), listBox1.SelectedValue.ToString());
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn xoá không?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (buskhachhang.deleteData(kh))
                {
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            loadKhachHang();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            txt_dem.Text = buskhachhang.countRowData().ToString();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                loadKhachHang();
            }
            else
            {
                dataGridView1.DataSource = buskhachhang.searchData(txt_timkiem.Text);
            }
        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                loadKhachHang();
            }
            else
            {
                dataGridView1.DataSource = buskhachhang.searchData(txt_timkiem.Text);
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý khách hàng";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = "'" + dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btn_xuatexel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_nhapfileexel_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable dt = new DataTable("dataTable");
            DataSet dsSource = new DataSet("dataSet");
            dt.Reset();
            Microsoft.Office.Interop.Excel.Workbook ExWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet ExWorksheet;
            Microsoft.Office.Interop.Excel.Range ExRange;
            Microsoft.Office.Interop.Excel.Application ExObj = new Microsoft.Office.Interop.Excel.Application();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                ExWorkbook = ExObj.Workbooks.Open(openFileDialog1.FileName);
                ExWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExWorkbook.Sheets.get_Item(1);
                ExRange = ExWorksheet.UsedRange;

                for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(new DataColumn((ExRange.Cells[1, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                string[] columnNames = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }
                //string[] columnNames = (from dc in dt.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();

                for (int Rnum = 2; Rnum <= ExRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
                    {
                        if ((ExRange.Cells[Rnum, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2 != null)
                        {                            
                            dr[Cnum - 1] = (ExRange.Cells[Rnum, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }
                ExWorkbook.Close(true);
                ExObj.Quit();
                dataGridView1.DataSource = dt;
                Cursor = Cursors.Default;
            }
        }

        private void btn_nhapfileexel_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadKhachHang();
        }
    }
}
