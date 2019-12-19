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
    public partial class ChinhSuaMon : Form
    {
        string maMon;
        public ChinhSuaMon(string maMon)
        {
            InitializeComponent();
            this.maMon = maMon;
            KhoiTao();
        }

        void KhoiTao()
        {
            DataTable dt = MonDAO.Instance.LayDSMonTheoMa(maMon);

            tbMaMon.Text = dt.Rows[0]["maMon"].ToString();
            tbTenMon.Text = dt.Rows[0]["ten"].ToString();
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
            if (MonDAO.Instance.ChinhSuaMon(maMon, tbTenMon.Text) != 0)
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
