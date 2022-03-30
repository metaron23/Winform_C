using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_khachhang = new DAL_KhachHang();
        public DataTable getDataTableKhachHang()
        {
            return dal_khachhang.getDataTableKhachHang();
        }
        public DataTable getDataTableHang()
        {
            return dal_khachhang.getDataTableHang();
        }
        public DataTable getDataTableTinh()
        {
            return dal_khachhang.getDataTableTinh();
        }
        public bool insertData(DTO_KhachHang kh)
        {
            return dal_khachhang.insertData(kh);
        }
        public bool updateData(DTO_KhachHang kh)
        {
            return dal_khachhang.updateData(kh);
        }
        public bool deleteData(DTO_KhachHang kh)
        {
            return dal_khachhang.deleteData(kh);
        }
        public int countRowData()
        {
            return dal_khachhang.countRowData();
        }
        public DataTable searchData(string chuoi)
        {
            return dal_khachhang.searchData(chuoi);
        }
    }
}
