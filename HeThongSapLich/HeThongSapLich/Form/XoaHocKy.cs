using HeThongSapLich.DAO;
using HeThongSapLich.User_Control;
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
    public partial class XoaHocKy : Form
    {
        public XoaHocKy()
        {
            InitializeComponent();
            LoadLichThi();
        }

        void LoadLichThi()
        {
            dgvLichThi.DataSource = LichThiDAO.Instance.LayDSLichThiChuaFormat(UC_TaoLich.maHocKy);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (HocKyDAO.Instance.XoaHocKy(UC_TaoLich.maHocKy) != 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException a)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
