namespace HeThongSapLich.User_Control
{
    partial class UC_SapLich
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSoBuoiGac = new System.Windows.Forms.Button();
            this.btnResetLich = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbKieuSap = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nupSoBuoiGac = new System.Windows.Forms.NumericUpDown();
            this.ckbTatCa = new System.Windows.Forms.CheckBox();
            this.cbMaGV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSepGiangVienGac = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cbNgay = new System.Windows.Forms.ComboBox();
            this.cbCaThi = new System.Windows.Forms.ComboBox();
            this.cbMaLichThi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.MaLichThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoBuoiGac)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnSoBuoiGac);
            this.panel1.Controls.Add(this.btnResetLich);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.cbHocKy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnSoBuoiGac
            // 
            this.btnSoBuoiGac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.btnSoBuoiGac.FlatAppearance.BorderSize = 0;
            this.btnSoBuoiGac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoBuoiGac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoBuoiGac.ForeColor = System.Drawing.Color.White;
            this.btnSoBuoiGac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoBuoiGac.Location = new System.Drawing.Point(1183, 20);
            this.btnSoBuoiGac.Name = "btnSoBuoiGac";
            this.btnSoBuoiGac.Size = new System.Drawing.Size(159, 58);
            this.btnSoBuoiGac.TabIndex = 15;
            this.btnSoBuoiGac.Text = "Số buổi gác";
            this.btnSoBuoiGac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoBuoiGac.UseVisualStyleBackColor = false;
            this.btnSoBuoiGac.Click += new System.EventHandler(this.btnSoBuoiGac_Click);
            // 
            // btnResetLich
            // 
            this.btnResetLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.btnResetLich.FlatAppearance.BorderSize = 0;
            this.btnResetLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetLich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetLich.ForeColor = System.Drawing.Color.White;
            this.btnResetLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetLich.Location = new System.Drawing.Point(1001, 20);
            this.btnResetLich.Name = "btnResetLich";
            this.btnResetLich.Size = new System.Drawing.Size(159, 58);
            this.btnResetLich.TabIndex = 14;
            this.btnResetLich.Text = "Reset lịch thi";
            this.btnResetLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetLich.UseVisualStyleBackColor = false;
            this.btnResetLich.Click += new System.EventHandler(this.btnResetLich_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(856, 18);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 58);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(419, 33);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(369, 30);
            this.cbHocKy.TabIndex = 2;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn kì thi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch thi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbKieuSap);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.nupSoBuoiGac);
            this.panel3.Controls.Add(this.ckbTatCa);
            this.panel3.Controls.Add(this.cbMaGV);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSepGiangVienGac);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnDangKy);
            this.panel3.Controls.Add(this.cbNgay);
            this.panel3.Controls.Add(this.cbCaThi);
            this.panel3.Controls.Add(this.cbMaLichThi);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1055, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 683);
            this.panel3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Chọn kiều sắp:";
            // 
            // cbKieuSap
            // 
            this.cbKieuSap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKieuSap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKieuSap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKieuSap.Enabled = false;
            this.cbKieuSap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKieuSap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKieuSap.FormattingEnabled = true;
            this.cbKieuSap.Items.AddRange(new object[] {
            "Chia đều lịch gác",
            "Dồn buổi"});
            this.cbKieuSap.Location = new System.Drawing.Point(133, 518);
            this.cbKieuSap.Name = "cbKieuSap";
            this.cbKieuSap.Size = new System.Drawing.Size(189, 24);
            this.cbKieuSap.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số buổi gác:";
            // 
            // nupSoBuoiGac
            // 
            this.nupSoBuoiGac.Location = new System.Drawing.Point(133, 440);
            this.nupSoBuoiGac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSoBuoiGac.Name = "nupSoBuoiGac";
            this.nupSoBuoiGac.Size = new System.Drawing.Size(120, 30);
            this.nupSoBuoiGac.TabIndex = 17;
            this.nupSoBuoiGac.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckbTatCa
            // 
            this.ckbTatCa.AutoSize = true;
            this.ckbTatCa.Location = new System.Drawing.Point(133, 486);
            this.ckbTatCa.Name = "ckbTatCa";
            this.ckbTatCa.Size = new System.Drawing.Size(154, 26);
            this.ckbTatCa.TabIndex = 16;
            this.ckbTatCa.Text = "Tất cả giảng viên";
            this.ckbTatCa.UseVisualStyleBackColor = true;
            this.ckbTatCa.CheckedChanged += new System.EventHandler(this.ckbTatCa_CheckedChanged);
            // 
            // cbMaGV
            // 
            this.cbMaGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaGV.Font = new System.Drawing.Font("SFU ClearGothic", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaGV.FormattingEnabled = true;
            this.cbMaGV.Items.AddRange(new object[] {
            "Tất cả giảng viên"});
            this.cbMaGV.Location = new System.Drawing.Point(133, 395);
            this.cbMaGV.Name = "cbMaGV";
            this.cbMaGV.Size = new System.Drawing.Size(189, 26);
            this.cbMaGV.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Chọn mã GV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tự động sắp:";
            // 
            // btnSepGiangVienGac
            // 
            this.btnSepGiangVienGac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnSepGiangVienGac.Enabled = false;
            this.btnSepGiangVienGac.FlatAppearance.BorderSize = 0;
            this.btnSepGiangVienGac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepGiangVienGac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepGiangVienGac.ForeColor = System.Drawing.Color.White;
            this.btnSepGiangVienGac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSepGiangVienGac.Location = new System.Drawing.Point(75, 558);
            this.btnSepGiangVienGac.Name = "btnSepGiangVienGac";
            this.btnSepGiangVienGac.Size = new System.Drawing.Size(247, 58);
            this.btnSepGiangVienGac.TabIndex = 12;
            this.btnSepGiangVienGac.Text = "Sắp lịch tự động";
            this.btnSepGiangVienGac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSepGiangVienGac.UseVisualStyleBackColor = false;
            this.btnSepGiangVienGac.Click += new System.EventHandler(this.btnSepGiangVienGac_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(207, 233);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 58);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(75, 233);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(115, 58);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng kí";
            this.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbNgay
            // 
            this.cbNgay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNgay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNgay.Font = new System.Drawing.Font("SFU ClearGothic", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgay.FormattingEnabled = true;
            this.cbNgay.Location = new System.Drawing.Point(133, 116);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(189, 26);
            this.cbNgay.TabIndex = 7;
            // 
            // cbCaThi
            // 
            this.cbCaThi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCaThi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCaThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCaThi.Font = new System.Drawing.Font("SFU ClearGothic", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaThi.FormattingEnabled = true;
            this.cbCaThi.Location = new System.Drawing.Point(133, 159);
            this.cbCaThi.Name = "cbCaThi";
            this.cbCaThi.Size = new System.Drawing.Size(189, 26);
            this.cbCaThi.TabIndex = 6;
            // 
            // cbMaLichThi
            // 
            this.cbMaLichThi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaLichThi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaLichThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaLichThi.Font = new System.Drawing.Font("SFU ClearGothic", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLichThi.FormattingEnabled = true;
            this.cbMaLichThi.Location = new System.Drawing.Point(133, 74);
            this.cbMaLichThi.Name = "cbMaLichThi";
            this.cbMaLichThi.Size = new System.Drawing.Size(189, 26);
            this.cbMaLichThi.TabIndex = 5;
            this.cbMaLichThi.SelectedIndexChanged += new System.EventHandler(this.cbLHP_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chọn mã lịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Chọn ca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chọn ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đăng kí gác thi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLichThi);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 683);
            this.panel2.TabIndex = 3;
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichThi,
            this.MaPhong,
            this.MaGiangVien,
            this.MaLHP,
            this.ngayThi,
            this.CaThi});
            this.dgvLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichThi.Location = new System.Drawing.Point(0, 0);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.ReadOnly = true;
            this.dgvLichThi.Size = new System.Drawing.Size(1055, 683);
            this.dgvLichThi.TabIndex = 0;
            this.dgvLichThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichThi_CellClick_1);
            // 
            // MaLichThi
            // 
            this.MaLichThi.DataPropertyName = "MaLichThi";
            this.MaLichThi.HeaderText = "Mã lịch";
            this.MaLichThi.Name = "MaLichThi";
            this.MaLichThi.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "maPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // MaGiangVien
            // 
            this.MaGiangVien.DataPropertyName = "MaGiangVien";
            this.MaGiangVien.HeaderText = "Mã GV";
            this.MaGiangVien.Name = "MaGiangVien";
            this.MaGiangVien.ReadOnly = true;
            // 
            // MaLHP
            // 
            this.MaLHP.DataPropertyName = "MaLHP";
            this.MaLHP.HeaderText = "Mã LHP";
            this.MaLHP.Name = "MaLHP";
            this.MaLHP.ReadOnly = true;
            // 
            // ngayThi
            // 
            this.ngayThi.DataPropertyName = "NgayThi";
            this.ngayThi.HeaderText = "Ngày Thi";
            this.ngayThi.Name = "ngayThi";
            this.ngayThi.ReadOnly = true;
            // 
            // CaThi
            // 
            this.CaThi.DataPropertyName = "CaThi";
            this.CaThi.HeaderText = "Ca Thi";
            this.CaThi.Name = "CaThi";
            this.CaThi.ReadOnly = true;
            // 
            // UC_SapLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_SapLich";
            this.Size = new System.Drawing.Size(1397, 777);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoBuoiGac)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbMaLichThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNgay;
        private System.Windows.Forms.ComboBox cbCaThi;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSepGiangVienGac;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbMaGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbTatCa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupSoBuoiGac;
        private System.Windows.Forms.Button btnResetLich;
        private System.Windows.Forms.Button btnSoBuoiGac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbKieuSap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaThi;
    }
}
