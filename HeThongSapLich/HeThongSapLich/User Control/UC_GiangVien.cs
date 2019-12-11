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
        public UC_GiangVien()
        {
            InitializeComponent();

            cbKhoa.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;

            if (Login.LoaiTaiKhoan == "admin")
            {
                btnCapNhatThongTin.Visible = true;
                btnCapNhatThongTin.Enabled = true;
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
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thay đổi thông tin của giảng viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
                            gv.Gmail = "NULL";
                        }
                        if (GiangVienDAO.Instance.ChinhSua(gv) > 0)
                        {
                            MessageBox.Show("Chỉnh sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
