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
        private static UC_ThongTin instance;

        public static UC_ThongTin Instance
        {
            get { if (instance == null) instance = new UC_ThongTin(); return instance; }
        }

        public UC_ThongTin()
        {
            InitializeComponent();

            LoadThongTin();

            if (pbAnhHoSo.Image == null)
            {
                pbThemAnh.Visible = true;
                pbThemAnh.Enabled = true;
            }

        }

        void ThemHinh()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbAnhHoSo.Image = new Bitmap(dlg.FileName);
                    pbThemAnh.Visible = false;
                    pbThemAnh.Enabled = false;
                }
            }
        }

        public void LoadThongTin()
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

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (DoiMatKhau dmt = new DoiMatKhau())
            {
                dmt.ShowDialog();
            }
        }

        private void ptbThemAnh_Click(object sender, EventArgs e)
        {
            ThemHinh();
        }
    }
}
