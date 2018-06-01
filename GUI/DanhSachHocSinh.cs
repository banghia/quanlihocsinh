using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class DanhSachHocSinh : Form
    {
        LopBUS lopBUS = new LopBUS();

        public DanhSachHocSinh()
        {
            InitializeComponent();
        }

        private void DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            cmbLop.DataSource = lopBUS.All();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
            // TODO: This line of code loads data into the 'QLHocSinhDataSet.HoSoHocSinh' table. You can move, or remove it, as needed.
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.HoSoHocSinhTableAdapter.Fill(this.QLHocSinhDataSet.HoSoHocSinh, cmbLop.SelectedValue.ToString());
            MainGUI mainForm = (MainGUI)this.MdiParent;
            this.rpvTTHocSinh.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("TenLop", cmbLop.Text),
                new ReportParameter("NguoiLap", mainForm.User.HoTen)
            });
            this.rpvTTHocSinh.RefreshReport();
        }
    }
}
