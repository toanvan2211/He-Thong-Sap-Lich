using HeThongSapLich.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongSapLich.DTO;

namespace HeThongSapLich
{
    public partial class ChinhSuaThongTin : Form
    {
        GiangVien gv;
        public ChinhSuaThongTin()
        {
            InitializeComponent();
            cbGioiTinh.SelectedIndex = 0;
            LoadThongTin();
        }

        void LoadThongTin()
        {
            DataRow row = GiangVienDAO.Instance.LayThongTin(TaiKhoanDAO.Instance.LayMaGV(Login.user));
            gv = new GiangVien(row);

            tbMaGV.Text = gv.MaGV;
            tbTen.Text = gv.Ten;
            tbKhoa.Text = gv.Khoa;
            tbGmail.Text = gv.Gmail;
            cbGioiTinh.Text = gv.GioiTinh;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }

        bool KiemTra()
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(tbKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gv.Ten = tbTen.Text;
            gv.Khoa = tbKhoa.Text;
            gv.Gmail = tbGmail.Text;
            gv.GioiTinh = cbGioiTinh.Text;

            if (KiemTra())
            {
                if (GiangVienDAO.Instance.ChinhSua(gv) > 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
