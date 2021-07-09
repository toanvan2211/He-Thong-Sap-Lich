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
    public partial class Main : Form
    {
        int panelWidth;
        bool isColapsed;
        bool closed;
        public static string maGV;

        #region Hàm
        private void ThemUC(Control uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlControls.Controls.Add(uc);
            uc.BringToFront();            
        }

        void CapQuyen()
        {
            if (Login.LoaiTaiKhoan == "admin")
            {
                btnSapLich.Text = "   Sắp lịch";
                btnTaoLich.Visible = true;
                btnTaoLich.Enabled = true;
                btnQuanLi.Visible = true;
                btnQuanLi.Enabled = true;
            }
        }

        void LuotPanel(Control a)
        {
            pnlClicked.Top = a.Top;
        }

        void KhoiTao()
        {
            maGV = TaiKhoanDAO.Instance.LayMaGV(Login.user);
            LuotPanel(btnThongTin);
            panelWidth = pnlLeft.Width;
            isColapsed = false;
            closed = true;
            timerTime.Start();

            UC_ThongTin tt = new UC_ThongTin();
            ThemUC(tt);
            LuotPanel(btnThongTin);
            CapQuyen();
        }
        #endregion

        public Main()
        {
            InitializeComponent();
            KhoiTao();
        }        

        private void BtnExit_Click(object sender, EventArgs e) //Tắt
        {
            timerPExit.Start();
        }
        private void btnTaoLich_Click(object sender, EventArgs e)
        {
            UC_TaoLich tl = new UC_TaoLich();
            ThemUC(tl);
            LuotPanel(btnTaoLich);
        }

        private void BbtnThongTin_Click(object sender, EventArgs e)
        {
            UC_ThongTin tt = new UC_ThongTin();
            ThemUC(tt);
            LuotPanel(btnThongTin);
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            UC_GiangVien gv = new UC_GiangVien();
            ThemUC(gv);
            LuotPanel(btnGiangVien);
        }

        private void btnSapLich_Click(object sender, EventArgs e)
        {
            UC_SapLich sl = new UC_SapLich();
            ThemUC(sl);
            LuotPanel(btnSapLich);
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            UC_Lich l = new UC_Lich();
            ThemUC(l);
            LuotPanel(btnLichThi);
        }

        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            UC_QuanLi ql = new UC_QuanLi();
            ThemUC(ql);
            LuotPanel(btnQuanLi);
        }

        private void TimerTime_Tick(object sender, EventArgs e) //Đồng hồ nè
        {
            DateTime dt = DateTime.Now;
            lblDay.Text = dt.ToString("dd/MM/yyyy");
            lblTime.Text = dt.ToString("HH:mm:ss");
        }


        private void timerPExit_Tick(object sender, EventArgs e)
        {
            if (closed)
            {
                pnlExit.Width = pnlExit.Width + 10;
                if (pnlExit.Width >= 272)
                {
                    timerPExit.Stop();
                    closed = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlExit.Width = pnlExit.Width - 10;
                if (pnlExit.Width <= 1)
                {
                    timerPExit.Stop();
                    closed = true;
                    this.Refresh();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.user = null;
            Login.matKhauNow = null;
            Login.LoaiTaiKhoan = null;
        }
    }
}
