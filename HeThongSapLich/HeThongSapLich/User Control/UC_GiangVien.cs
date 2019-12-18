using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongSapLich.DAO;
using HeThongSapLich.DTO;

namespace HeThongSapLich.User_Control
{
    public partial class UC_GiangVien : UserControl
    {
        int saiMatKhau = 0, demNguoc = 0, thoiGianKhoa = 1800;
                
        public UC_GiangVien()
        {
            InitializeComponent();

            cbKhoa.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;

            if (Login.LoaiTaiKhoan == "admin")
            {
                pnlQuyenAdmin.Visible = true;
                pnlQuyenAdmin.Enabled = true;
                btnCapNhatThongTin.Enabled = true;
                btnCapNhatThongTin.Visible = true;
                btnCapQuyen.Enabled = true;
            }

            LoadGiangVien();
        }

        void LoadGiangVien()
        {
            dgvGiangVien.DataSource = GiangVienDAO.Instance.LayDSGiangVien();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvGiangVien.CurrentRow.Selected = true;
                tbMaGV.Text = dgvGiangVien.Rows[e.RowIndex].Cells["maGiangVien"].FormattedValue.ToString();
                tbTen.Text = dgvGiangVien.Rows[e.RowIndex].Cells["ten"].FormattedValue.ToString();
                cbKhoa.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Khoa"].Value.ToString();
                cbGioiTinh.Text = dgvGiangVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                tbMail.Text = dgvGiangVien.Rows[e.RowIndex].Cells["gmail"].Value.ToString();
            }
            catch { }
        }

        private void btnThemGiangVien_Click(object sender, EventArgs e)
        {
            using (ChinhSuaThongTin tgv = new ChinhSuaThongTin())
            {
                tgv.ShowDialog();
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            using(ChinhSuaThongTin ci = new ChinhSuaThongTin())
            {
                ci.ShowDialog();
            }
            LoadGiangVien();
        }

        private void btnThemGiangVien_Click_1(object sender, EventArgs e)
        {
            using (ThemGiangVien tgv = new ThemGiangVien())
            {
                tgv.ShowDialog();
            }
            LoadGiangVien();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaGV.Text) == false && string.IsNullOrEmpty(tbTen.Text) == false)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thay đổi thông tin của giảng viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        GiangVien gv = new GiangVien();
                        gv.MaGV = tbMaGV.Text;
                        gv.Ten = tbTen.Text;
                        gv.GioiTinh = cbGioiTinh.Text;
                        gv.Khoa = cbKhoa.Text;

                        if (string.IsNullOrEmpty(tbMail.Text) == false)
                        {
                            gv.Gmail = tbMail.Text;
                        }
                        else
                        {
                            gv.Gmail = "";
                        }
                        if (GiangVienDAO.Instance.ChinhSua(gv) > 0)
                        {
                            MessageBox.Show("Chỉnh sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGiangVien();
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapQuyenAdmin_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == Login.matKhauNow)
            {
                string user = TaiKhoanDAO.Instance.LayTenTaiKhoan(tbMaGV.Text);

                if (user == null)
                {
                    MessageBox.Show("Vui lòng chọn giảng viên cần cấp quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMatKhau.ResetText();
                    return;
                }

                DialogResult rs = MessageBox.Show("Hãy xác nhận: bạn có chắc muốn cấp quyền admin cho tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rs == DialogResult.Yes)
                {
                    if (TaiKhoanDAO.Instance.NangQuyenTaiKhoan(user) != 0)
                    {
                        MessageBox.Show("Cấp quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbMatKhau.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbMatKhau.ResetText();
                    }
                }
            }
            else
            {
                saiMatKhau++;
                if (saiMatKhau < 3)
                {
                    MessageBox.Show("Sai mật khẩu, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbMatKhau.ResetText();
                }
                else
                {
                    MessageBox.Show("Nhập mật khẩu sai quá 3 lần. Vui lòng thử lại sau 30 phút.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    btnCapQuyen.Enabled = false;
                    tbMatKhau.Enabled = false;

                    timerKhoa.Start();
                    label5.Visible = true;
                    lbThoiGianKhoa.Visible = true;
                    tbMatKhau.Enabled = false;
                }
            }
        }

        private void timerKhoa_Tick(object sender, EventArgs e)
        {
            int phut, giay;

            demNguoc++;
            phut = (thoiGianKhoa / 60) - (demNguoc / 60) - 1;
            giay = 59 - (demNguoc % 60);
            lbThoiGianKhoa.Text = phut.ToString() + "p" + giay.ToString() + "s";

            if (demNguoc == thoiGianKhoa)
            {
                timerKhoa.Stop();
                demNguoc = 0;
                saiMatKhau = 0;
                for (int i = 0; i < pnlQuyenAdmin.Controls.Count; i++)
                {
                    pnlQuyenAdmin.Controls[i].Enabled = true;
                }
                label5.Visible = false;
                lbThoiGianKhoa.Visible = false;
                tbMatKhau.Enabled = true;
                lbThoiGianKhoa.ResetText();
            }
        }
    }
}
