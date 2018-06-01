namespace GUI
{
    partial class DanhSachHocSinh
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvTTHocSinh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.HoSoHocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLHocSinhDataSet = new GUI.QLHocSinhDataSet();
            this.HoSoHocSinhTableAdapter = new GUI.QLHocSinhDataSetTableAdapters.HoSoHocSinhTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoSoHocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHocSinhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLop);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(953, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(668, 31);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 28);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên lớp:";
            // 
            // rpvTTHocSinh
            // 
            this.rpvTTHocSinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoSoHocSinhBindingSource;
            this.rpvTTHocSinh.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvTTHocSinh.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.rpvTTHocSinh.Location = new System.Drawing.Point(0, 116);
            this.rpvTTHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.rpvTTHocSinh.Name = "rpvTTHocSinh";
            this.rpvTTHocSinh.Size = new System.Drawing.Size(982, 487);
            this.rpvTTHocSinh.TabIndex = 1;
            this.rpvTTHocSinh.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rpvTTHocSinh.ZoomPercent = 90;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(289, 34);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(334, 24);
            this.cmbLop.TabIndex = 3;
            // 
            // HoSoHocSinhBindingSource
            // 
            this.HoSoHocSinhBindingSource.DataMember = "HoSoHocSinh";
            this.HoSoHocSinhBindingSource.DataSource = this.QLHocSinhDataSet;
            // 
            // QLHocSinhDataSet
            // 
            this.QLHocSinhDataSet.DataSetName = "QLHocSinhDataSet";
            this.QLHocSinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoSoHocSinhTableAdapter
            // 
            this.HoSoHocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.rpvTTHocSinh);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.DanhSachHocSinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoSoHocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLHocSinhDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTTHocSinh;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.BindingSource HoSoHocSinhBindingSource;
        private QLHocSinhDataSet QLHocSinhDataSet;
        private QLHocSinhDataSetTableAdapters.HoSoHocSinhTableAdapter HoSoHocSinhTableAdapter;
    }
}