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

            data = DataProvider.Instance.ExecuteQuery("USP_LayDSLop");

            return data;   
        }
    }
}
