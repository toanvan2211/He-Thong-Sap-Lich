using HeThongSapLich.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public bool KiemTra(string TaiKhoan, string MatKhau)
        {
            string Lenh = "USP_Login @userName , @passWord";

            MatKhau = MaHoa.Instance.GetHash(MatKhau);

            DataTable KetQua = DataProvider.Instance.ExecuteQuery(Lenh, new object[]{TaiKhoan, MatKhau});

            return KetQua.Rows.Count > 0;
        }

        public string LayLoaiTaiKhoan(string user)
        {
            DataRow row = DataProvider.Instance.ExecuteQuery("Select * from taikhoan where taikhoan = '" + user + "'").Rows[0];
            return (string)row["loaiTaiKhoan"];
        }

        public string LayMaGV(string user)
        {
            DataRow row = DataProvider.Instance.ExecuteQuery("Select magiangvien from taikhoan where taikhoan = '" + user + "'").Rows[0];

            return (string)row["magiangvien"];
        }

        public int TaoTaiKhoan(string maGiangVien)
        {
            string query = "USP_TaoTaiKhoan @maGiangVien";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maGiangVien });
        }

        public int NangQuyenTaiKhoan(string taiKhoan)
        {
            string query = "USP_NangQuyenTaiKhoan @taiKhoan";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { taiKhoan });
        }

        public int DoiMatKhau(string taiKhoan, string matKhau)
        {
            matKhau = MaHoa.Instance.GetHash(matKhau);

            string query = "USP_DoiMatKhau @taiKhoan , @matKhau";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { taiKhoan, matKhau });
        }

        public string LayTenTaiKhoan(string maGiangVien)
        {
            string query = "select * from taikhoan where maGiangVien = '" + maGiangVien + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["taiKhoan"].ToString();
            }
            else
            {
                return null;
            }
        }

        public string LayTenTaiKhoan1(string gmail)
        {
            string query = "select tk.taiKhoan from taiKhoan tk, giangVien gv where tk.maGiangVien = gv.maGiangVien and gv.mail = '" + gmail + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0]["taiKhoan"].ToString();
            }
            else
            {
                return null;
            }            
        }
    }
}
