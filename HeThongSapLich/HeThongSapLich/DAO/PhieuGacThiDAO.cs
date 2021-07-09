using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class PhieuGacThiDAO
    {
        private static PhieuGacThiDAO instance;

        public static PhieuGacThiDAO Instance
        {
            get { if (instance == null) instance = new PhieuGacThiDAO(); return instance; }
            private set { instance = value; }
        }

        public PhieuGacThiDAO() { }

        public DataTable LayDSGacThi(string maHocKy)
        {
            string query = "select * from phieuGacThi where maHocKy = '" + maHocKy + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayPhieuGacChuaDuBuoiGac(string maHocKy, byte soBuoiGac)
        {
            string query = "select * from phieuGacThi where maHocKy = '" + maHocKy + "' and sobuoigac < " + soBuoiGac.ToString();

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayPhieuGacTheoMaGV(string maGV, string maHK)
        {
            string query = "select * from phieuGacThi where maGiangVien = '" + maGV + "' and maHocKy = '" + maHK + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int CapNhatSoBuoiGac(int maPhieuGac, byte soBuoiGac)
        {
            string query = "update phieuGacThi set soBuoiGac = " + soBuoiGac + "where maGacThi = " + maPhieuGac;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataRow LayThongTin(string maGiangVien, string maHocKy)
        {
            string query = "select * from phieuGacThi where maGiangVien = '" + maGiangVien + "' and maHocKy = '" + maHocKy + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public int LamMoi(string maHocKy)
        {
            string query = "delete phieuGacThi where maHocKy = '" + maHocKy + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int XoaPhieuGac(int maPhieu)
        {
            string query = "delete phieuGacThi where maGacThi = " + maPhieu + "";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int TaoPhieuGac(string maGV, string maHocKy)
        {
            string query = "USP_TaoPhieuGacThi @maGV , @maHocKy";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maGV, maHocKy });
        }
    }
}
