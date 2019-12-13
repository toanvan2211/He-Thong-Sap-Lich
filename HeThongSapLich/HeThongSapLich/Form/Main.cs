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

            UC_ThongTin thongTin = new UC_ThongTin();
            UC_GiangVien giangVien = new UC_GiangVien();
            UC_SapLich sapLich = new UC_SapLich();
            UC_TaoLich taoLich = new UC_TaoLich();
            UC_Lich lich = new UC_Lich();
            ThemUC(thongTin);
            ThemUC(giangVien);
            ThemUC(sapLich);
            ThemUC(taoLich);
            ThemUC(lich);

            pnlControls.Controls["UC_ThongTin"].BringToFront();
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
            pnlControls.Controls["UC_TaoLich"].BringToFront();
            LuotPanel(btnTaoLich);
        }

        private void BbtnThongTin_Click(object sender, EventArgs e)
        {
            pnlControls.Controls["UC_ThongTin"].BringToFront();
            LuotPanel(btnThongTin);
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            pnlControls.Controls["UC_GiangVien"].BringToFront();
            LuotPanel(btnGiangVien);
        }

        private void btnSapLich_Click(object sender, EventArgs e)
        {
            pnlControls.Controls["UC_SapLich"].BringToFront();
            LuotPanel(btnSapLich);
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            pnlControls.Controls["UC_Lich"].BringToFront();
            LuotPanel(btnLichThi);
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
