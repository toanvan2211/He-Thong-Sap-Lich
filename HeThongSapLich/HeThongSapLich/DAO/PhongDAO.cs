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

        public List<Phong> LoadDSPhong()
        {
            List<Phong> listPhong = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LayDSPhong");

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                listPhong.Add(phong);
            }

            return listPhong;
        }
    }
}
