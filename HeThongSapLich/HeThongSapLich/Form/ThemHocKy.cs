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
    public partial class ThemHocKy : Form
    {
        public ThemHocKy()
        {
            InitializeComponent();
        }
        
        void LamMoi()
        {
            tbMaHocKy.Text = "";
            tbTenHocKy.Text = "";
            dpThoiGianBD.ResetText();
            dpThoiGianKT.ResetText();            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void ThemHocKy_Load(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaHocKy.Text) && !string.IsNullOrEmpty(tbTenHocKy.Text))
            {
                try
                {
                    if (HocKyDAO.Instance.ThemHocKy(tbMaHocKy.Text, tbTenHocKy.Text, dpThoiGianBD.Value, dpThoiGianKT.Value) != 0)
                    {
                        MessageBox.Show("Tạo học kỳ thành công.\nMã học kỳ: " + tbMaHocKy.Text + ". Tên: " + tbTenHocKy.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Data.SqlClient.SqlException a)
                {
                    MessageBox.Show("Đã tồn tại môn này.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
