﻿using System;
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
    }
}
