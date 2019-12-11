using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class GacThiDAO
    {
        private static GacThiDAO instance;

        public static GacThiDAO Instance
        {
            get { if (instance == null) instance = new GacThiDAO(); return instance; }
            private set { instance = value; }
        }

        public GacThiDAO() { }

        public DataTable LayDSGacThi(string maHocKy)
        {
            string query = "select * from gacthi where maHocKy = '" + maHocKy + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LaySoBuoiGac(string maHocKy, byte soBuoiGac)
        {
            string query = "select * from GacThi where maHocKy = '" + maHocKy + "' and sobuoigac < " + soBuoiGac.ToString();

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int CapNhatSoBuoiGac(string MaGiangVien, byte soBuoiGac)
        {
            string query = "update GacThi set soBuoiGac = " + soBuoiGac + "where maGiangVien = '" + MaGiangVien + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataRow LayThongTin(string maGiangVien)
        {
            string query = "select * from gacthi where maGiangVien = '" + maGiangVien + "'";
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
            string query = "update gacThi set soBuoiGac = 0 where maHocKy = '" + maHocKy + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int TaoPhieuGac(string maGV, string maHocKy)
        {
            string query = "USP_TaoPhieuGacThi @maGV , @maHocKy";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maGV, maHocKy });
        }
    }
}
