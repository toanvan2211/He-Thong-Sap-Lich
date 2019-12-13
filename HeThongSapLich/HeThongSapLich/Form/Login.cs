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

namespace HeThongSapLich
{
    public partial class Login : Form
    {
        public static string user, LoaiTaiKhoan, matKhauNow;

        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string TaiKhoan = tbTaiKhoan.Text;
            string MatKhau = tbMatKhau.Text;

            if (KiemTra(TaiKhoan, MatKhau))
            {
                user = TaiKhoan;
                matKhauNow = MatKhau;
                LoaiTaiKhoan = TaiKhoanDAO.Instance.LayLoaiTaiKhoan(TaiKhoan);
                using (Main m = new Main())
                {
                    this.Hide();
                    m.ShowDialog();
                    try
                    {
                        this.Show();
                    }
                    catch
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                lbThongBao.Text = "Tài khoản hoặc mật khẩu có vẻ không đúng!";
            }
        }

        private bool KiemTra(string TaiKhoan, string MatKhau)
        {
            return TaiKhoanDAO.Instance.KiemTra(TaiKhoan, MatKhau);
        }

        private void TbTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            lbThongBao.Text = "";
        }

        private void TbMatKhau_MouseDown(object sender, MouseEventArgs e)
        {
            lbThongBao.Text = "";
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "DataBase files (*.mdf) | *.mdf|All file (*.*)|*.*";
            opf.FilterIndex = 1;
            opf.RestoreDirectory = true;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                DataProvider.DirectoryFileDB = opf.FileName;
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
