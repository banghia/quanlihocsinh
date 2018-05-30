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

        public QuanLyLopGUI()
        {
            InitializeComponent();
        }

        private void QuanLyLopGUI_Load(object sender, EventArgs e)
        {
            dgvDSLop.DataSource = lopBus.All();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiểm tra thông tin không được để trống 
            if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtTenLop.Text)
                || string.IsNullOrEmpty(txtNienKhoa.Text) || string.IsNullOrEmpty(cmbGVCN.Text))
            {
                MessageBox.Show(" khong được để trống thông tin");
                return;
            }
            // kiểm tra mã lớp đã tồn tại hay chưa?
            if(lopBus.Exist(txtMaLop.Text))
            {
                MessageBox.Show(" Ma lop đã tồn tại");
                return;
            }

            // Lấy thông tin trên form  vào lop
            Lop lop = new Lop();
            lop.MaLop = txtMaLop.Text;
            lop.TenLop = txtTenLop.Text;
            lop.NienKhoa = txtNienKhoa.Text;
            lop.SiSo = (int)numSiSo.Value;
            lop.GiaoVienChuNhiem = cmbGVCN.Text;
            // kiểm tra môn hk có thất bại hay ko?
            if(!lopBus.Insert(lop))
            {
                MessageBox.Show(" Thêm môn học thành công");
                return;
            }

            // Tải lại dữ liệu
            QuanLyLopGUI_Load(sender, e);


        }
    }
}
