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
        public UC_QuanLi()
        {
            InitializeComponent();
            KhoiTao();
        }

        void KhoiTao()
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

            dgvHocKy.DataSource = dt;
        }
    }
}
