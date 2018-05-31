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
    public partial class DangNhapGUI : Form
    {
        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            MainGUI main = new MainGUI();
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
