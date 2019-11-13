using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class HocKy
    {
        public string MaHocKy { get; set; }
        public string TenHocKy { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }

        public HocKy() { }

        public HocKy(DataRow row)
        {
            MaHocKy = (string)row["maHocKy"];
            TenHocKy = (string)row["TenHocKy"];
            ThoiGianBD = (DateTime)row["ThoiGianBatDau"];
            ThoiGianKT = (DateTime)row["ThoiGianKetThuc"];
        }
    }
}
