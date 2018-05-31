namespace GUI
{
    partial class PhanCongGiangDayGUI
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhanCongGiangDay = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.cmbTenGV = new System.Windows.Forms.ComboBox();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanCongGiangDay)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSPhanCongGiangDay);
            this.groupBox3.Location = new System.Drawing.Point(13, 257);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(517, 210);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phân công giảng dạy";
            // 
            // dgvDSPhanCongGiangDay
            // 
            this.dgvDSPhanCongGiangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhanCongGiangDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPhanCongGiangDay.Location = new System.Drawing.Point(4, 19);
            this.dgvDSPhanCongGiangDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDSPhanCongGiangDay.Name = "dgvDSPhanCongGiangDay";
            this.dgvDSPhanCongGiangDay.Size = new System.Drawing.Size(509, 187);
            this.dgvDSPhanCongGiangDay.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên lớp học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên giáo viên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTenLop);
            this.groupBox4.Controls.Add(this.cmbTenGV);
            this.groupBox4.Controls.Add(this.cmbTenMonHoc);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(13, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(517, 164);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin lớp học";
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(168, 108);
            this.cmbTenLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(311, 24);
            this.cmbTenLop.TabIndex = 3;
            // 
            // cmbTenGV
            // 
            this.cmbTenGV.FormattingEnabled = true;
            this.cmbTenGV.Location = new System.Drawing.Point(168, 70);
            this.cmbTenGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTenGV.Name = "cmbTenGV";
            this.cmbTenGV.Size = new System.Drawing.Size(311, 24);
            this.cmbTenGV.TabIndex = 2;
            // 
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(168, 30);
            this.cmbTenMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(311, 24);
            this.cmbTenMonHoc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên môn học: ";
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Location = new System.Drawing.Point(148, 23);
            this.btnPhanCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(100, 28);
            this.btnPhanCong.TabIndex = 0;
            this.btnPhanCong.Text = "Phân công ";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXem);
            this.groupBox2.Controls.Add(this.btnPhanCong);
            this.groupBox2.Location = new System.Drawing.Point(13, 187);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(516, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(267, 23);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 28);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // PhanCongGiangDayGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhanCongGiangDayGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công giảng dạy";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanCongGiangDay)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSPhanCongGiangDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.ComboBox cmbTenGV;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXem;
    }
}