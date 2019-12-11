namespace HeThongSapLich.User_Control
{
    partial class UC_Lich
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbKyThi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.MaLichThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbKyThi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1597, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lịch thi";
            // 
            // cbKyThi
            // 
            this.cbKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKyThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKyThi.FormattingEnabled = true;
            this.cbKyThi.Location = new System.Drawing.Point(576, 56);
            this.cbKyThi.Name = "cbKyThi";
            this.cbKyThi.Size = new System.Drawing.Size(369, 25);
            this.cbKyThi.TabIndex = 6;
            this.cbKyThi.SelectedIndexChanged += new System.EventHandler(this.cbKyThi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Chọn kì thi:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLichThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1597, 671);
            this.panel2.TabIndex = 1;
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichThi,
            this.MaPhong,
            this.MaGiangVien,
            this.TenGiangVien,
            this.MaLHP,
            this.mon,
            this.ngayThi,
            this.CaThi});
            this.dgvLichThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichThi.Location = new System.Drawing.Point(0, 0);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.ReadOnly = true;
            this.dgvLichThi.Size = new System.Drawing.Size(1597, 671);
            this.dgvLichThi.TabIndex = 2;
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
            // TenGiangVien
            // 
            this.TenGiangVien.DataPropertyName = "ten";
            this.TenGiangVien.HeaderText = "Tên giảng viên";
            this.TenGiangVien.Name = "TenGiangVien";
            this.TenGiangVien.ReadOnly = true;
            // 
            // MaLHP
            // 
            this.MaLHP.DataPropertyName = "MaLHP";
            this.MaLHP.HeaderText = "Mã lớp học phần";
            this.MaLHP.Name = "MaLHP";
            this.MaLHP.ReadOnly = true;
            // 
            // mon
            // 
            this.mon.DataPropertyName = "mon";
            this.mon.HeaderText = "Môn";
            this.mon.Name = "mon";
            this.mon.ReadOnly = true;
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
            // UC_Lich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UC_Lich";
            this.Size = new System.Drawing.Size(1597, 777);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKyThi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaThi;
    }
}
