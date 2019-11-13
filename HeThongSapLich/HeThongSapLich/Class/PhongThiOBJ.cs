using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich
{
    class PhongThiOBJ
    {
        string maPhong, maGV, maMon, trangThai;
        DateTime batDauThi = new DateTime();
        DateTime ketThucThi = new DateTime();

        public DateTime KetThucThi { get => ketThucThi; set => ketThucThi = value; }
        public DateTime BatDauThi { get => batDauThi; set => batDauThi = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public PhongThiOBJ() { }
        public PhongThiOBJ(string maPhong, string maGV, string maMon, DateTime batDauThi, DateTime ketThucThi, string trangThai)
        {
            MaPhong = maPhong;
            MaGV = maGV;
            MaMon = maMon;
            BatDauThi = batDauThi;
            KetThucThi = ketThucThi;
            TrangThai = trangThai;
        }
    }
}
