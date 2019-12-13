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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        void LamMoi()
        {
            tbMatKhauCu.ResetText();
            tbMatKhauMoi.ResetText();
            tbMatKhauMoi1.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMatKhauCu.Text) && !string.IsNullOrEmpty(tbMatKhauMoi.Text) && !string.IsNullOrEmpty(tbMatKhauMoi1.Text))
            {
                if (tbMatKhauMoi.Text == tbMatKhauMoi1.Text)
                {
                    if (tbMatKhauCu.Text == Login.matKhauNow)
                    {
                        if (TaiKhoanDAO.Instance.DoiMatKhau(Login.user, tbMatKhauMoi.Text) != 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login.matKhauNow = tbMatKhauMoi.Text;
                            LamMoi();
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbMatKhauCu.ResetText();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không giống nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMatKhauMoi1.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
