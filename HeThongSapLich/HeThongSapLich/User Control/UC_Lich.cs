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
using HeThongSapLich.Class;
using System.IO;

namespace HeThongSapLich.User_Control
{
    public partial class UC_Lich : UserControl
    {
        public UC_Lich()
        {
            InitializeComponent();
            LoadKyThi();
        }

        void LoadKyThi()
        {
            cbKyThi.DataSource = HocKyDAO.Instance.LayDSHocKy();
            cbKyThi.DisplayMember = "tenHocKy";
        }

        void LoadLichThi()
        {
            string MaHocKy = HocKyDAO.Instance.LayMaHocKy(cbKyThi.Text);
            if (MaHocKy == "null")
            {
                try
                {
                    MaHocKy = HocKyDAO.Instance.LayDSHocKy().Rows[0]["maHocKy"].ToString();
                }
                catch { }
            }
            dgvLichThi.DataSource = LichThiDAO.Instance.LayDSLichThi2(MaHocKy);
        }

        private void cbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLichThi();
        }

        private void dgvLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvLichThi.CurrentCell.Selected = true;
            }
            catch { }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string titles = "Danh sách lịch thi " + cbKyThi.Text;

            DataTable dt = (DataTable)dgvLichThi.DataSource;
                        
            ExportToExcel excel = new ExportToExcel();
            excel.Export(dt, "sheet 1", titles);
        }
    }
}
