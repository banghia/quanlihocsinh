namespace GUI
{
    partial class DanhSachGV1Lop
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsGiaoVienLopDataSet = new GUI.dsGiaoVienLopDataSet();
            this.dsGiaoVienLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGiaoVienLopTableAdapter = new GUI.dsGiaoVienLopDataSetTableAdapters.dsGiaoVienLopTableAdapter();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGiaoVienLopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGiaoVienLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(662, 31);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 28);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên lớp:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dsGiaoVienLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(982, 502);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // dsGiaoVienLopDataSet
            // 
            this.dsGiaoVienLopDataSet.DataSetName = "dsGiaoVienLopDataSet";
            this.dsGiaoVienLopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsGiaoVienLopBindingSource
            // 
            this.dsGiaoVienLopBindingSource.DataMember = "dsGiaoVienLop";
            this.dsGiaoVienLopBindingSource.DataSource = this.dsGiaoVienLopDataSet;
            // 
            // dsGiaoVienLopTableAdapter
            // 
            this.dsGiaoVienLopTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLop
            // 
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(259, 33);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(353, 24);
            this.cmbLop.TabIndex = 3;
            // 
            // DanhSachGV1Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachGV1Lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách GV 1 lớp";
            this.Load += new System.EventHandler(this.DanhSachGV1Lop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGiaoVienLopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGiaoVienLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsGiaoVienLopBindingSource;
        private dsGiaoVienLopDataSet dsGiaoVienLopDataSet;
        private dsGiaoVienLopDataSetTableAdapters.dsGiaoVienLopTableAdapter dsGiaoVienLopTableAdapter;
        private System.Windows.Forms.ComboBox cmbLop;
    }
}