using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class MonDAO
    {
        private static MonDAO instance;

        public static MonDAO Instance
        {
            get { if (instance == null) instance = new MonDAO(); return instance; }
            private set { instance = value; }
        }

        public MonDAO() { }

        public DataTable LayDSMon()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("Select * from mon");

            return dt;
        }

        public DataTable LayDSMonTheoMa(string maMon) 
        {
            string query = "select * from mon where maMon = '" + maMon + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public int ThemMon(string maMon, string tenMon)
        {
            string query = "USP_ThemMon @maMon , @tenMon";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maMon, tenMon });
        }

        public int ChinhSuaMon(string maMon, string tenMon)
        {
            string query = "update mon set ten = default where maMon = '" + maMon + "'"; ;
            if (!string.IsNullOrEmpty(tenMon))
            {
                query = "update mon set ten = N'" + tenMon + "' where maMon = '" + maMon + "'";
            }
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int XoaMon(string maMon)
        {
            string query = "delete Mon where maMon = '" + maMon + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable LayDSLichThiTheoMaMon(string maMon)
        {
            string query = "select lt.* from lichThi lt, LopHocPhan lhp where lt.maLHP = lhp.maLHP and lhp.maMon = '" + maMon + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
