namespace HeThongSapLich
{
    partial class SoBuoiGac
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
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSoBuoiGac = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoBuoiGac)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHocKy
            // 
            this.cbHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(271, 23);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(369, 28);
            this.cbHocKy.TabIndex = 4;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn kì thi:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSoBuoiGac);
            this.panel1.Location = new System.Drawing.Point(49, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 337);
            this.panel1.TabIndex = 5;
            // 
            // dgvSoBuoiGac
            // 
            this.dgvSoBuoiGac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoBuoiGac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoBuoiGac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoBuoiGac.Location = new System.Drawing.Point(0, 0);
            this.dgvSoBuoiGac.Name = "dgvSoBuoiGac";
            this.dgvSoBuoiGac.ReadOnly = true;
            this.dgvSoBuoiGac.Size = new System.Drawing.Size(725, 337);
            this.dgvSoBuoiGac.TabIndex = 1;
            // 
            // SoBuoiGac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.label4);
            this.Name = "SoBuoiGac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Số buổi gác";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoBuoiGac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSoBuoiGac;
    }
}