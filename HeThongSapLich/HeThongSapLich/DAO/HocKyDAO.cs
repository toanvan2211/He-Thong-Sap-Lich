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
    }
}
