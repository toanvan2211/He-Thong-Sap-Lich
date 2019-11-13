using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongSapLich.DAO
{
    public class LichThiDAO
    {
        private static LichThiDAO instance;

        public static LichThiDAO Instance
        {
            get { if (instance == null) instance = new LichThiDAO(); return instance; }
            private set { instance = value; }
        }

        public LichThiDAO() { }

        public DataTable LayDSLichThi(string maHocKy)
        {
            DataTable data = new DataTable();

            string query = "select maLichThi, maPhong, maGiangVien, maLHP, format (ngayThi, 'dd/MM/yyyy') as NgayThi, caThi, maHocKy from lichThi where maHocKy = '" + maHocKy + "'";

            data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable LayDSLichThiChuaFormat(string maHocKy)
        {
            DataTable data = new DataTable();

            string query = "select * from lichThi where maHocKy = '" + maHocKy + "'";

            data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable LayLichThiTheoMa(string maLichThi)
        {
            string query = "select maLichThi, maPhong, maGiangVien, maLHP, format (ngayThi, 'dd/MM/yyyy') as NgayThi, caThi, maHocKy from lichThi where maLichThi = '" + maLichThi + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LayLichThiTheoMaChuaFormat(string maLichThi)
        {
            string query = "select * from lichThi where maLichThi = '" + maLichThi + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatGiangVienGacThi(string maGV, string maLichThi)
        {
            string query = "update LichThi set maGiangVien = '" + maGV + "' where maLichThi = '" + maLichThi + "'";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable LayCaThiTheoMaGV(string maGV)
        {
            string Lenh = "Select cathi from lichThi where magiangvien = '" + maGV + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(Lenh);
            return dt;
        }

        public DataTable LayNgayThiTheoMaGV(string maGV) //nao ranh bo cai nay voi cai o tren gium tao
        {
            string Lenh = "Select ngayThi from lichThi where magiangvien = '" + maGV + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(Lenh);
            return dt;
        }

        public DataTable LayLichThiTheoMaGV(string maGV)
        {
            string Lenh = "select * from LichThi where magiangvien = '" + maGV + "'";
            return DataProvider.Instance.ExecuteQuery(Lenh);
        }

        public DataTable LayLichThiKhongCoGiangVienGac()
        {
            string Lenh = "select * from LichThi where magiangvien is null";
            return DataProvider.Instance.ExecuteQuery(Lenh);
        }

        public bool KiemTraTonTaiGVGac(string maLichThi)
        {
            string query = "select * from LichThi where maLichThi = '" + maLichThi + "' and maGiangVien is null";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if(dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Đã có giảng viên gác, vui lòng chọn lịch khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }


        public void ResetLichThi()
        {
            string Lenh = "update LichThi set maGiangVien = null where magiangvien is not null";
            DataProvider.Instance.ExecuteNonQuery(Lenh);
        }
    }
}
