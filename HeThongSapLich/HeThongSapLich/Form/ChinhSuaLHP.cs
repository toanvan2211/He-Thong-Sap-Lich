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
    public partial class ChinhSuaLHP : Form
    {
        string maLHP;
        public ChinhSuaLHP(string maLHP)
        {
            InitializeComponent();
            this.maLHP = maLHP;
            KhoiTao();
        }

        void KhoiTao()
        {
            DataTable dt = LopHocPhanDAO.Instance.LayDSLopHocPhan1(maLHP);

            if (dt != null)
            {
                tbMaLHP.Text = dt.Rows[0]["maLHP"].ToString();
                tbMaLop.Text = dt.Rows[0]["maLop"].ToString();
                tbMaMon.Text = dt.Rows[0]["maMon"].ToString();
                nupSiSo.Value = Convert.ToDecimal(dt.Rows[0]["siSo"]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (LopHocPhanDAO.Instance.ChinhSuaLHP(maLHP, Convert.ToByte(nupSiSo.Value)) != 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại sau", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
