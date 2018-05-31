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
            if (String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text)) {
                MessageBox.Show("Nhập tên tài khoản và mật khẩu.");
                return;
            }

            CanBoGiaoVien user = dangNhapBUS.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (user == null) {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.");
                return;
            }
            MainGUI main = new MainGUI(user);
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
