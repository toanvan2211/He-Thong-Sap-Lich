﻿namespace HeThongSapLich
{
    partial class XoaHocKy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaHocKy));
            this.pnl = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.MaLichThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dragControl1 = new QuanLiDienThoai.DragControl();
            this.dragControl2 = new QuanLiDienThoai.DragControl();
            this.pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.btnDongY);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.btnHuy);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 55);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(818, 149);
            this.pnl.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(460, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nếu bạn xóa học kỳ này, tất cả dữ liệu liên quan đến nó sẽ mất vĩnh viễn";
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.btnDongY.FlatAppearance.BorderSize = 0;
            this.btnDongY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongY.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnDongY.Location = new System.Drawing.Point(296, 88);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(5);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(108, 46);
            this.btnDongY.TabIndex = 33;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Hãy xác nhận?";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(219)))), ((int)(((byte)(148)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnHuy.Location = new System.Drawing.Point(414, 88);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 46);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 55);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 49;
            this.label1.Text = "Bạn có chắc muốn xóa?";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("SFU ClearGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(761, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(57, 55);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLichThi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 248);
            this.panel2.TabIndex = 38;
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
            this.dgvLichThi.Size = new System.Drawing.Size(818, 248);
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
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.label1;
            // 
            // XoaHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XoaHocKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XoaHocKy";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaThi;
        private QuanLiDienThoai.DragControl dragControl1;
        private QuanLiDienThoai.DragControl dragControl2;
    }
}