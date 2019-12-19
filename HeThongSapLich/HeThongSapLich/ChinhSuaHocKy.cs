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

namespace HeThongSapLich
{
    public partial class ChinhSuaHocKy : Form
    {
        string maHK;
        public ChinhSuaHocKy(string maHK)
        {
            InitializeComponent();
            this.maHK = maHK;
            KhoiTao();
        }

        void KhoiTao()
        {
            DataTable dt = HocKyDAO.Instance.LayDSHocKyTheoMa(maHK);

            tbMaHK.Text = dt.Rows[0]["maHocKy"].ToString();
            tbTenHK.Text = dt.Rows[0]["tenHocKy"].ToString();
            dtpkBDHK.Value = (DateTime)dt.Rows[0]["thoiGianBatDau"];
            dtpkKTHK.Value = (DateTime)dt.Rows[0]["thoiGianKetThuc"];
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (HocKyDAO.Instance.ChinhSuaHocKy(maHK, tbTenHK.Text, dtpkBDHK.Value, dtpkKTHK.Value) != 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại sau", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
