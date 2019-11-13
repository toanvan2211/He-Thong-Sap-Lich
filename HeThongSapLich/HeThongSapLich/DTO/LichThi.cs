using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DTO
{
    public class LichThi
    {
        private string maLichThi;

        private string maPhong;

        private string maGV;

        private string maLHP;

        private DateTime ngayThi;

        private string caThi;

        private string MaHocKy;

        public string MaLichThi { get => maLichThi; set => maLichThi = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public string MaLHP { get => maLHP; set => maLHP = value; }
        public DateTime NgayThi { get => ngayThi; set => ngayThi = value; }
        public string CaThi { get => caThi; set => caThi = value; }
        public string MaHocKy1 { get => MaHocKy; set => MaHocKy = value; }

        public LichThi() { }

        public LichThi(DataRow row)
        {
            this.MaLichThi = (string)row["maLichThi"];
            this.MaPhong = (string)row["maPhong"];
            if (row["maGiangVien"] != DBNull.Value)
                this.MaGV = (string)row["maGiangVien"];

            this.MaLHP = (string)row["maLHP"];
            this.NgayThi = (DateTime)row["NgayThi"];
            this.CaThi = (string)row["caThi"].ToString();
            this.MaHocKy = (string)row["maHocKy"].ToString();
        }
    }
}
