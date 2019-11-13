using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich
{
    class MonOBJ
    {
        string maMon, tenMon, maGV;
        UInt16 thoiGianThi;

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public ushort ThoiGianThi { get => thoiGianThi; set => thoiGianThi = value; }

        public MonOBJ() { }
        public MonOBJ(string maMon, string tenMon, string maGV, UInt16 thoiGianThi)
        {
            MaMon = maMon;
            TenMon = tenMon;
            MaGV = maGV;
            ThoiGianThi = thoiGianThi;
        }
    }
}
