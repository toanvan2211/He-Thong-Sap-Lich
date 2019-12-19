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
    public partial class ChinhSuaLop : Form
    {
        string maLop;
        public ChinhSuaLop(string maLop)
        {
            InitializeComponent();
            this.maLop = maLop;
            KhoiTao();
        }

        void KhoiTao()
        {
            DataTable dt = LopDAO.Instance.LayDSLopTheoMa(maLop);

            tbMaLop.Text = dt.Rows[0]["maLop"].ToString();
            tbTenLop.Text = dt.Rows[0]["tenLop"].ToString();
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
            if (LopDAO.Instance.ChinhSuaLop(maLop, tbTenLop.Text) != 0)
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
