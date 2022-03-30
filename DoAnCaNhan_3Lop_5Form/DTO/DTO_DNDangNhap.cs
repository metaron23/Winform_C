using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DNDangNhap
    {
        private string matk;
        private string pass;

        public DTO_DNDangNhap()
        {
        }

        public DTO_DNDangNhap(string matk, string pass)
        {
            this.matk = matk;
            this.pass = pass;
        }

        public string Matk { get => matk; set => matk = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
