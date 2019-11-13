using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class GacThi
    {
        public string MaGiangVien { get; set; }
        public byte SoBuoiGac { get; set; }
        public string MaHocKy { get; set; }

        public GacThi() { }

        public GacThi(DataRow row)
        {
            this.MaGiangVien = (string)row["maGiangVien"];
            this.SoBuoiGac = (byte)row["soBuoiGac"];
            this.MaHocKy = (string)row["MaHocKy"];
        }
    }
}
