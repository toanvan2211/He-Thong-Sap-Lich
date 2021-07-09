using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class PhieuGacThi
    {
        public int MaGacThi { get; set; }
        public string MaGiangVien { get; set; }
        public byte SoBuoiGac { get; set; }
        public string MaHocKy { get; set; }

        public PhieuGacThi() { }

        public PhieuGacThi(DataRow row)
        {
            this.MaGacThi = (int)row["maGacThi"];
            this.MaGiangVien = (string)row["maGiangVien"];
            this.SoBuoiGac = (byte)row["soBuoiGac"];
            this.MaHocKy = (string)row["MaHocKy"];
        }
    }
}
