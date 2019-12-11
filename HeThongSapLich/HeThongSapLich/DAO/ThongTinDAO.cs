using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class ThongTinDAO
    {
        private static ThongTinDAO instance;

        public static ThongTinDAO Instance
        {
            get { if (instance == null) instance = new ThongTinDAO(); return instance; }
            private set { instance = value; }
        }

        public ThongTinDAO() { }

        //public DataTable LoadDSLop()
        //{
        //    DataTable data = new DataTable();

        //    data = DataProvider.Instance.ExecuteQuery("USP_LayDSGiangVien");

        //    return data;
        //}
    }
}
