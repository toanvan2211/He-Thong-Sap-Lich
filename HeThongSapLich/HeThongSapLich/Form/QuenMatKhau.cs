using HeThongSapLich.Class;
using HeThongSapLich.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongSapLich
{
    public partial class QuenMatKhau : Form
    {
        int tgMaXacNhan = 300;
        string maXacNhan, gmail;
        bool guiThanhCong = false;

        public QuenMatKhau()
        {
            InitializeComponent();
        }

        void GuiMail(string maXacNhan, string nguoiNhan, string tenGiangVien)
        {
            string body = "Chào " + tenGiangVien + ",\n" + "\nĐây là mã xác nhận được gửi từ hệ thống sắp lịch tự động." +
                " \n Mã xác nhận của bạn là: " + maXacNhan + "." +
                " \n Mã này có hiệu lực trong vòng 5 phút.";

            string tieuDe = "Mã xác nhận lấy lại mật khẩu";

            Thread th = new Thread(() =>
            {
                try
                {
                    SendEmail.Instance.GuiMail(tieuDe, body, nguoiNhan);
                    guiThanhCong = true;
                    
                }
                catch (Exception a)
                {
                    MessageBox.Show("Xảy ra lỗi khi gửi mail.\nLỗi: " + a.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            th.Start();
            Thread.Sleep(8000);
            if (guiThanhCong)
            {
                timer1.Start();
            }
        }

        string TaoMaXacNhan()
        {
            int doDai = 5, ch2;
            Random rd = new Random();
            StringBuilder maXacNhan = new StringBuilder();
            char ch, ch1;

            for (int i = 0; i < doDai; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rd.NextDouble() + 65)));
                ch1 = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rd.NextDouble() + 65)));
                ch2 = Convert.ToInt32(rd.Next(0, 9));

                string[] listrnd = { ch.ToString(), ch1.ToString().ToLower(), ch2.ToString() };

                maXacNhan.Append(listrnd[rd.Next(0, 3)]);
            }


            return maXacNhan.ToString();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuiMaXacNhan_Click(object sender, EventArgs e)
        {
            lbThongBao.ResetText();
            if (!string.IsNullOrEmpty(tbGmail.Text))
            {
                DataTable dt = GiangVienDAO.Instance.LayGmail(tbGmail.Text);
                if (dt.Rows.Count != 0)
                {
                    gmail = dt.Rows[0]["mail"].ToString();
                    string tenGiangVien = dt.Rows[0]["ten"].ToString();

                    maXacNhan = TaoMaXacNhan();
                    GuiMail(maXacNhan, gmail, tenGiangVien);
                }
                else
                {
                    MessageBox.Show("Mail này chưa được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int phut, giay;

            tgMaXacNhan--;
            phut = tgMaXacNhan / 60;
            giay = tgMaXacNhan % 60;

            lbThongBao.Text = "Thời gian còn: " + phut + "p" + giay + "s";
            
            if (tgMaXacNhan == 0)
            {
                timer1.Stop();
                tgMaXacNhan = 300;
                lbThongBao.ResetText();
                maXacNhan = null;
                gmail = null;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            lbThongBao.ResetText();
            if (tbMaXacNhan.Text == maXacNhan && gmail != null)
            {
                string taiKhoan = TaiKhoanDAO.Instance.LayTenTaiKhoan1(gmail);

                TaiKhoanDAO.Instance.DoiMatKhau(taiKhoan, "1");
                MessageBox.Show("Mật khẩu mới của bạn là '1'. Vui lòng đăng nhập và đổi mật khẩu.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                timer1.Stop();
                lbThongBao.ResetText();
                maXacNhan = null;
                gmail = null;
            }
            else
            {
                lbThongBao.Text = "Sai mã xác nhận";
            }
        }
    }
}
