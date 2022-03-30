using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dal = new DAL_DangNhap();
        public int kiemTraDangNhap(DTO_DNDangNhap a)
        {
            return dal.kiemTraDangNhap(a);
        }
    }
}
