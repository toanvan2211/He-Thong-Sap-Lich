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
using HeThongSapLich.DTO;

namespace HeThongSapLich.User_Control
{
    public partial class UC_SapLich : UserControl
    {
        public string maHocKy;
        List<HocKy> listHocKy = new List<HocKy>();
        public UC_SapLich()
        {
            InitializeComponent();

            PhanQuyen();
            LoadLichThi();
            LoadDSHocKy();
            LoadComboBox();
            cbKieuSap.SelectedIndex = 0;
        }

        #region Phương Thức

        void PhanQuyen()
        {
            if (Login.LoaiTaiKhoan == "admin")
            {
                btnSepGiangVienGac.Enabled = true;
            }
        }

        void SapXepDonCuc()
        {
            byte soBuoi = Convert.ToByte(nupSoBuoiGac.Value);
            Random rd = new Random();
            DataTable data = LichThiDAO.Instance.LayDSLichThiChuaFormat(maHocKy);
            List<LichThi> listLichThi = new List<LichThi>();
            List<LichThi> listLichTrong = new List<LichThi>();
            foreach (DataRow item in data.Rows)
            {
                LichThi lt = new LichThi(item);
                listLichThi.Add(lt);
                if (string.IsNullOrEmpty(lt.MaGV))
                {
                    listLichTrong.Add(lt);
                }
            }

            List<GiangVien> giangv = new List<GiangVien>();
            DataTable dtgv = GiangVienDAO.Instance.LayDSGiangVien();
            foreach (DataRow item in dtgv.Rows)
            {
                GiangVien gv = new GiangVien(item);
                giangv.Add(gv);
            }

            DataTable dataGacThi = GacThiDAO.Instance.LayDSGacThi(maHocKy);
            List<GacThi> listGacThi = new List<GacThi>();
            foreach (DataRow item in dataGacThi.Rows)
            {
                GacThi gt = new GacThi(item);
                listGacThi.Add(gt);
            }

            //Kiểm tra xem ai chưa có lịch gác thì tạo lịch gác
            if (giangv.Count > listGacThi.Count)
            {
                for (int i = 0; i < giangv.Count; i++)
                {
                    for (int j = 0; j < listGacThi.Count; j++)
                    {
                        if (giangv[i].MaGV == listGacThi[j].MaGiangVien)
                        {
                            giangv.RemoveAt(i);
                            listGacThi.RemoveAt(j);
                            i--;
                            j--;
                            break;
                        }
                    }
                }
                if (giangv.Count > 0)
                {
                    for (int i = 0; i < giangv.Count; i++)
                    {
                        GacThiDAO.Instance.TaoPhieuGac(giangv[i].MaGV, maHocKy);
                    }
                }
                dataGacThi = GacThiDAO.Instance.LayDSGacThi(maHocKy);
                listGacThi.Clear();
                foreach (DataRow item in dataGacThi.Rows)
                {
                    GacThi gt = new GacThi(item);
                    listGacThi.Add(gt);
                }

            }
            //----------------------------------------

            for (int j = 0; j < listGacThi.Count; j++)
            {
                if (listLichTrong.Count > 0)
                {
                    for (int o = Math.Abs(soBuoi - listGacThi[j].SoBuoiGac); o != 0; o--)  //Don vao 1 giang vien gac du so buoi roi moi qua giang vien khac
                    {
                        if (listGacThi[j].SoBuoiGac < soBuoi)
                        {
                            if (listLichTrong.Count > 0)
                            {
                                int index = 0;
                                int x = rd.Next(0, listLichTrong.Count - 1); /// / //
                                string maLichThi = listLichTrong[x].MaLichThi;
                                List<LichThi> listLichThiTam = new List<LichThi>();
                                for (int k = 0; k < listLichThi.Count; k++)
                                {
                                    if (listLichThi[k].MaGV == listGacThi[j].MaGiangVien)
                                    {
                                        listLichThiTam.Add(listLichThi[k]);
                                    }
                                }

                                for (int p = 0; p < listLichThi.Count; p++)
                                {
                                    if (listLichThi[p].MaLichThi == maLichThi)
                                    {
                                        index = p;
                                    }
                                }

                                if (listLichThiTam.Count > 0)
                                {
                                    int count = 0;
                                    for (int i = 0; i < listLichThiTam.Count; i++)
                                    {
                                        if (listLichThi[index].CaThi != listLichThiTam[i].CaThi || listLichThi[index].NgayThi != listLichThiTam[i].NgayThi)
                                        {
                                            if (i == listLichThiTam.Count - 1)
                                            {
                                                if (count == 0)
                                                {
                                                    listLichThi[index].MaGV = listGacThi[j].MaGiangVien;
                                                    listGacThi[j].SoBuoiGac += 1;
                                                    listLichTrong.RemoveAt(x);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            count++;
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(listLichThi[index].MaGV))
                                    {
                                        listLichThi[index].MaGV = listGacThi[j].MaGiangVien;
                                        listGacThi[j].SoBuoiGac += 1;
                                        listLichTrong.RemoveAt(x);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < listLichThi.Count; i++)
            {
                if (!string.IsNullOrEmpty(listLichThi[i].MaGV) && !string.IsNullOrEmpty(listLichThi[i].MaLichThi))
                {
                    LichThiDAO.Instance.CapNhatGiangVienGacThi(listLichThi[i].MaGV, listLichThi[i].MaLichThi);
                }
            }
            for (int i = 0; i < listGacThi.Count; i++)
            {
                if (!string.IsNullOrEmpty(listGacThi[i].MaGiangVien))
                {
                    GacThiDAO.Instance.CapNhatSoBuoiGac(listGacThi[i].MaGiangVien, listGacThi[i].SoBuoiGac);
                }
            }
        }

        void SapXepChiaDeu()
        {
            byte soBuoi = Convert.ToByte(nupSoBuoiGac.Value);
            Random rd = new Random();
            DataTable data = LichThiDAO.Instance.LayDSLichThiChuaFormat(maHocKy);
            List<LichThi> listLichThi = new List<LichThi>();
            List<LichThi> listLichTrong = new List<LichThi>();
            foreach (DataRow item in data.Rows)
            {
                LichThi lt = new LichThi(item);
                listLichThi.Add(lt);
                if (string.IsNullOrEmpty(lt.MaGV))
                {
                    listLichTrong.Add(lt);
                }
            }

            List<GiangVien> giangv = new List<GiangVien>();
            DataTable dtgv = GiangVienDAO.Instance.LayDSGiangVien();
            foreach (DataRow item in dtgv.Rows)
            {
                GiangVien gv = new GiangVien(item);
                giangv.Add(gv);
            }

            DataTable dataGacThi = GacThiDAO.Instance.LayDSGacThi(maHocKy);
            List<GacThi> listGacThi = new List<GacThi>();
            foreach (DataRow item in dataGacThi.Rows)
            {
                GacThi gt = new GacThi(item);
                listGacThi.Add(gt);
            }
            //Kiểm tra xem ai chưa có lịch gác thì tạo lịch gác
            if (giangv.Count > listGacThi.Count)
            {
                for (int  i = 0;  i < giangv.Count;  i++)
                {
                    for (int j = 0; j < listGacThi.Count; j++)
                    {
                        if (giangv[i].MaGV == listGacThi[j].MaGiangVien)
                        {
                            giangv.RemoveAt(i);
                            listGacThi.RemoveAt(j);
                            i--;
                            j--;
                            break;
                        }
                    }
                }
                if (giangv.Count > 0)
                {
                    for (int i = 0; i < giangv.Count; i++)
                    {
                        GacThiDAO.Instance.TaoPhieuGac(giangv[i].MaGV, maHocKy);
                    }
                }
                dataGacThi = GacThiDAO.Instance.LayDSGacThi(maHocKy);
                listGacThi.Clear();
                foreach (DataRow item in dataGacThi.Rows)
                {
                    GacThi gt = new GacThi(item);
                    listGacThi.Add(gt);
                }

            }
            //----------------------------------------
            int index = 0;
            for (int i = 0; i < listLichTrong.Count; i++)
            {
                for (int j = 0; j < listGacThi.Count; j++)
                {
                    if (listLichTrong.Count > 0)
                    {
                        if (listGacThi[j].SoBuoiGac < soBuoi)
                        {
                            int x = rd.Next(0, listLichTrong.Count - 1);
                            List<LichThi> listLichThiTam = new List<LichThi>();
                            for (int k = 0; k < listLichThi.Count; k++)
                            {
                                if (listGacThi[j].MaGiangVien == listLichThi[k].MaGV)
                                {
                                    listLichThiTam.Add(listLichThi[k]);
                                }
                            }

                            for (int o = 0; o < listLichThi.Count; o++)
                            {
                                if (listLichThi[o].MaLichThi == listLichTrong[x].MaLichThi)
                                {
                                    index = o;
                                }
                            }

                            if (listLichThiTam.Count > 0)
                            {
                                int count = 0;
                                for (int k = 0; k < listLichThiTam.Count; k++)
                                {
                                    if (listLichTrong[x].NgayThi != listLichThiTam[k].NgayThi || listLichTrong[x].CaThi != listLichThiTam[k].CaThi)
                                    {
                                        if (k == listLichThiTam.Count - 1)
                                        {
                                            if (count == 0)
                                            {
                                                listLichThi[index].MaGV = listGacThi[j].MaGiangVien;
                                                listGacThi[j].SoBuoiGac++;
                                                listLichTrong.RemoveAt(x);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        count++;
                                    }
                                }
                            }
                            else
                            {
                                listLichThi[index].MaGV = listGacThi[j].MaGiangVien;
                                listGacThi[j].SoBuoiGac++;
                                listLichTrong.RemoveAt(x);
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < listLichThi.Count; i++)
            {
                if (!string.IsNullOrEmpty(listLichThi[i].MaGV) && !string.IsNullOrEmpty(listLichThi[i].MaLichThi))
                {
                    LichThiDAO.Instance.CapNhatGiangVienGacThi(listLichThi[i].MaGV, listLichThi[i].MaLichThi);
                }
            }
            for (int i = 0; i < listGacThi.Count; i++)
            {
                if (!string.IsNullOrEmpty(listGacThi[i].MaGiangVien))
                {
                    GacThiDAO.Instance.CapNhatSoBuoiGac(listGacThi[i].MaGiangVien, listGacThi[i].SoBuoiGac);
                }
            }
        }

        void SapXepTuDong() //auto sắp
        {
            if (ckbTatCa.Checked == true) //sap tat ca giang vien
            {
                XepTatCaGiangVien();
            }
            else //sap tung giang vien
            {
                XepTheoMaGV();
            }
        }

        void XepTatCaGiangVien()
        {
            if (cbKieuSap.SelectedIndex == 0) // sắp theo kiểu chia đều
            {
                SapXepChiaDeu();
            }
            else
            {
                SapXepDonCuc();
            }

        } 

        void XepTheoMaGV()
        {
            byte soBuoiGac = Convert.ToByte(nupSoBuoiGac.Value);
            string maGV = cbMaGV.Text;
            DataRow row = GacThiDAO.Instance.LayThongTin(maGV, maHocKy);
            if (row == null)
            {
                GacThiDAO.Instance.TaoPhieuGac(maGV, maHocKy);
                row = GacThiDAO.Instance.LayThongTin(maGV, maHocKy);
            }

            GacThi gt = new GacThi(row);

            if (gt.SoBuoiGac < soBuoiGac)
            {
                Random rd = new Random();
                DataTable dt = LichThiDAO.Instance.LayLichThiKhongCoGiangVienGac();
                List<LichThi> listLichThi = new List<LichThi>();
                foreach (DataRow item in dt.Rows)
                {
                    LichThi lt = new LichThi(item);
                    listLichThi.Add(lt);
                }

                for (int i = 0; i < listLichThi.Count; i++)
                {
                    listLichThi.Clear();
                    dt = LichThiDAO.Instance.LayLichThiKhongCoGiangVienGac();
                    //listLichThi = new List<LichThi>();
                    foreach (DataRow item in dt.Rows)
                    {
                        LichThi lt = new LichThi(item);
                        listLichThi.Add(lt);
                    }

                    row = GacThiDAO.Instance.LayThongTin(maGV, maHocKy);
                    gt = new GacThi(row);
                    int x = rd.Next(0, listLichThi.Count - 1);

                    if(gt.SoBuoiGac < soBuoiGac)
                    {
                        dt = LichThiDAO.Instance.LayLichThiTheoMaGV(maGV);
                        List<LichThi> tempLichThi = new List<LichThi>();
                        foreach (DataRow item in dt.Rows)
                        {
                            LichThi lt = new LichThi(item);
                            tempLichThi.Add(lt);
                        }

                        if (tempLichThi.Count == 0)
                        {
                            LichThiDAO.Instance.CapNhatGiangVienGacThi(gt.MaGiangVien, listLichThi[x].MaLichThi);
                            GacThiDAO.Instance.CapNhatSoBuoiGac(gt.MaGiangVien, ++gt.SoBuoiGac);
                        }
                        else
                        {
                            for (int j = 0; j < tempLichThi.Count; j++)
                            {
                                if (listLichThi[x].CaThi != tempLichThi[j].CaThi || listLichThi[x].NgayThi != tempLichThi[j].NgayThi)
                                {
                                    if (j == tempLichThi.Count - 1)
                                    {
                                        LichThiDAO.Instance.CapNhatGiangVienGacThi(gt.MaGiangVien, listLichThi[x].MaLichThi);
                                        GacThiDAO.Instance.CapNhatSoBuoiGac(gt.MaGiangVien, ++gt.SoBuoiGac);
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        void DangKyGac()
        {
            DataRow rowLichThi = LichThiDAO.Instance.LayLichThiTheoMaChuaFormat(cbMaLichThi.Text).Rows[0];
            LichThi lt = new LichThi(rowLichThi);
            if (string.IsNullOrEmpty(lt.MaGV))
            {
                List<LichThi> listLichThiTam = new List<LichThi>();
                DataTable data = LichThiDAO.Instance.LayLichThiTheoMaGV(Main.maGV);
                foreach (DataRow item in data.Rows)
                {
                    LichThi l = new LichThi(item);
                    listLichThiTam.Add(l);
                }
                if(listLichThiTam.Count > 0)
                {
                    for (int i = 0; i < listLichThiTam.Count; i++)
                    {
                        if (lt.CaThi != listLichThiTam[i].CaThi || lt.NgayThi != listLichThiTam[i].NgayThi)
                        {
                            if (i == listLichThiTam.Count - 1)
                            {
                                DataRow row = GacThiDAO.Instance.LayThongTin(Main.maGV, maHocKy);

                                if (row == null)
                                {
                                    GacThiDAO.Instance.TaoPhieuGac(Main.maGV, maHocKy);
                                    row = GacThiDAO.Instance.LayThongTin(Main.maGV, maHocKy);
                                }

                                GacThi gt = new GacThi(row);

                                LichThiDAO.Instance.CapNhatGiangVienGacThi(Main.maGV, lt.MaLichThi);
                                GacThiDAO.Instance.CapNhatSoBuoiGac(Main.maGV, ++gt.SoBuoiGac);
                                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn bị trùng lịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
                else
                {
                    DataRow row = GacThiDAO.Instance.LayThongTin(Main.maGV, maHocKy);

                    if (row == null)
                    {
                        GacThiDAO.Instance.TaoPhieuGac(Main.maGV, maHocKy);
                        row = GacThiDAO.Instance.LayThongTin(Main.maGV, maHocKy);
                    }

                    GacThi gt = new GacThi(row);

                    LichThiDAO.Instance.CapNhatGiangVienGacThi(Main.maGV, lt.MaLichThi);
                    GacThiDAO.Instance.CapNhatSoBuoiGac(Main.maGV, ++gt.SoBuoiGac);
                    MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(lt.MaGV == Main.maGV)
            {
                MessageBox.Show("Bạn đã gác lịch này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lịch thi đã có người gác, vui lòng chọn lịch khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Xoa()
        {
            cbMaLichThi.DataSource = null;
            cbCaThi.DataSource = null;
            cbMaGV.DataSource = null;
            cbNgay.DataSource = null;

            LoadComboBox();
        }

        void KhoaCBMaGV()
        {
            if (ckbTatCa.Checked)
            {
                cbMaGV.Enabled = false;
            }
            else
            {
                cbMaGV.Enabled = true;
            }

        } //Tat mo cai combobox magv

        bool KiemTraTrungLich(DataTable lichThi) //Kiểm tra xem có trùng ca thi không, áp dụng cho gác 2 buổi trở lên
        {
            bool KetQua = false;
            return KetQua;
        }

        #endregion

        void LoadDSHocKy()
        {
            DataTable dt = HocKyDAO.Instance.LayDSHocKy();
            foreach (DataRow item in dt.Rows)
            {
                HocKy hk = new HocKy(item);
                listHocKy.Add(hk);
            }
            cbHocKy.DataSource = listHocKy;
            cbHocKy.DisplayMember = "tenHocKy";
            maHocKy = listHocKy[0].MaHocKy;
        }

        void LoadLichThi()
        {
            dgvLichThi.DataSource = LichThiDAO.Instance.LayDSLichThi(maHocKy);
        }

        void LoadComboBox()
        {
            DataTable dt = new DataTable();
            dt = LichThiDAO.Instance.LayDSLichThi(maHocKy);

            cbMaLichThi.DataSource = dt;
            cbNgay.DataSource = dt;
            cbCaThi.DataSource = dt;

            cbMaLichThi.DisplayMember = "maLichThi";
            cbNgay.DisplayMember = "ngayThi";
            cbCaThi.DisplayMember = "caThi";

            dt = GiangVienDAO.Instance.LayDSGiangVien();
            cbMaGV.DataSource = dt;
            cbMaGV.DisplayMember = "maGiangVien";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Xoa();
            LoadLichThi();
            LoadComboBox();
        }

        private void cbLHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string maLichThi = cbMaLichThi.Text;
            dt = LichThiDAO.Instance.LayLichThiTheoMa(maLichThi);

            cbCaThi.DataSource = null;
            cbNgay.DataSource = null;

            cbNgay.DataSource = dt;
            cbCaThi.DataSource = dt;

            cbNgay.DisplayMember = "ngayThi";
            cbCaThi.DisplayMember = "caThi";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LichThi lt = new LichThi(LichThiDAO.Instance.LayLichThiTheoMaChuaFormat(cbMaLichThi.Text).Rows[0]);
            if (Main.maGV == lt.MaGV)
            {
                lt.MaGV = null;
                LichThiDAO.Instance.HuyDangKyGac(lt.MaLichThi);
            }
            else
            {
                MessageBox.Show("Bạn không gác lịch này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadLichThi();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyGac();

            LoadLichThi();
        }

        private void btnSepGiangVienGac_Click(object sender, EventArgs e)
        {
            SapXepTuDong();

            LoadLichThi();
        }

        private void ckbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            KhoaCBMaGV();

            if(ckbTatCa.Checked == true)
            {
                cbKieuSap.Enabled = true;
            }
            else
            {
                cbKieuSap.Enabled = false;
            }
        }

        private void btnResetLich_Click(object sender, EventArgs e)
        {
            LichThiDAO.Instance.ResetLichThi();
            GacThiDAO.Instance.LamMoi(maHocKy);
            
            LoadLichThi();
        }

        private void btnSoBuoiGac_Click(object sender, EventArgs e)
        {
            using (frPhieuGac sbg = new frPhieuGac())
            {
                sbg.ShowDialog();
            }
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            maHocKy = listHocKy[cbHocKy.SelectedIndex].MaHocKy;
            LoadComboBox();
            LoadLichThi();
        }

        private void dgvLichThi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvLichThi.CurrentRow.Selected = true;
                cbMaLichThi.Text = dgvLichThi.Rows[e.RowIndex].Cells["maLichThi"].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
