using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongSapLich.DAO;
using HeThongSapLich.DTO;

namespace HeThongSapLich
{
    public partial class ThemGiangVien : Form
    {
        string maGV;

        public ThemGiangVien()
        {
            InitializeComponent();
            cbGioiTinh.SelectedIndex = 0;
            cbKhoa.SelectedIndex = 0;

        }

        int TaoTaiKhoan()
        {
            return TaiKhoanDAO.Instance.TaoTaiKhoan(maGV);
        }

        void ThemGV()
        {
            if (!string.IsNullOrEmpty(tbMaGV.Text) && !string.IsNullOrEmpty(tbTen.Text))
            {
                maGV = tbMaGV.Text;

                if (!string.IsNullOrEmpty(tbGmail.Text))
                {
                    GiangVien gv = new GiangVien();
                    gv.MaGV = tbMaGV.Text;
                    gv.Ten = tbTen.Text;
                    gv.Khoa = cbKhoa.Text;
                    gv.GioiTinh = cbGioiTinh.Text;
                    gv.Gmail = tbGmail.Text;

                    if (GiangVienDAO.Instance.ThemGiangVien(gv) != 0)
                    {
                        if (TaoTaiKhoan() != 0)
                        {
                            MessageBox.Show("Thêm giảng viên thành công!\n Tài khoản: '" + maGV + "'. Mật khẩu: '1'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            GiangVienDAO.Instance.XoaGiangVien(maGV);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    GiangVien gv = new GiangVien();
                    gv.MaGV = tbMaGV.Text;
                    gv.Ten = tbTen.Text;
                    gv.Khoa = cbKhoa.Text;
                    gv.GioiTinh = cbGioiTinh.Text;

                    if (GiangVienDAO.Instance.ThemGiangVien1(gv) != 0)
                    {
                        if (TaoTaiKhoan() != 0)
                        {
                            MessageBox.Show("Thêm giảng viên thành công!\n Tài khoản: '" + maGV + "'. Mật khẩu: '1'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            GiangVienDAO.Instance.XoaGiangVien(maGV);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemGV();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
