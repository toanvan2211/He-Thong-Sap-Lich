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
    }
}
