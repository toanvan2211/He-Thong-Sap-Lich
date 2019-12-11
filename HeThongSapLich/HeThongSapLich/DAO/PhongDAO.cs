using HeThongSapLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class PhongDAO
    {
        public static int buttonWidth = 150;
        public static int buttonHeight = 50;

        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }
        }

        private PhongDAO() { }

        public DataTable LoadDSPhong()
        {
            DataTable dt = new DataTable();

            dt = DataProvider.Instance.ExecuteQuery("Select * from Phong");

            return dt;
        }
    }
}
