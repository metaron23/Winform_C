using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface
{
    internal class BenhNhan_BHYT : BenhNhan,IBenhNhan
    {
        public double tinhTienAn()
        {
            throw new NotImplementedException();
        }

        public override double tinhVienPhi()
        {
            throw new NotImplementedException();
        }
    }
}
