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
    public partial class QuanLyMonHocGUI : Form
    {
        MonHocBUS monHocBUS = new MonHocBUS();

        public QuanLyMonHocGUI()
        {
            InitializeComponent();
        }

        private void QuanLyMonHocGUI_Load(object sender, EventArgs e)
        {   
            //Tải dữ liệu lên bảng.
            dgvMonHoc.DataSource = monHocBUS.All();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem thông tin có để trống không.
            if (String.IsNullOrEmpty(txtMaMonHoc.Text) || String.IsNullOrEmpty(txtTenMonHoc.Text)) {
                MessageBox.Show("Không được để trống thông tin.");
                return;
            }
            //Kiểm tra mã môn học đã tồn tại hay chưa.
            if (monHocBUS.Exist(txtMaMonHoc.Text)) {
                MessageBox.Show("Mã môn học đã tồn tại.");
                return;
            }
            //Lấy thông tin trên form vào môn học.
            MonHoc monHoc = new MonHoc();
            monHoc.MaMon = txtMaMonHoc.Text;
            monHoc.TenMon = txtTenMonHoc.Text;
            monHoc.SoTiet = (int)numSoTiet.Value;
            //Kiểm tra thêm môn học có thất bại không.
            if (!monHocBUS.Insert(monHoc)) {
                MessageBox.Show("Thêm môn học không thành công.");
                return;
            }
            //Tải lại dữ liệu.
            QuanLyMonHocGUI_Load(sender, e);
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
            numSoTiet.Value = numSoTiet.Minimum;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã môn học có để trống hay không
            if (String.IsNullOrEmpty(txtMaMonHoc.Text)) {
                MessageBox.Show("Mã môn học không được để trống.");
                return;
            }
            string maMonHoc = txtMaMonHoc.Text;
            //Kiểm tra môn học đã tồn tại chưa, nếu chưa đưa ra thông báo.
            if (!monHocBUS.Exist(maMonHoc)) {
                MessageBox.Show("Mã môn học không tồn tại.");
                return;
            }
            //Lấy dữ liệu môn học trong csdl rồi hiển thị lên form.
            MonHoc monHoc = monHocBUS.Get(maMonHoc);
            txtTenMonHoc.Text = monHoc.TenMon;
            numSoTiet.Value = monHoc.SoTiet;
            //Ẩn TextBox mã môn học và các nút tương ứng.
            txtMaMonHoc.Enabled = false;
            ToggleTSX();
        }

        private void ToggleTSX() {
            //Ẩn hiện nút Thêm sửa xóa.
            btnThem.Enabled = !btnThem.Enabled;
            btnSua.Enabled = !btnSua.Enabled;
            btnXoa.Enabled = !btnXoa.Enabled;
            //Ẩn hiện nú hủy lưu.
            btnHuy.Enabled = !btnHuy.Enabled;
            btnLuu.Enabled = !btnLuu.Enabled;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.Enabled = true;
            //Xóa dữ liệu ở TextBox mã môn học và tên môn học.
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
            ToggleTSX();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin có trống không.
            if (String.IsNullOrEmpty(txtTenMonHoc.Text)) {
                MessageBox.Show("Không được để trống thông tin.");
                return;
            }
            MonHoc monHoc = new MonHoc();
            monHoc.MaMon = txtMaMonHoc.Text;
            monHoc.TenMon = txtTenMonHoc.Text;
            monHoc.SoTiet = (int)numSoTiet.Value;
            //Kiểm tra xem sửa thành công hay không.
            if (!monHocBUS.Update(monHoc)) {
                MessageBox.Show("Sửa môn học không thành công.");
                return;
            }
            //Tải lại dữ liệu.
            QuanLyMonHocGUI_Load(sender, e);
            //Đưa trạng thái các nut và TextBox về ban đầu.
            btnHuy_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã môn học có để trống hay không.
            if (String.IsNullOrEmpty(txtMaMonHoc.Text))
            {
                MessageBox.Show("Mã môn học không được để trống.");
                return;
            }
            //Kiểm tra môn học đã tồn tại hay chưa.
            string maMonHoc = txtMaMonHoc.Text;
            if (!monHocBUS.Exist(maMonHoc))
            {
                MessageBox.Show("Mã môn học không tồn tại.");
                return;
            }
            //Hiển thị thông báo xác nhận xóa.
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận xóa",
                                    MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            //Kiểm tra xem xóa môn học có thành công hay không.
            if (!monHocBUS.Delete(maMonHoc)) {
                MessageBox.Show("Xóa môn học không thành công.");
                return;
            }
            QuanLyMonHocGUI_Load(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //Tìm kiếm theo mã môn học.
            dgvMonHoc.DataSource = monHocBUS.Search(txtTim.Text);
        }
    }
}
