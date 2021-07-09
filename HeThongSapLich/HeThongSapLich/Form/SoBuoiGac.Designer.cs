namespace HeThongSapLich
{
    partial class frPhieuGac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPhieuGac));
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSoBuoiGac = new System.Windows.Forms.DataGridView();
            this.maPhieuGac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHocKy1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBuoiGac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dragControl1 = new QuanLiDienThoai.DragControl();
            this.dragControl2 = new QuanLiDienThoai.DragControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoBuoiGac)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(318, 69);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(430, 28);
            this.cbHocKy.TabIndex = 4;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn kì thi:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSoBuoiGac);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(59, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 337);
            this.panel1.TabIndex = 5;
            // 
            // dgvSoBuoiGac
            // 
            this.dgvSoBuoiGac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoBuoiGac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoBuoiGac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuGac,
            this.maHocKy1,
            this.maGiangVien,
            this.soBuoiGac});
            this.dgvSoBuoiGac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoBuoiGac.Location = new System.Drawing.Point(0, 0);
            this.dgvSoBuoiGac.Name = "dgvSoBuoiGac";
            this.dgvSoBuoiGac.ReadOnly = true;
            this.dgvSoBuoiGac.Size = new System.Drawing.Size(756, 337);
            this.dgvSoBuoiGac.TabIndex = 1;
            // 
            // maPhieuGac
            // 
            this.maPhieuGac.DataPropertyName = "maGacThi";
            this.maPhieuGac.HeaderText = "Mã phiếu gác";
            this.maPhieuGac.Name = "maPhieuGac";
            this.maPhieuGac.ReadOnly = true;
            // 
            // maHocKy1
            // 
            this.maHocKy1.DataPropertyName = "maHocKy";
            this.maHocKy1.HeaderText = "Mã học kỳ";
            this.maHocKy1.Name = "maHocKy1";
            this.maHocKy1.ReadOnly = true;
            this.maHocKy1.Visible = false;
            // 
            // maGiangVien
            // 
            this.maGiangVien.DataPropertyName = "maGiangVien";
            this.maGiangVien.HeaderText = "Mã giảng viên";
            this.maGiangVien.Name = "maGiangVien";
            this.maGiangVien.ReadOnly = true;
            // 
            // soBuoiGac
            // 
            this.soBuoiGac.DataPropertyName = "soBuoiGac";
            this.soBuoiGac.HeaderText = "Số buổi gác";
            this.soBuoiGac.Name = "soBuoiGac";
            this.soBuoiGac.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 46);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Phiếu gác thi";
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
            this.btnThoat.Location = new System.Drawing.Point(818, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 46);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.label1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panel2;
            // 
            // frPhieuGac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frPhieuGac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu gác thi";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoBuoiGac)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSoBuoiGac;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuGac;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHocKy1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBuoiGac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private QuanLiDienThoai.DragControl dragControl1;
        private QuanLiDienThoai.DragControl dragControl2;
    }
}