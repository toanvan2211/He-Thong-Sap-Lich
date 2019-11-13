using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich
{
    class GiangVienOBJ
    {
        string maGV, tenGV, trangThai;

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public GiangVienOBJ() { }
        public GiangVienOBJ(string maGV, string tenGV, string trangThai)
        {
            MaGV = maGV;
            TenGV = tenGV;
            TrangThai = trangThai;
        }
    }
}
