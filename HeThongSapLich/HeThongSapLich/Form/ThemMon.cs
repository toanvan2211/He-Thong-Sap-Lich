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
    public partial class ThemMon : Form
    {
        public ThemMon()
        {
            InitializeComponent();
        }

        #region PhuongThuc

        void LamMoi()
        {
            tbMaMon.Text = "";
            tbTenMon.Text = "";
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaMon.Text) && !string.IsNullOrEmpty(tbTenMon.Text))
            {
                try
                {
                    if (MonDAO.Instance.ThemMon(tbMaMon.Text, tbTenMon.Text) != 0)
                    {
                        MessageBox.Show("Tạo môn thành công.\nMã môn: " + tbMaMon.Text + ". Tên: " + tbTenMon.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Đã tồn tại môn này.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
