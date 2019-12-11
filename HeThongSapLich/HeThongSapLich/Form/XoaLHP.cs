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
    public partial class XoaLHP : Form
    {
        public XoaLHP()
        {
            InitializeComponent();
        }

        private void XoaLHP_Load(object sender, EventArgs e)
        {
            LoadLichThi();
        }

        void LoadLichThi()
        {
            dgvLichThi.DataSource = LichThiDAO.Instance.LayLichThiTheoMaLHP(UC_TaoLich.maLHP);
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
                LopHocPhanDAO.Instance.XoaLHP(UC_TaoLich.maLHP);
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại sau.\n Lỗi: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
