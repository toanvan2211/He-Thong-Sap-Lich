using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class Mon
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }

        public Mon() { }

        public Mon(string maMon, string tenMon)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
        }

        public Mon(DataRow row)
        {
            this.MaMon = (string)row["maMon"];
            this.TenMon = (string)row["ten"];
        }
    }
}
