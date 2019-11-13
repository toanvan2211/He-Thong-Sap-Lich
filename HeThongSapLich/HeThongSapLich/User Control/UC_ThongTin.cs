using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongSapLich.DAO;
using HeThongSapLich.DTO;

namespace HeThongSapLich.User_Control
{
    public partial class UC_ThongTin : UserControl
    {
        public UC_ThongTin()
        {
            InitializeComponent();

            LoadThongTin();

        }

        void LoadThongTin()
        {
            string TaiKhoan = Login.user; //Thông tin tài khoản đã đăng nhập

            string maGV = TaiKhoanDAO.Instance.LayMaGV(TaiKhoan); 

            DataRow row = GiangVienDAO.Instance.LayThongTin(maGV); 

            GiangVien gv = new GiangVien(row);

            lbMaGV.Text = "Mã giảng viên:   " + gv.MaGV;
            lbTenGiangVien.Text = "Tên:   " + gv.Ten;
            lbKhoa.Text = "Khoa:   " + gv.Khoa;
            lbGioiTinh.Text = "Giới tính:   " + gv.GioiTinh;
            lbGmail.Text = "Gmail:   " + gv.Gmail;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            using(ChinhSuaThongTin ci = new ChinhSuaThongTin())
            {
                ci.ShowDialog();
            }
            LoadThongTin();
        }
    }
}
