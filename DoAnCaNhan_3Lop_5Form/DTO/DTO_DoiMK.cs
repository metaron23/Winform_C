using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoiMK
    {
        private string matk;
        private string passcu;
        private string passmoi;

        public DTO_DoiMK()
        {
        }

        public DTO_DoiMK(string matk, string passcu, string passmoi)
        {
            this.matk = matk;
            this.passcu = passcu;
            this.passmoi = passmoi;
        }

        public string Matk { get => matk; set => matk = value; }
        public string Passcu { get => passcu; set => passcu = value; }
        public string Passmoi { get => passmoi; set => passmoi = value; }
    }
}
