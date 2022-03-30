using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DoiMK
    {
        DAL_DoiMK dAL_DoiMK = new DAL_DoiMK();
        public int kiemTraMatKhauCu(DTO_DoiMK doimk)
        {
            return dAL_DoiMK.kiemTraMatKhauCu(doimk);
        }
    }
}
