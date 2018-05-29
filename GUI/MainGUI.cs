using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
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
    }
}
