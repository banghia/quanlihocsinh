using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DTL;
using System.Data;

namespace BUS
{
    public class DangNhapBUS
    {
        CanBoGiaoVienDTL cbgvDTL = new CanBoGiaoVienDTL();

        public CanBoGiaoVien DangNhap(string taiKhoan, string matKhau) {
            DataTable dt = cbgvDTL.GetAccount(taiKhoan, matKhau);
            if (dt.Rows.Count > 0) {
                CanBoGiaoVien cbgv = new CanBoGiaoVien(dt.Rows[0]);
                return cbgv;
            }
            return null;
        }
    }
}
