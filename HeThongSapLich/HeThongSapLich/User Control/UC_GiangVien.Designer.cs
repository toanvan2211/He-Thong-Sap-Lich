namespace HeThongSapLich.User_Control
{
    partial class UC_GiangVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlQuyenAdmin = new System.Windows.Forms.Panel();
            this.lbThoiGianKhoa = new System.Windows.Forms.Label();
            this.btnCapQuyen = new System.Windows.Forms.Button();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.btnCapNhatThongTin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemGiangVien = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timerKhoa = new System.Windows.Forms.Timer(this.components);
            this.btnXoaGiangVien = new System.Windows.Forms.Button();
            this.maGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlQuyenAdmin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách giảng viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvGiangVien);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(28, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 580);
            this.panel1.TabIndex = 3;
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiangVien,
            this.ten,
            this.Khoa,
            this.gioiTinh,
            this.gmail});
            this.dgvGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 0);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.ReadOnly = true;
            this.dgvGiangVien.Size = new System.Drawing.Size(876, 580);
            this.dgvGiangVien.TabIndex = 0;
            this.dgvGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(232)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(924, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoaGiangVien);
            this.panel2.Controls.Add(this.pnlQuyenAdmin);
            this.panel2.Controls.Add(this.cbKhoa);
            this.panel2.Controls.Add(this.cbGioiTinh);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbMail);
            this.panel2.Controls.Add(this.btnCapNhatThongTin);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbMaGV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbTen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(931, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 530);
            this.panel2.TabIndex = 1;
            // 
            // pnlQuyenAdmin
            // 
            this.pnlQuyenAdmin.Controls.Add(this.lbThoiGianKhoa);
            this.pnlQuyenAdmin.Controls.Add(this.btnCapQuyen);
            this.pnlQuyenAdmin.Controls.Add(this.tbMatKhau);
            this.pnlQuyenAdmin.Controls.Add(this.label5);
            this.pnlQuyenAdmin.Controls.Add(this.label1);
            this.pnlQuyenAdmin.Enabled = false;
            this.pnlQuyenAdmin.Location = new System.Drawing.Point(3, 301);
            this.pnlQuyenAdmin.Name = "pnlQuyenAdmin";
            this.pnlQuyenAdmin.Size = new System.Drawing.Size(447, 206);
            this.pnlQuyenAdmin.TabIndex = 2;
            this.pnlQuyenAdmin.Visible = false;
            // 
            // lbThoiGianKhoa
            // 
            this.lbThoiGianKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThoiGianKhoa.AutoSize = true;
            this.lbThoiGianKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianKhoa.ForeColor = System.Drawing.Color.Yellow;
            this.lbThoiGianKhoa.Location = new System.Drawing.Point(342, 150);
            this.lbThoiGianKhoa.Name = "lbThoiGianKhoa";
            this.lbThoiGianKhoa.Size = new System.Drawing.Size(0, 21);
            this.lbThoiGianKhoa.TabIndex = 21;
            this.lbThoiGianKhoa.Visible = false;
            // 
            // btnCapQuyen
            // 
            this.btnCapQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(91)))), ((int)(((byte)(85)))));
            this.btnCapQuyen.Enabled = false;
            this.btnCapQuyen.FlatAppearance.BorderSize = 0;
            this.btnCapQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapQuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapQuyen.ForeColor = System.Drawing.Color.Black;
            this.btnCapQuyen.Location = new System.Drawing.Point(254, 78);
            this.btnCapQuyen.Name = "btnCapQuyen";
            this.btnCapQuyen.Size = new System.Drawing.Size(184, 51);
            this.btnCapQuyen.TabIndex = 2;
            this.btnCapQuyen.Text = "Cấp quyền admin";
            this.btnCapQuyen.UseVisualStyleBackColor = false;
            this.btnCapQuyen.Click += new System.EventHandler(this.btnCapQuyenAdmin_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Location = new System.Drawing.Point(169, 30);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(259, 29);
            this.tbMatKhau.TabIndex = 1;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(111, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Chức năng tạm khóa trong: ";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập mật khẩu:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Enabled = false;
            this.cbKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin"});
            this.cbKhoa.Location = new System.Drawing.Point(118, 114);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(269, 29);
            this.cbKhoa.TabIndex = 3;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Enabled = false;
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(118, 158);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(127, 29);
            this.cbGioiTinh.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(59, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Khoa:";
            // 
            // tbMail
            // 
            this.tbMail.Enabled = false;
            this.tbMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(118, 204);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(323, 29);
            this.tbMail.TabIndex = 5;
            // 
            // btnCapNhatThongTin
            // 
            this.btnCapNhatThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(115)))));
            this.btnCapNhatThongTin.Enabled = false;
            this.btnCapNhatThongTin.FlatAppearance.BorderSize = 0;
            this.btnCapNhatThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatThongTin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThongTin.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatThongTin.Location = new System.Drawing.Point(130, 244);
            this.btnCapNhatThongTin.Name = "btnCapNhatThongTin";
            this.btnCapNhatThongTin.Size = new System.Drawing.Size(145, 36);
            this.btnCapNhatThongTin.TabIndex = 6;
            this.btnCapNhatThongTin.Text = "Cập nhật thông tin";
            this.btnCapNhatThongTin.UseVisualStyleBackColor = false;
            this.btnCapNhatThongTin.Visible = false;
            this.btnCapNhatThongTin.Click += new System.EventHandler(this.btnCapNhatThongTin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(64, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giới tính:";
            // 
            // tbMaGV
            // 
            this.tbMaGV.Enabled = false;
            this.tbMaGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaGV.Location = new System.Drawing.Point(118, 24);
            this.tbMaGV.Name = "tbMaGV";
            this.tbMaGV.ReadOnly = true;
            this.tbMaGV.Size = new System.Drawing.Size(157, 29);
            this.tbMaGV.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã GV:";
            // 
            // tbTen
            // 
            this.tbTen.Enabled = false;
            this.tbTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(118, 70);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(323, 29);
            this.tbTen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.btnThemGiangVien);
            this.panel4.Controls.Add(this.btnChangeInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1387, 71);
            this.panel4.TabIndex = 3;
            // 
            // btnThemGiangVien
            // 
            this.btnThemGiangVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnThemGiangVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGiangVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThemGiangVien.Enabled = false;
            this.btnThemGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGiangVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGiangVien.ForeColor = System.Drawing.Color.White;
            this.btnThemGiangVien.Location = new System.Drawing.Point(202, 0);
            this.btnThemGiangVien.Name = "btnThemGiangVien";
            this.btnThemGiangVien.Size = new System.Drawing.Size(202, 71);
            this.btnThemGiangVien.TabIndex = 2;
            this.btnThemGiangVien.Text = "Thêm giảng viên";
            this.btnThemGiangVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemGiangVien.UseVisualStyleBackColor = false;
            this.btnThemGiangVien.Visible = false;
            this.btnThemGiangVien.Click += new System.EventHandler(this.btnThemGiangVien_Click_1);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeInfo.ForeColor = System.Drawing.Color.White;
            this.btnChangeInfo.Location = new System.Drawing.Point(0, 0);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(202, 71);
            this.btnChangeInfo.TabIndex = 1;
            this.btnChangeInfo.Text = "Chỉnh sửa thông tin";
            this.btnChangeInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeInfo.UseVisualStyleBackColor = false;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1397, 10);
            this.panel3.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 767);
            this.panel5.TabIndex = 24;
            // 
            // timerKhoa
            // 
            this.timerKhoa.Interval = 1000;
            this.timerKhoa.Tick += new System.EventHandler(this.timerKhoa_Tick);
            // 
            // btnXoaGiangVien
            // 
            this.btnXoaGiangVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(3)))));
            this.btnXoaGiangVien.Enabled = false;
            this.btnXoaGiangVien.FlatAppearance.BorderSize = 0;
            this.btnXoaGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGiangVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGiangVien.ForeColor = System.Drawing.Color.Black;
            this.btnXoaGiangVien.Location = new System.Drawing.Point(286, 244);
            this.btnXoaGiangVien.Name = "btnXoaGiangVien";
            this.btnXoaGiangVien.Size = new System.Drawing.Size(145, 36);
            this.btnXoaGiangVien.TabIndex = 19;
            this.btnXoaGiangVien.Text = "Xóa giảng viên";
            this.btnXoaGiangVien.UseVisualStyleBackColor = false;
            this.btnXoaGiangVien.Visible = false;
            this.btnXoaGiangVien.Click += new System.EventHandler(this.btnXoaGiangVien_Click);
            // 
            // maGiangVien
            // 
            this.maGiangVien.DataPropertyName = "maGiangVien";
            this.maGiangVien.FillWeight = 99.74749F;
            this.maGiangVien.HeaderText = "Mã Giảng Viên";
            this.maGiangVien.Name = "maGiangVien";
            this.maGiangVien.ReadOnly = true;
            this.maGiangVien.Width = 150;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.FillWeight = 65.48567F;
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 250;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "khoa";
            this.Khoa.FillWeight = 65.48567F;
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 200;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.FillWeight = 100.7498F;
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            this.gioiTinh.Width = 80;
            // 
            // gmail
            // 
            this.gmail.DataPropertyName = "mail";
            this.gmail.FillWeight = 65.48567F;
            this.gmail.HeaderText = "Mail";
            this.gmail.Name = "gmail";
            this.gmail.ReadOnly = true;
            this.gmail.Width = 200;
            // 
            // UC_GiangVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_GiangVien";
            this.Size = new System.Drawing.Size(1397, 777);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlQuyenAdmin.ResumeLayout(false);
            this.pnlQuyenAdmin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnThemGiangVien;
        private System.Windows.Forms.Button btnCapNhatThongTin;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Panel pnlQuyenAdmin;
        private System.Windows.Forms.Button btnCapQuyen;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerKhoa;
        private System.Windows.Forms.Label lbThoiGianKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
    }
}
