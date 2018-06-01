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
    public partial class DangNhapGUI : Form
    {
        DangNhapBUS dangNhapBUS = new DangNhapBUS();

        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra tài khoản hoặc mật khẩu để trống.
            if (String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text)) {
                MessageBox.Show("Nhập tên tài khoản và mật khẩu.");
                txtTaiKhoan.Focus();
                return;
            }
            //Lấy ra CanBoGiaoVien theo tên tài khoản và mật khẩu. nêu == null là sai tên tài khoản hoặc mật khẩu.
            CanBoGiaoVien user = dangNhapBUS.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (user == null) {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.");
                txtTaiKhoan.Focus();
                return;
            }
            //Xóa dữ liệu.
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            //Mở form chính và ản form đăng nhâp.
            MainGUI main = new MainGUI(user);
            this.Hide();
            main.ShowDialog();
            //Sau khi đóng form main thì mở lại form đăng nhập.
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
