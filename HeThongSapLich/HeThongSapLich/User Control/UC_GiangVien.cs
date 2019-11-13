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

namespace HeThongSapLich.User_Control
{
    public partial class UC_GiangVien : UserControl
    {
        public UC_GiangVien()
        {
            InitializeComponent();

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
                tbKhoa.Text = dgvGiangVien.Rows[e.RowIndex].Cells["Khoa"].Value.ToString();
                tbGioiTinh.Text = dgvGiangVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
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
    }
}
