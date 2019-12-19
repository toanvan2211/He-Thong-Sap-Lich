using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class LopDAO
    {
        private static LopDAO instance;

        public static LopDAO Instance
        {
            get { if (instance == null) instance = new LopDAO(); return instance; }
            private set { instance = value; }
        }

        public LopDAO() { }

        public DataTable LoadDSLop()
        {
            DataTable data = new DataTable();
            string query = "select * from Lop";
            data = DataProvider.Instance.ExecuteQuery(query);

            return data;   
        }

        public DataTable LayDSLopTheoMa(string maLop)
        {
            string query = "select * from lop where maLop = '" + maLop + "'";
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

        public int ThemLop(string maLop, string tenLop)
        {
            string query = "USP_TaoLop @maLop , @tenLop";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLop, tenLop });
        }
        public int ThemLop1(string maLop)
        {
            string query = "USP_TaoLop @maLop";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLop});
        }

        public int ChinhSuaLop(string maLop, string tenLop)
        {
            string query = "update lop set tenLop = default where maLop = '" + maLop + "'"; ;
            if (!string.IsNullOrEmpty(tenLop))
            {
                 query = "update lop set tenLop = N'" + tenLop + "' where maLop = '" + maLop + "'";
            }
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int XoaLop(string maLop)
        {
            string query = "delete lop where maLop = '" + maLop + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
