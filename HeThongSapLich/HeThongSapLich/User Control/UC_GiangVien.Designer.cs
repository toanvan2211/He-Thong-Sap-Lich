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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.maGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbKhoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvGiangVien.MultiSelect = false;
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.ReadOnly = true;
            this.dgvGiangVien.Size = new System.Drawing.Size(876, 580);
            this.dgvGiangVien.TabIndex = 0;
            this.dgvGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellClick);
            // 
            // maGiangVien
            // 
            this.maGiangVien.DataPropertyName = "maGiangVien";
            this.maGiangVien.HeaderText = "Mã Giảng Viên";
            this.maGiangVien.Name = "maGiangVien";
            this.maGiangVien.ReadOnly = true;
            this.maGiangVien.Width = 150;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.FillWeight = 65.65144F;
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 250;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "khoa";
            this.Khoa.FillWeight = 65.65144F;
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 230;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // gmail
            // 
            this.gmail.DataPropertyName = "gmail";
            this.gmail.FillWeight = 65.65144F;
            this.gmail.HeaderText = "Gmail";
            this.gmail.Name = "gmail";
            this.gmail.ReadOnly = true;
            this.gmail.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(860, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbKhoa);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbMail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbGioiTinh);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbMaGV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbTen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(931, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 530);
            this.panel2.TabIndex = 5;
            // 
            // tbKhoa
            // 
            this.tbKhoa.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhoa.Location = new System.Drawing.Point(118, 114);
            this.tbKhoa.Name = "tbKhoa";
            this.tbKhoa.ReadOnly = true;
            this.tbKhoa.Size = new System.Drawing.Size(323, 30);
            this.tbKhoa.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "Khoa:";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(118, 204);
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(157, 30);
            this.tbMail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mail:";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGioiTinh.Location = new System.Drawing.Point(118, 160);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.ReadOnly = true;
            this.tbGioiTinh.Size = new System.Drawing.Size(157, 30);
            this.tbGioiTinh.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giới tính:";
            // 
            // tbMaGV
            // 
            this.tbMaGV.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaGV.Location = new System.Drawing.Point(118, 24);
            this.tbMaGV.Name = "tbMaGV";
            this.tbMaGV.ReadOnly = true;
            this.tbMaGV.Size = new System.Drawing.Size(157, 30);
            this.tbMaGV.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã GV:";
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(118, 70);
            this.tbTen.Name = "tbTen";
            this.tbTen.ReadOnly = true;
            this.tbTen.Size = new System.Drawing.Size(323, 30);
            this.tbTen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.btnChangeInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1387, 71);
            this.panel4.TabIndex = 6;
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeInfo.FlatAppearance.BorderSize = 0;
            this.btnChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeInfo.ForeColor = System.Drawing.Color.White;
            this.btnChangeInfo.Location = new System.Drawing.Point(0, 0);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(202, 71);
            this.btnChangeInfo.TabIndex = 23;
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
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbGioiTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMaGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
    }
}
