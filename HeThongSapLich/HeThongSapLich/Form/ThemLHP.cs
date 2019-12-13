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
    public partial class ThemLHP : Form
    {
        public ThemLHP()
        {
            InitializeComponent();
            LoadThongTin();
        }

        #region MyRegion

        void LoadThongTin()
        {
            LoadMaMon();
            LoadMaLop();
            nupSiSo.Value = nupSiSo.Minimum;
        }

        void LoadMaMon()
        {
            DataTable dt = MonDAO.Instance.LayDSMon();

            cbMaMon.DataSource = dt;
            cbMaMon.DisplayMember = "maMon";
        }

        void LoadMaLop()
        {
            DataTable dt = LopDAO.Instance.LoadDSLop();

            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "maLop";
        }

        #endregion

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = LopDAO.Instance.LayDSLopTheoMa(cbMaLop.Text);
            if (dt != null)
            {
                tbTenLop.Text = dt.Rows[0]["tenLop"].ToString();
            }
            else
            {
                dt = LopDAO.Instance.LoadDSLop();
                tbTenLop.Text = dt.Rows[0]["tenLop"].ToString();
            }
        }

        private void cbMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = MonDAO.Instance.LayDSMonTheoMa(cbMaMon.Text);
            if (dt != null)
            {
                tbTenMon.Text = dt.Rows[0]["ten"].ToString();
            }
            else
            {
                dt = MonDAO.Instance.LayDSMon();
                tbTenMon.Text = dt.Rows[0]["ten"].ToString();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaLHP.Text))
            {
                try
                {
                    if (LopHocPhanDAO.Instance.ThemLHP(tbMaLHP.Text, cbMaLop.Text, cbMaMon.Text, Convert.ToByte(nupSiSo.Value)) != 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Data.SqlClient.SqlException a)
                {
                    MessageBox.Show("Đã tồn tại mã lớp học phần này.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadThongTin();
        }
    }
}
