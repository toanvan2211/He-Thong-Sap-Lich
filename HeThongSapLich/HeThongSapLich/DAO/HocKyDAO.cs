using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HeThongSapLich.DAO
{
    public class HocKyDAO
    {
        private static HocKyDAO instance;

        public static HocKyDAO Instance
        {
            get { if (instance == null) instance = new HocKyDAO(); return instance; }
            private set { instance = value; }
        }

        public HocKyDAO() { }

        public DataTable LayDSHocKy()
        {
            string query = "select * from hocky";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string LayMaHocKy(string tenHocKy)
        {
            string query = "select maHocKy from hocky where tenHocKy like N'" + tenHocKy + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0]["maHocKy"].ToString();
            }
            else
            {
                return "null";
            }
        }

        public int ThemHocKy(string maHocKy, string tenHocKy, DateTime tgbd, DateTime tgkt)
        {
            string query = "USP_ThemHocKy @maHocKy , @tenHocKy , @tgbd , @tgkt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHocKy, tenHocKy, tgbd, tgkt });
        }

        public int XoaHocKy(string maHocKy)
        {
            string query = "delete hocKy where maHocKy = '" + maHocKy + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
