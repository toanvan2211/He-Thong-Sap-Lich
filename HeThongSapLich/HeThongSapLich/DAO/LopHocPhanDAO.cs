using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class LopHocPhanDAO
    {
        private static LopHocPhanDAO instance;

        public static LopHocPhanDAO Instance
        {
            get { if (instance == null) instance = new LopHocPhanDAO(); return instance; }
            private set { instance = value; }
        }

        public LopHocPhanDAO() { }

        public DataTable LayDSLopHocPhan()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("Select * from LopHocPhan");
            return dt;
        }
        public DataTable LayDSLopHocPhan1(string maLHP)
        {
            string query = "Select * from LopHocPhan where maLHP ='" + maLHP + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt != null)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public int ThemLHP(string maLHP, string maLop, string maMon, byte siSo)
        {
            string query = "USP_ThemLHP @maLHP , @maLop , @maMon , @siSo";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLHP, maLop, maMon, siSo });
        }

        public int ChinhSuaLHP(string maLHP, byte siSo)
        {
            string query = "update lopHocPhan set siSo = " + siSo + "where maLHP = '" + maLHP + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int XoaLHP(string maLHP)
        {
            string query = "USP_XoaLHP @maLHP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLHP });
        }
    }
}
