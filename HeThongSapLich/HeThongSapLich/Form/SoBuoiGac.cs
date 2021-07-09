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
using HeThongSapLich.DTO;

namespace HeThongSapLich
{
    public partial class frPhieuGac : Form
    {
        string MaHocKy;
        List<HocKy> listHocKy = new List<HocKy>();
        public frPhieuGac()
        {
            InitializeComponent();
            LoadKyThi();
            LoadDSGacThi();
        }

        void LoadKyThi()
        {
            DataTable dt = HocKyDAO.Instance.LayDSHocKy();
            foreach (DataRow item in dt.Rows)
            {
                HocKy hk = new HocKy(item);
                listHocKy.Add(hk);
            }
            cbHocKy.DataSource = listHocKy;
            cbHocKy.DisplayMember = "tenHocKy";
            MaHocKy = listHocKy[0].MaHocKy;
        }

        void LoadDSGacThi()
        {
            dgvSoBuoiGac.DataSource = PhieuGacThiDAO.Instance.LayDSGacThi(MaHocKy);
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaHocKy = listHocKy[cbHocKy.SelectedIndex].MaHocKy;
            LoadDSGacThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
