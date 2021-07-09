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
    public partial class ThemLop : Form
    {
        public ThemLop()
        {
            InitializeComponent();
        }

        void LamMoi()
        {
            tbMaLop.ResetText();
            tbTenLop.ResetText();
        }

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
            if (!string.IsNullOrEmpty(tbMaLop.Text))
            {
                if (!string.IsNullOrEmpty(tbTenLop.Text))
                {
                    try
                    {
                        if (LopDAO.Instance.ThemLop(tbMaLop.Text, tbTenLop.Text) != 0)
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
                        MessageBox.Show("Đã tồn tại mã lớp này.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        if (LopDAO.Instance.ThemLop1(tbMaLop.Text) != 0)
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
                        MessageBox.Show("Đã tồn tại mã lớp này.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
