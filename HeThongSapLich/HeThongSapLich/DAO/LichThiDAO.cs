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

        public DataTable LayDSLichThi1(string maHocKy)
        {
            string query = "USP_LayDSLichThi @maHocKy";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maHocKy });
            return dt;
        }
        public DataTable LayDSLichThi2(string maHocKy)
        {
            string query = "USP_LayDSLichThi2 @maHocKy";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maHocKy });
            return dt;
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

        public DataTable LayLichThiTheoMaLHP(string maLHP)
        {
            string query = "select * from lichThi where maLHP = '" + maLHP + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayLichThiKhongCoGiangVienGac(string maHocKy)
        {
            string Lenh = "select * from LichThi where magiangvien is null and maHocKy = '" + maHocKy + "'";
            return DataProvider.Instance.ExecuteQuery(Lenh);
        }

        public DataTable LayLichThiTheoMaLop(string maLop)
        {
            string query = "select lt.* from lop l, lopHocPhan lhp, lichThi lt where l.maLop = lhp.maLop and lt.maLHP = lhp.maLHP and l.maLop = '" + maLop + "'";
            return DataProvider.Instance.ExecuteQuery(query);
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
        
        public void ResetLichThi(string maHocKy)
        {
            string query = "update LichThi set maGiangVien = null where magiangvien is not null and maHocKy = '" + maHocKy + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void HuyDangKyGac(string maLichThi)
        {
            string Lenh = "update LichThi set maGiangVien = null where maLichThi = '" + maLichThi + "'";
            DataProvider.Instance.ExecuteNonQuery(Lenh);
        }

        public void ThemLichThi(string maLich, string maPhong, string maLHP, DateTime ngayThi, string caThi, string maHocKy) 
        {
            string query = "USP_ThemLichThi @maLich , @maPhong , @maLHP , @ngayThi , @caThi , @maHocKy";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLich, maPhong, maLHP, ngayThi, caThi, maHocKy });

        }

        public int XoaLich(string maLich)
        {
            string query = "USP_XoaLich @maLich";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLich });
        }
    }
}
