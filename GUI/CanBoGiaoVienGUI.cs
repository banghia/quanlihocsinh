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

        //Load dữ liệu lên form.
        private void CanBoGiaoVienGUI_Load(object sender, EventArgs e)
        {
            dgvCanBoGiaoVien.DataSource = cbgvBUS.All();
            XoaDuLieuForm();
        }

        //Bật tắt nút lưu hủy thêm sửa xóa.
        private void BatTatLHTSX() {
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            btnThem.Enabled = !btnThem.Enabled;
            btnSua.Enabled = !btnSua.Enabled;
            btnXoa.Enabled = !btnXoa.Enabled;
        }

        //Xóa dữ liệu trên form.
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
            //Kiểm tra dữ liệu có để trống hay không.
            if (String.IsNullOrEmpty(txtMaCBGV.Text) || String.IsNullOrEmpty(txtHoTenCBGV.Text) || String.IsNullOrEmpty(txtDiaChi.Text)
                || String.IsNullOrEmpty(txtSoDT.Text) || String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text) || String.IsNullOrEmpty(cmbLoaiTK.Text)) {
                    MessageBox.Show("Không được để trống thông tin.");
                    return;
            }
            //Kiểm tra mã đã tồn tại.
            if (cbgvBUS.Exist(txtMaCBGV.Text)) {
                MessageBox.Show("Mã Cán bộ/Giáo viên đã tồn tại.");
                return;
            }
            //Kiểm tra tên tài khoản đã tồn tại.
            if (cbgvBUS.ExistAccount(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.");
                return;
            }
            //Đóng gói dữ liệu trên form.
            CanBoGiaoVien cbgv = new CanBoGiaoVien();
            cbgv.MaCanBoGiaoVien = txtMaCBGV.Text;
            cbgv.HoTen = txtHoTenCBGV.Text;
            cbgv.DiaChi = txtDiaChi.Text;
            cbgv.SoDienThoai = txtSoDT.Text;
            cbgv.TaiKhoan = txtTaiKhoan.Text;
            cbgv.MatKhau = txtMatKhau.Text;
            cbgv.LoaiTaiKhoan = cmbLoaiTK.Text;
            //Kiểm tra thêm không thành công.
            if (!cbgvBUS.Insert(cbgv)) {
                MessageBox.Show("Thêm Cán bộ/Giáo viên không thành công.");
                return;
            }
            //Load lại dữ liệu khi thêm thành công.
            CanBoGiaoVienGUI_Load(sender, e);
        }

        private string taiKhoanCu;
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã có để trống hay không.
            if (String.IsNullOrEmpty(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không được để trống.");
                return;
            }
            //Kiểm tra mã không tồn tại.
            if (!cbgvBUS.Exist(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không tồn tại.");
                return;
            }
            //Lấy dữ liệu từ bảng cán bộ giáo viên theo mã.
            CanBoGiaoVien cbgv = cbgvBUS.Get(txtMaCBGV.Text);
            txtMaCBGV.Text = cbgv.MaCanBoGiaoVien;
            txtHoTenCBGV.Text = cbgv.HoTen;
            txtDiaChi.Text = cbgv.DiaChi;
            txtSoDT.Text = cbgv.SoDienThoai;
            txtTaiKhoan.Text = cbgv.TaiKhoan;
            txtMatKhau.Text = cbgv.MatKhau;
            cmbLoaiTK.Text = cbgv.LoaiTaiKhoan;
            taiKhoanCu = cbgv.TaiKhoan;
            //Tắt txt mã cán bộ.
            txtMaCBGV.Enabled = false;
            BatTatLHTSX();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã để trống.
            if (String.IsNullOrEmpty(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không được để trống.");
                return;
            }
            //Kiểm tra mã không tồn tại.
            if (!cbgvBUS.Exist(txtMaCBGV.Text))
            {
                MessageBox.Show("Mã Cán bộ/Giáo viên không tồn tại.");
                return;
            }
            //Kiểm tra xóa không thành công.
            if (!cbgvBUS.Delete(txtMaCBGV.Text))
            {
                MessageBox.Show("Xóa Cán bộ/Giáo viên không thành công.");
                return;
            }
            //Load lại dữ liệu nếu xóa thành công.
            CanBoGiaoVienGUI_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu để trống.
            if (String.IsNullOrEmpty(txtMaCBGV.Text) || String.IsNullOrEmpty(txtHoTenCBGV.Text) || String.IsNullOrEmpty(txtDiaChi.Text)
                || String.IsNullOrEmpty(txtSoDT.Text) || String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text) || String.IsNullOrEmpty(cmbLoaiTK.Text))
            {
                MessageBox.Show("Không được để trống thông tin.");
                return;
            }
            //Kiểm tra tài khoản đã tồn tại hay chưa, không tính tên tài khoản cũ.
            if (!taiKhoanCu.Equals(txtTaiKhoan.Text) && cbgvBUS.ExistAccount(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.");
                return;
            }
            //Đóng gói dữ liệu trên form.
            CanBoGiaoVien cbgv = new CanBoGiaoVien();
            cbgv.MaCanBoGiaoVien = txtMaCBGV.Text;
            cbgv.HoTen = txtHoTenCBGV.Text;
            cbgv.DiaChi = txtDiaChi.Text;
            cbgv.SoDienThoai = txtSoDT.Text;
            cbgv.TaiKhoan = txtTaiKhoan.Text;
            cbgv.MatKhau = txtMatKhau.Text;
            cbgv.LoaiTaiKhoan = cmbLoaiTK.Text;
            //Kiểm tra cập nhật thất bại.
            if (!cbgvBUS.Update(cbgv))
            {
                MessageBox.Show("Sửa Cán bộ/Giáo viên không thành công.");
                return;
            }
            //Load lại dữ liệu khi thành công.
            CanBoGiaoVienGUI_Load(sender, e);
            btnHuy_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCBGV.Enabled = true;
            BatTatLHTSX();
            XoaDuLieuForm();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvCanBoGiaoVien.DataSource = cbgvBUS.Search(txtTim.Text);
        }
    }
}
