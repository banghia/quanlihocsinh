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
    public partial class QuanLyLopGUI : Form
    {

        LopBUS lopBus = new LopBUS();
        CanBoGiaoVienBUS cbgvBUS = new CanBoGiaoVienBUS();

        public QuanLyLopGUI()
        {
            InitializeComponent();
        }

        private void QuanLyLopGUI_Load(object sender, EventArgs e)
        {
            dgvDSLop.DataSource = lopBus.All();
            cmbGVCN.DataSource = cbgvBUS.AllGiaoVien();
            cmbGVCN.DisplayMember = "HoTen";
            cmbGVCN.ValueMember = "MaCanBoGiaoVien";
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
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtNienKhoa.Clear();
            numSiSo.Value = numSiSo.Minimum;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiểm tra thông tin không được để trống 
            if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtTenLop.Text)
                || string.IsNullOrEmpty(txtNienKhoa.Text) || string.IsNullOrEmpty(cmbGVCN.Text) || cmbGVCN.SelectedIndex == -1)
            {
                MessageBox.Show("Không được để trống thông tin");
                return;
            }
            // kiểm tra mã lớp đã tồn tại hay chưa?
            if(lopBus.Exist(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp đã tồn tại");
                return;
            }

            // Lấy thông tin trên form  vào lop
            Lop lop = new Lop();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.NienKhoa = txtNienKhoa.Text;
            lop.SiSo = (int)numSiSo.Value;
            lop.GiaoVienChuNhiem = cmbGVCN.SelectedValue.ToString();
            // kiểm tra môn hk có thất bại hay ko?
            if(!lopBus.Insert(lop))
            {
                MessageBox.Show(" Thêm môn học thành công");
                return;
            }

            // Tải lại dữ liệu
            QuanLyLopGUI_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaLop.Text)) {
                MessageBox.Show("Mã lớp không được để trống.");
                return;
            }
            string maLop = txtMaLop.Text;
            if (!lopBus.Exist(maLop)) {
                MessageBox.Show("Mã lớp không tồn tại.");
                return;
            }
            Lop lop = lopBus.Get(maLop);
            txtTenLop.Text = lop.TenLop;
            txtNienKhoa.Text = lop.NienKhoa;
            numSiSo.Value = lop.SiSo;
            cmbGVCN.SelectedValue = lop.GiaoVienChuNhiem;
            txtMaLop.Enabled = false;
            BatTatLHTSX();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống.");
                return;
            }
            string maLop = txtMaLop.Text;
            if (!lopBus.Exist(maLop))
            {
                MessageBox.Show("Mã lớp không tồn tại.");
                return;
            }
            //Xác nhận có muốn xóa hay không.
            DialogResult result = MessageBox.Show("Xác nhận xóa", "Bạn có chắc chắn muốn xóa lớp này không?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            if (!lopBus.Delete(maLop)) {
                MessageBox.Show("Xóa lớp không thành công.");
                return;
            }
            QuanLyLopGUI_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaLop.Enabled = true;
            BatTatLHTSX();
            XoaDuLieuForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // kiểm tra thông tin không được để trống 
            if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtTenLop.Text)
                || string.IsNullOrEmpty(txtNienKhoa.Text) || string.IsNullOrEmpty(cmbGVCN.Text) || cmbGVCN.SelectedIndex == -1)
            {
                MessageBox.Show("Không được để trống thông tin");
                return;
            }
            Lop lop = new Lop();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.NienKhoa = txtNienKhoa.Text;
            lop.SiSo = (int)numSiSo.Value;
            lop.GiaoVienChuNhiem = cmbGVCN.SelectedValue.ToString();
            if(!lopBus.Update(lop)){
                MessageBox.Show("Sửa thông tin lớp không thành công.");
                return;
            }
            btnHuy_Click(sender, e);
            QuanLyLopGUI_Load(sender, e);
        }
    }
}
