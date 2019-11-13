using HeThongSapLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class GiangVienDAO
    {
        private static GiangVienDAO instance;

        public static GiangVienDAO Instance
        {
            get { if (instance == null) instance = new GiangVienDAO(); return instance; }
            private set { instance = value; }
        }

        public GiangVienDAO() { }

        public DataTable LayDSGiangVien()
        {
            DataTable data = new DataTable();

            string query = "Select * from giangvien";

            data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataRow LayThongTin(string maGV)
        {
            DataRow row = DataProvider.Instance.ExecuteQuery("Select * from Giangvien where magiangvien = '" + maGV + "'").Rows[0];

            return row;
        }

        public bool ChinhSua(GiangVien gv)
        {
            string query = "update giangvien set ten = N'" + gv.Ten + "', khoa = N'" + gv.Khoa + "', gioiTinh = N'" + gv.GioiTinh + "', gmail = '" + gv.Gmail + "' where maGiangVien = '" + gv.MaGV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) == 1;
        }

        public bool ThemGiangVien(GiangVien gv)
        {
            string query = "Insert into giangvien values ('" + gv.MaGV + "',N'" + gv.Ten + "',N'" + gv.Khoa + "','" + gv.Gmail + "', N'" + gv.GioiTinh + "')";
            return DataProvider.Instance.ExecuteNonQuery(query) == 1;
        }
    }
}
