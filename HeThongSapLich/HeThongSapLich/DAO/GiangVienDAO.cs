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

        public int ChinhSua(GiangVien gv)
        {
            string query = "update giangvien set ten = N'" + gv.Ten + "', khoa = N'" + gv.Khoa + "', gioiTinh = N'" + gv.GioiTinh + "', mail = '" + gv.Gmail + "' where maGiangVien = '" + gv.MaGV + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int ThemGiangVien(GiangVien gv)
        {
            string query = "USP_ThemGiangVien @maGV , @ten , @Khoa , @GioiTinh , @gmail";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { gv.MaGV, gv.Ten, gv.Khoa, gv.GioiTinh, gv.Gmail});
        }
        public int ThemGiangVien1(GiangVien gv)
        {
            string query = "USP_ThemGiangVien1 @maGV , @ten , @Khoa , @GioiTinh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { gv.MaGV, gv.Ten, gv.Khoa, gv.GioiTinh});
        }

        public int XoaGiangVien(string maGiangVien)
        {
            string query = "delete giangVien where maGiangVien = '" + maGiangVien + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable LayGmail(string gmail)
        {
            string query = "select * from giangVien where mail = '" + gmail + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
