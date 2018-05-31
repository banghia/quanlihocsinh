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
    public partial class QuanLyHoSoHocSinh : Form
    {
        HoSoHocSinhBUS hshsBUS = new HoSoHocSinhBUS();
        LopBUS lopBUS = new LopBUS();

        public QuanLyHoSoHocSinh()
        {
            InitializeComponent();
        }

        private void QuanLyHoSoHocSinh_Load(object sender, EventArgs e)
        {
            dgvHSHS.DataSource = hshsBUS.All();
            cmbLop.DataSource = lopBUS.All();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
            XoaDuLieuForm();
        }

        private void BatTatLHTSX() {
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            btnThem.Enabled = !btnThem.Enabled;
            btnSua.Enabled = !btnSua.Enabled;
            btnXoa.Enabled = !btnXoa.Enabled;
        }

        private void XoaDuLieuForm() {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            numDiemVaoTruong.Value = numDiemVaoTruong.Minimum;
            txtHoTenBoMe.Clear();
            txtSoDienThoai.Clear();
            cmbGioiTinh.SelectedIndex = 0;
            //cmbLop.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaHS.Text) || String.IsNullOrEmpty(txtHoTen.Text) || String.IsNullOrEmpty(dtpNgaySinh.Text) || String.IsNullOrEmpty(cmbGioiTinh.Text)
                || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtHoTenBoMe.Text)
                || String.IsNullOrEmpty(txtSoDienThoai.Text) || String.IsNullOrEmpty(cmbLop.Text)) {
                    MessageBox.Show("Không được để trống thông tin.");
                    return;
            }

            if (hshsBUS.Exist(txtMaHS.Text)) {
                MessageBox.Show("Mã học sinh đã tồn tại.");
                return;
            }

            HoSoHocSinh hshs = new HoSoHocSinh();
            hshs.MaHocSinh = txtMaHS.Text;
            hshs.HoTen = txtHoTen.Text;
            hshs.NgaySinh = dtpNgaySinh.Value;
            hshs.GioiTinh = cmbGioiTinh.Text;
            hshs.DiaChi = txtDiaChi.Text;
            hshs.DiemVaoTruong = (float)numDiemVaoTruong.Value;
            hshs.HoTenBoMe = txtHoTenBoMe.Text;
            hshs.SoDienThoai = txtSoDienThoai.Text;
            hshs.MaLop = cmbLop.SelectedValue.ToString();

            if (!hshsBUS.Insert(hshs)) {
                MessageBox.Show("Thêm học sinh thất bại.");
                return;
            }

            QuanLyHoSoHocSinh_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaHS.Text)) {
                MessageBox.Show("Mã học sinh không được để trống.");
                return;
            }

            if (!hshsBUS.Exist(txtMaHS.Text)) {
                MessageBox.Show("Mã học sinh không tồn tại.");
                return;
            }

            HoSoHocSinh hshs = hshsBUS.Get(txtMaHS.Text);
            txtHoTen.Text = hshs.HoTen;
            dtpNgaySinh.Value = hshs.NgaySinh;
            cmbGioiTinh.Text = hshs.GioiTinh;
            txtDiaChi.Text = hshs.DiaChi;
            numDiemVaoTruong.Value = (decimal)hshs.DiemVaoTruong;
            txtHoTenBoMe.Text = hshs.HoTenBoMe;
            txtSoDienThoai.Text = hshs.SoDienThoai;
            cmbLop.SelectedValue = hshs.MaLop;
            txtMaHS.Enabled = false;
            BatTatLHTSX();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaHS.Text))
            {
                MessageBox.Show("Mã học sinh không được để trống.");
                return;
            }

            if (!hshsBUS.Exist(txtMaHS.Text))
            {
                MessageBox.Show("Mã học sinh không tồn tại.");
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận xóa", "Bạn có chắc chắn muốn xóa học sinh này?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            if (!hshsBUS.Delete(txtMaHS.Text)) {
                MessageBox.Show("Xóa học sinh không thành công.");
                return;
            }

            QuanLyHoSoHocSinh_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaHS.Text) || String.IsNullOrEmpty(txtHoTen.Text) || String.IsNullOrEmpty(dtpNgaySinh.Text) || String.IsNullOrEmpty(cmbGioiTinh.Text)
                || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtHoTenBoMe.Text)
                || String.IsNullOrEmpty(txtSoDienThoai.Text) || String.IsNullOrEmpty(cmbLop.Text))
            {
                MessageBox.Show("Không được để trống thông tin.");
                return;
            }

            HoSoHocSinh hshs = new HoSoHocSinh();
            hshs.MaHocSinh = txtMaHS.Text;
            hshs.HoTen = txtHoTen.Text;
            hshs.NgaySinh = dtpNgaySinh.Value;
            hshs.GioiTinh = cmbGioiTinh.Text;
            hshs.DiaChi = txtDiaChi.Text;
            hshs.DiemVaoTruong = (float)numDiemVaoTruong.Value;
            hshs.HoTenBoMe = txtHoTenBoMe.Text;
            hshs.SoDienThoai = txtSoDienThoai.Text;
            hshs.MaLop = cmbLop.SelectedValue.ToString();

            if (!hshsBUS.Update(hshs)) {
                MessageBox.Show("Sửa thông tin học sinh không thành công.");
                return;
            }

            QuanLyHoSoHocSinh_Load(sender, e);
            btnHuy_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHS.Enabled = true;
            BatTatLHTSX();
            XoaDuLieuForm();
        }
    }
}
