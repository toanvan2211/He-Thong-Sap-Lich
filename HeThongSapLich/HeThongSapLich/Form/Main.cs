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
        bool Close;
        public static string maGV;

        #region Hàm
        private void ThemUC(Control uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlControls.Controls.Clear();
            pnlControls.Controls.Add(uc);
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
            Close = true;
            timerTime.Start();

            UC_ThongTin uctt = new UC_ThongTin();
            ThemUC(uctt);
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

        private void BbtnThongTin_Click(object sender, EventArgs e)
        {
            UC_ThongTin uctt = new UC_ThongTin();
            ThemUC(uctt);
            LuotPanel(btnThongTin);
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            UC_GiangVien ucgv = new UC_GiangVien();
            ThemUC(ucgv);
            LuotPanel(btnGiangVien);
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            UC_LichThi uclt = new UC_LichThi();
            ThemUC(uclt);
            LuotPanel(btnLichThi);
        }

        private void Timer1_Tick(object sender, EventArgs e)  //Code để thu nhỏ menu cho cái btn ở dưới nè
        {
            if (isColapsed)
            {
                pnlLeft.Width = pnlLeft.Width + 10;
                if (pnlLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isColapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLeft.Width = pnlLeft.Width - 10;
                if (pnlLeft.Width <= 70)
                {
                    timer1.Stop();
                    isColapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnThuNho_Click(object sender, EventArgs e)  //Thu nhỏ thanh menu nè
        {
            timer1.Start();
        }

        private void TimerTime_Tick(object sender, EventArgs e) //Đồng hồ nè
        {
            DateTime dt = DateTime.Now;
            lblDay.Text = dt.ToString("dd/MM/yyyy");
            lblTime.Text = dt.ToString("HH:mm:ss");
        }


        private void timerPExit_Tick(object sender, EventArgs e)
        {
            if (Close)
            {
                pnlExit.Width = pnlExit.Width + 10;
                if (pnlExit.Width >= 272)
                {
                    timerPExit.Stop();
                    Close = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlExit.Width = pnlExit.Width - 10;
                if (pnlExit.Width <= 1)
                {
                    timerPExit.Stop();
                    Close = true;
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
            Login.user = "";
        }
    }
}
