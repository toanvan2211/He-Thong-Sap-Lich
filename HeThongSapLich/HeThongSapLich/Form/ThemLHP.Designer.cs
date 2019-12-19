namespace HeThongSapLich
{
    partial class ThemLHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLHP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbMaMon = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaLHP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupSiSo = new System.Windows.Forms.NumericUpDown();
            this.tbTenLop = new System.Windows.Forms.TextBox();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.dragControl1 = new QuanLiDienThoai.DragControl();
            this.dragControl2 = new QuanLiDienThoai.DragControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSiSo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tạo lớp học phần";
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
            this.btnThoat.Location = new System.Drawing.Point(652, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(47, 46);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbMaMon
            // 
            this.cbMaMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMon.FormattingEnabled = true;
            this.cbMaMon.Location = new System.Drawing.Point(204, 168);
            this.cbMaMon.Name = "cbMaMon";
            this.cbMaMon.Size = new System.Drawing.Size(207, 29);
            this.cbMaMon.TabIndex = 3;
            this.cbMaMon.SelectedIndexChanged += new System.EventHandler(this.cbMaMon_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mã lớp học phần:";
            // 
            // cbMaLop
            // 
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(204, 127);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(207, 29);
            this.cbMaLop.TabIndex = 2;
            this.cbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã môn:";
            // 
            // tbMaLHP
            // 
            this.tbMaLHP.Location = new System.Drawing.Point(204, 88);
            this.tbMaLHP.Name = "tbMaLHP";
            this.tbMaLHP.Size = new System.Drawing.Size(207, 29);
            this.tbMaLHP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sỉ số:";
            // 
            // nupSiSo
            // 
            this.nupSiSo.Location = new System.Drawing.Point(204, 207);
            this.nupSiSo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupSiSo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupSiSo.Name = "nupSiSo";
            this.nupSiSo.Size = new System.Drawing.Size(120, 29);
            this.nupSiSo.TabIndex = 4;
            this.nupSiSo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbTenLop
            // 
            this.tbTenLop.Location = new System.Drawing.Point(431, 127);
            this.tbTenLop.Name = "tbTenLop";
            this.tbTenLop.ReadOnly = true;
            this.tbTenLop.Size = new System.Drawing.Size(209, 29);
            this.tbTenLop.TabIndex = 23;
            // 
            // tbTenMon
            // 
            this.tbTenMon.Location = new System.Drawing.Point(431, 168);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.ReadOnly = true;
            this.tbTenMon.Size = new System.Drawing.Size(209, 29);
            this.tbTenMon.TabIndex = 24;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(352, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(115)))));
            this.btnTao.FlatAppearance.BorderSize = 0;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Location = new System.Drawing.Point(202, 267);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(144, 38);
            this.btnTao.TabIndex = 5;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.label1;
            // 
            // ThemLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 334);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.tbTenMon);
            this.Controls.Add(this.tbTenLop);
            this.Controls.Add(this.nupSiSo);
            this.Controls.Add(this.tbMaLHP);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaMon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThemLHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemLHP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSiSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QuanLiDienThoai.DragControl dragControl1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaMon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaLHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupSiSo;
        private System.Windows.Forms.TextBox tbTenLop;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTao;
        private QuanLiDienThoai.DragControl dragControl2;
    }
}