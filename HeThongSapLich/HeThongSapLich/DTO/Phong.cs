using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class Phong
    {
        private string maPhong;

        public string MaPhong { get => maPhong; set => maPhong = value; }

        public Phong() { }

        public Phong(string maPhong)
        {
            this.MaPhong = maPhong;
        }

        public Phong(DataRow row)
        {
            this.MaPhong = (string)row["maPhong"];
        }
    }
}
