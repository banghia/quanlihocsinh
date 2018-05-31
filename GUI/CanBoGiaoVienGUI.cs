using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class CanBoGiaoVienGUI : Form
    {
        CanBoGiaoVienBUS cbgvBUS = new CanBoGiaoVienBUS();

        public CanBoGiaoVienGUI()
        {
            InitializeComponent();
        }

        private void CanBoGiaoVienGUI_Load(object sender, EventArgs e)
        {
            dgvCanBoGiaoVien.DataSource = cbgvBUS.All();
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
            txtMaCBGV.Clear();
            txtHoTenCBGV.Clear();
            txtMatKhau.Clear();
            txtTaiKhoan.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            cmbLoaiTK.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaCBGV.Text) || String.IsNullOrEmpty(txtHoTenCBGV.Text) || String.IsNullOrEmpty(txtDiaChi.Text)
                || String.IsNullOrEmpty(txtSoDT.Text) || String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text) || String.IsNullOrEmpty(cmbLoaiTK.Text)) {
                    MessageBox.Show("Không được để trống thông tin.");
                    return;
            }

            if (cbgvBUS.Exist(txtMaCBGV.Text)) {
                MessageBox.Show("Mã Cán bộ/Giáo viên đã tồn tại.");
                return;
            }

            if (cbgvBUS.ExistAccount(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.");
                return;
            }

            CanBoGiaoVien cbgv = new CanBoGiaoVien();
            cbgv.MaCanBoGiaoVien = txtMaCBGV.Text;
            cbgv.HoTen = txtHoTenCBGV.Text;
            cbgv.DiaChi = txtDiaChi.Text;
            cbgv.SoDienThoai = txtSoDT.Text;
            cbgv.TaiKhoan = txtTaiKhoan.Text;
            cbgv.MatKhau = txtMatKhau.Text;
            cbgv.LoaiTaiKhoan = cmbLoaiTK.Text;

            if (!cbgvBUS.Insert(cbgv)) {
                MessageBox.Show("Thêm Cán bộ/Giáo viên không thành công.");
                return;
            }

            CanBoGiaoVienGUI_Load(sender, e);
        }

        private string taiKhoanCu;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không được để trống.");
                return;
            }

            if (!cbgvBUS.Exist(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không tồn tại.");
                return;
            }

            CanBoGiaoVien cbgv = cbgvBUS.Get(txtMaCBGV.Text);
            txtMaCBGV.Text = cbgv.MaCanBoGiaoVien;
            txtHoTenCBGV.Text = cbgv.HoTen;
            txtDiaChi.Text = cbgv.DiaChi;
            txtSoDT.Text = cbgv.SoDienThoai;
            txtTaiKhoan.Text = cbgv.TaiKhoan;
            txtMatKhau.Text = cbgv.MatKhau;
            cmbLoaiTK.Text = cbgv.LoaiTaiKhoan;
            taiKhoanCu = cbgv.TaiKhoan;
            txtMaCBGV.Enabled = false;
            BatTatLHTSX();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không được để trống.");
                return;
            }

            if (!cbgvBUS.Exist(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không tồn tại.");
                return;
            }

            if (!cbgvBUS.Delete(txtMaCBGV.Text))
            {
                MessageBox.Show("Xóa Cán bộ/Giáo viên không thành công.");
                return;
            }

            CanBoGiaoVienGUI_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaCBGV.Text) || String.IsNullOrEmpty(txtHoTenCBGV.Text) || String.IsNullOrEmpty(txtDiaChi.Text)
                || String.IsNullOrEmpty(txtSoDT.Text) || String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text) || String.IsNullOrEmpty(cmbLoaiTK.Text))
            {
                MessageBox.Show("Không được để trống thông tin.");
                return;
            }

            if (!taiKhoanCu.Equals(txtTaiKhoan.Text) && cbgvBUS.ExistAccount(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.");
                return;
            }

            CanBoGiaoVien cbgv = new CanBoGiaoVien();
            cbgv.MaCanBoGiaoVien = txtMaCBGV.Text;
            cbgv.HoTen = txtHoTenCBGV.Text;
            cbgv.DiaChi = txtDiaChi.Text;
            cbgv.SoDienThoai = txtSoDT.Text;
            cbgv.TaiKhoan = txtTaiKhoan.Text;
            cbgv.MatKhau = txtMatKhau.Text;
            cbgv.LoaiTaiKhoan = cmbLoaiTK.Text;

            if (!cbgvBUS.Update(cbgv))
            {
                MessageBox.Show("Xóa Cán bộ/Giáo viên không thành công.");
                return;
            }

            CanBoGiaoVienGUI_Load(sender, e);
            btnHuy_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCBGV.Enabled = true;
            BatTatLHTSX();
            XoaDuLieuForm();
        }
    }
}
