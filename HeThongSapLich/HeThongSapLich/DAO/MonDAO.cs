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
    }
}
