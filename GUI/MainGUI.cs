using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class MainGUI : Form
    {

        private CanBoGiaoVien user;

        public CanBoGiaoVien User
        {
            get { return user; }
            set { user = value; }
        }

        public MainGUI(CanBoGiaoVien user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMonHocGUI quanLiMonHoc = new QuanLyMonHocGUI();
            quanLiMonHoc.MdiParent = this;
            quanLiMonHoc.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLopGUI quanLiLop = new QuanLyLopGUI();
            quanLiLop.MdiParent = this;
            quanLiLop.Show();
        }

        private void quảnLýHồSơHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHoSoHocSinh quanLyHoSoHS = new QuanLyHoSoHocSinh();
            quanLyHoSoHS.MdiParent = this;
            quanLyHoSoHS.Show();
        }

        private void quảnLýCánBộGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanBoGiaoVienGUI canBoGV = new CanBoGiaoVienGUI();
            canBoGV.MdiParent = this;
            canBoGV.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void phânCôngGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanCongGiangDayGUI phanCongGDay = new PhanCongGiangDayGUI();
            phanCongGDay.MdiParent = this;
            phanCongGDay.Show();
        }

        private void lậpDanhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachHocSinh danhSachHS = new DanhSachHocSinh();
            danhSachHS.MdiParent = this;
            danhSachHS.Show();
        }

        private void lậpDanhSáchGiáoViênDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachGV1Lop danhSachGV1Lop = new DanhSachGV1Lop();
            danhSachGV1Lop.MdiParent = this;
            danhSachGV1Lop.Show();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            //Ẩn hiện các chức năng tùy vào tài khoản Admin hay giáo viên.
            tàiKhoảnToolStripMenuItem.Text = "Chào: " + user.HoTen;
            if (user.LoaiTaiKhoan.Equals("Admin"))
            {
                quảnLýĐiểmToolStripMenuItem1.Visible = false;
            }
            else {
                quảnLýCánBộGiáoViênToolStripMenuItem.Visible = false;
                quảnLýHồSơHọcSinhToolStripMenuItem.Visible = false;
                quảnLýLớpToolStripMenuItem.Visible = false;
                quảnLýMônHọcToolStripMenuItem.Visible = false;
                phânCôngGiảngDạyToolStripMenuItem.Visible = false;
                thốngKêBáoCáoToolStripMenuItem.Visible = false;
            }
        }

        private void MainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinGUI thongTin = new ThongTinGUI();
            thongTin.MdiParent = this;
            thongTin.Show();
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Đóng form con đang active.
            if (this.ActiveMdiChild != null) {
                this.ActiveMdiChild.Close();
            }
        }

        private void đóngTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Đóng tất cả form con.
            foreach(var child in this.MdiChildren){
                child.Close();
            }
        }
    }
}
