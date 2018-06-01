using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class PhanCongGiangDayGUI : Form
    {

        LopBUS lopBUS = new LopBUS();
        MonHocBUS monHocBUS = new MonHocBUS();
        CanBoGiaoVienBUS cbgvBUS = new CanBoGiaoVienBUS();
        PhanCongGiangDayBUS pcgdBUS = new PhanCongGiangDayBUS();

        public PhanCongGiangDayGUI()
        {
            InitializeComponent();
        }

        private void PhanCongGiangDayGUI_Load(object sender, EventArgs e)
        {
            dgvDSPhanCongGiangDay.DataSource = pcgdBUS.All();
            cmbTenLop.DataSource = lopBUS.All();
            cmbTenLop.DisplayMember = "TenLop";
            cmbTenLop.ValueMember = "MaLop";
            cmbMonHoc.DataSource = monHocBUS.All();
            cmbMonHoc.DisplayMember = "TenMon";
            cmbMonHoc.ValueMember = "MaMon";
            cmbTenGV.DataSource = cbgvBUS.AllGiaoVien();
            cmbTenGV.DisplayMember = "HoTen";
            cmbTenGV.ValueMember = "MaCanBoGiaoVien";
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedIndex == -1 || cmbTenGV.SelectedIndex == -1 || cmbMonHoc.SelectedIndex == -1) {
                MessageBox.Show("Không để trống thông tin.");
                return;
            }

            PhanCongGiangDay pcgd = new PhanCongGiangDay();
            pcgd.MaLop = cmbTenLop.SelectedValue.ToString();
            pcgd.MaMon = cmbMonHoc.SelectedValue.ToString();
            pcgd.MaCanBoGiaoVien = cmbTenGV.SelectedValue.ToString();
            pcgd.NgayPhanCong = DateTime.Now;

            if (pcgdBUS.Exist(pcgd.MaLop, pcgd.MaMon, pcgd.MaCanBoGiaoVien))
            {
                MessageBox.Show("Phân công giảng dạy đã tồn tại.");
                return;
            }

            if (!pcgdBUS.Insert(pcgd)) {
                MessageBox.Show("Phân công giảng dạy không thành công.");
                return;
            }

            PhanCongGiangDayGUI_Load(sender, e);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maLop = null;
            if (chkLop.Checked) maLop = cmbTenLop.SelectedValue.ToString();
            string maMonHoc = null;
            if (chkMonHoc.Checked) maMonHoc = cmbMonHoc.SelectedValue.ToString();
            string maGiaoVien = null;
            if (chkGiaoVien.Checked) maGiaoVien = cmbTenGV.SelectedValue.ToString();
            dgvDSPhanCongGiangDay.DataSource = pcgdBUS.Search(maLop, maMonHoc, maGiaoVien);
        }
    }
}
