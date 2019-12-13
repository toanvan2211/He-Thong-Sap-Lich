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
    public partial class UC_TaoLich : UserControl
    {
        string maKyThi, maLich;
        public static string maLHP, maMon, maHocKy;
        List<Mon> listMon = new List<Mon>();
        public UC_TaoLich()
        {
            InitializeComponent();
            LoadComboBox();
            LoadKyThi();
            LoadDSLichThi();
        }

        #region PhuongThuc

        void LoadComboBox()
        {
            LoadPhong();
            LoadMon();
            LoadHocKy();
            LoadLHP();
            cbCaThi.SelectedIndex = 0;
        }

        void LayMaHocKy()
        {
            List<HocKy> listHK = new List<HocKy>();
            DataTable dt = HocKyDAO.Instance.LayDSHocKy();
            foreach (DataRow item in dt.Rows)
            {
                HocKy hk = new HocKy(item);
                listHK.Add(hk);
            }

            maHocKy = listHK[cbHocKy.SelectedIndex].MaHocKy;
        }

        void LoadDSLichThi()
        {
            if (maKyThi != "null" || !string.IsNullOrEmpty(maKyThi))
            {
                dgvLichThi.DataSource = LichThiDAO.Instance.LayDSLichThi(maKyThi);
            }
        }

        void LoadMon()
        {
            DataTable dt = MonDAO.Instance.LayDSMon();
            listMon.Clear();

            foreach (DataRow item in dt.Rows)
            {
                Mon m = new Mon(item);
                listMon.Add(m);
            }

            cbMon.DataSource = dt;
            cbMon.DisplayMember = "ten";
            cbMon.SelectedIndex = 0;
        }

        void LoadKyThi()
        {
            DataTable dt = HocKyDAO.Instance.LayDSHocKy();

            cbKyThi.DataSource = dt;
            cbKyThi.DisplayMember = "tenHocKy";
        }

        void LoadPhong()
        {
            DataTable dt = PhongDAO.Instance.LoadDSPhong();

            cbPhong.DataSource = dt;
            cbPhong.DisplayMember = "maPhong";
        }

        void LoadHocKy()
        {
            DataTable dt = HocKyDAO.Instance.LayDSHocKy();

            cbHocKy.DataSource = dt;
            cbHocKy.DisplayMember = "tenHocKy";
        }

        void LoadLHP()
        {
            DataTable dt = LopHocPhanDAO.Instance.LayDSLopHocPhan();

            cbLHP.DataSource = dt;
            cbLHP.DisplayMember = "maLHP";
        }
        #endregion

        private void cbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKyThi = HocKyDAO.Instance.LayMaHocKy(cbKyThi.Text);
            if (maKyThi == "null")
            {
                maKyThi = HocKyDAO.Instance.LayDSHocKy().Rows[0]["maHocKy"].ToString();
            }
            LoadDSLichThi();
        }

        private void btnTaoLich_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMa.Text))
            {
                LayMaHocKy();
                try
                {
                    LichThiDAO.Instance.ThemLichThi(tbMa.Text, cbPhong.Text, cbLHP.Text, dpNgayThi.Value, cbCaThi.Text, maHocKy);
                }
                catch (System.Data.SqlClient.SqlException a)
                {
                    MessageBox.Show("Mã lịch đã tồn tại \n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                

                LoadDSLichThi();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã lịch thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maLich))
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa lịch thi này?\nLịch này sẽ bị xóa vĩnh viễn.", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        if (LichThiDAO.Instance.XoaLich(maLich) == 1)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        LoadDSLichThi();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Lịch này đã không tồn tại!\nLỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            using (ThemMon tm = new ThemMon())
            {
                tm.ShowDialog();
            }
            LoadMon();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            maMon = listMon[cbMon.SelectedIndex].MaMon;

            using (XoaMon xm = new XoaMon())
            {
                xm.ShowDialog();
            }
            LoadMon();
            LoadDSLichThi();
        }

        private void btnThemHocKy_Click(object sender, EventArgs e)
        {
            using (ThemHocKy thk = new ThemHocKy())
            {
                thk.ShowDialog();
            }
            LoadHocKy();
            LoadKyThi();
        }

        private void btnXoaHocKy_Click(object sender, EventArgs e)
        {
            LayMaHocKy();

            using (XoaHocKy xhk = new XoaHocKy())
            {
                xhk.ShowDialog();
            }

            LoadHocKy();
            LoadKyThi();
            LoadDSLichThi();
        }

        private void btnThemLHP_Click(object sender, EventArgs e)
        {
            using (ThemLHP tlhp = new ThemLHP())
            {
                tlhp.ShowDialog();
            }
            LoadLHP();
        }

        private void btnXoaLHP_Click(object sender, EventArgs e)
        {
            maLHP = cbLHP.Text;
            using (XoaLHP xlhp = new XoaLHP())
            {
                xlhp.ShowDialog();
            }
            LoadLHP();
            LoadDSLichThi();
        }

        private void dgvLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvLichThi.CurrentRow.Selected = true;
                maLich = dgvLichThi.CurrentRow.Cells["maLichThi"].Value.ToString();
            }
            catch { }
        }
    }
}
