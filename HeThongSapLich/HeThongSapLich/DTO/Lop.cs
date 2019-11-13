using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class Lop
    {
        private string maLop;

        public string MaLop { get => maLop; set => maLop = value; }

        public Lop() { }

        public Lop(DataRow row)
        {
            this.MaLop = (string)row["row"];
        }
    }
}
