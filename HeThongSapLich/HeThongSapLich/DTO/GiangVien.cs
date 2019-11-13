using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class GiangVien
    {
        private string maGV;
        public string MaGV { get => maGV; set => maGV = value; }

        private string ten;
        public string Ten { get => ten; set => ten = value; }
        public GiangVien() { }

        public string Khoa { get; set; }
        public string GioiTinh { get; set; }
        public string Gmail { get; set; }

        public GiangVien(DataRow row)
        {
            this.Ten = (string)row["ten"];
            this.MaGV = (string)row["maGiangVien"];
            this.Khoa = (string)row["Khoa"];
            if(row["gmail"] != DBNull.Value)
                this.Gmail = (string)row["gmail"];
            this.GioiTinh = (string)row["gioiTinh"];
        }
    }
}
