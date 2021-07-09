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
    public partial class XoaMon : Form
    {
        string maMon;
        public XoaMon(string maMon)
        {
            InitializeComponent();
            this.maMon = maMon;
            LoadLichThi();
        }

        void LoadLichThi()
        {
            dgvLichThi.DataSource = MonDAO.Instance.LayDSLichThiTheoMaMon(maMon);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {                
                if (MonDAO.Instance.XoaMon(maMon) != 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
