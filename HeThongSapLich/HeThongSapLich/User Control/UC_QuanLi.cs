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

namespace HeThongSapLich
{
    public partial class UC_QuanLi : UserControl
    {
        private static UC_QuanLi instance;

        public static UC_QuanLi Instance
        {
            get { if (instance == null) instance = new UC_QuanLi(); return instance; }
        }

        public UC_QuanLi()
        {
            InitializeComponent();
            KhoiTao();
        }

        public void KhoiTao()
        {
            LoadLHP();
            LoadLop();
            LoadMon();
            LoadHocKy();
        }

        void LoadLHP()
        {
            DataTable dt = LopHocPhanDAO.Instance.LayDSLopHocPhan();
            cbMaLHP.DataSource = dt;
            cbMaLHP.DisplayMember = "maLHP";
            dgvLHP.DataSource = dt;
            cbMaLop1.DataSource = dt;
            cbMaLop1.DisplayMember = "maLop";
            cbMaMon1.DataSource = dt;
            cbMaMon1.DisplayMember = "maMon";
            cbSiSo.DataSource = dt;
            cbSiSo.DisplayMember = "siSo";
        }

        void LoadLop()
        {
            DataTable dt = LopDAO.Instance.LoadDSLop();

            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "maLop";
            cbTenLop.DataSource = dt;
            cbTenLop.DisplayMember = "tenLop";

            dgvLop.DataSource = dt;
        }

        void LoadMon()
        {
            DataTable dt = MonDAO.Instance.LayDSMon();

            cbMaMon.DataSource = dt;
            cbMaMon.DisplayMember = "maMon";
            cbTenMon.DataSource = dt;
            cbTenMon.DisplayMember = "ten";

            dgvMon.DataSource = dt;
        }

        void LoadHocKy()
        {
            DataTable dt = HocKyDAO.Instance.LayDSHocKy();

            cbMaHK.DataSource = dt;
            cbMaHK.DisplayMember = "maHocKy";
            cbTenHK.DataSource = dt;
            cbTenHK.DisplayMember = "tenHocKy";
            cbBD.DataSource = dt;
            cbBD.DisplayMember = "thoiGianBatDau";
            cbKT.DataSource = dt;
            cbKT.DisplayMember = "thoiGianKetThuc";

            dgvHocKy.DataSource = dt;
        }

        private void btnThemLHP_Click(object sender, EventArgs e)
        {
            using (ThemLHP tlhp = new ThemLHP())
            {
                tlhp.ShowDialog();
            }
            LoadLHP();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            using (ThemLop tl = new ThemLop())
            {
                tl.ShowDialog();
            }
            LoadLop();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            using (ThemMon tm = new ThemMon())
            {
                tm.ShowDialog();
            }
            LoadMon();
        }

        private void btnThemHocKy_Click(object sender, EventArgs e)
        {
            using (ThemHocKy thk = new ThemHocKy())
            {
                thk.ShowDialog();
            }
            LoadHocKy();
        }

        private void btnXoaLHP_Click(object sender, EventArgs e)
        {
            using (XoaLHP xlhp = new XoaLHP(cbMaLHP.Text))
            {
                xlhp.ShowDialog();
            }
            LoadLHP();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            using (XoaLop xl = new XoaLop(cbMaLop.Text))
            {
                xl.ShowDialog();
            }
            LoadLop();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            using (XoaMon xm = new XoaMon(cbMaMon.Text))
            {
                xm.ShowDialog();
            }
            LoadMon();
        }

        private void btnXoaHocKy_Click(object sender, EventArgs e)
        {
            using (XoaHocKy xhk = new XoaHocKy(cbMaHK.Text))
            {
                xhk.ShowDialog();
            }
            LoadHocKy();
        }

        private void btnChinhSuaLHP_Click(object sender, EventArgs e)
        {
            using (ChinhSuaLHP cslhp = new ChinhSuaLHP(cbMaLHP.Text))
            {
                cslhp.ShowDialog();
            }
            LoadLHP();
        }

        private void btnChinhSuaLop_Click(object sender, EventArgs e)
        {
            using (ChinhSuaLop csl = new ChinhSuaLop(cbMaLop.Text))
            {
                csl.ShowDialog();
            }
            LoadLop();
        }

        private void btnChinhSuaMon_Click(object sender, EventArgs e)
        {
            using (ChinhSuaMon csm = new ChinhSuaMon(cbMaMon.Text))
            {
                csm.ShowDialog();
            }
            LoadMon();
        }

        private void btnChinhSuaHocKy_Click(object sender, EventArgs e)
        {
            using (ChinhSuaHocKy cshk = new ChinhSuaHocKy(cbMaHK.Text))
            {
                cshk.ShowDialog();
            }
            LoadHocKy();
        }
    }
}
