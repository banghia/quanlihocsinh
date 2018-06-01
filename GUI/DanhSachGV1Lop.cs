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
    public partial class DanhSachGV1Lop : Form
    {
        LopBUS lopBUS = new LopBUS();

        public DanhSachGV1Lop()
        {
            InitializeComponent();
        }

        private void DanhSachGV1Lop_Load(object sender, EventArgs e)
        {
            //Load dữ liệu lên cmb.
            cmbLop.DataSource = lopBUS.All();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
            // TODO: This line of code loads data into the 'dsGiaoVienLopDataSet.dsGiaoVienLop' table. You can move, or remove it, as needed.
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //Đổ dữ liệu vào report.
            this.dsGiaoVienLopTableAdapter.Fill(this.dsGiaoVienLopDataSet.dsGiaoVienLop, cmbLop.SelectedValue.ToString());
            //Lấy ra form main để tham chiếu đên user đã đăng nhập.
            MainGUI main = (MainGUI)this.MdiParent;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{
                new ReportParameter("TenLop", cmbLop.Text),
                new ReportParameter("NguoiLap", main.User.HoTen)
            });
            this.reportViewer1.RefreshReport();
        }
    }
}
