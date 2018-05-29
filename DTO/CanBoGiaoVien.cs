using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CanBoGiaoVien
    {
        public string MaCanBoGiaoVien { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string LoaiTaiKhoan { get; set; }

        public CanBoGiaoVien() { }

        public CanBoGiaoVien(string MaCanBoGiaoVien, string HoTen, string SoDienThoai, string TaiKhoan, string MatKhau, string LoaiTaiKhoan)
        {
            this.MaCanBoGiaoVien = MaCanBoGiaoVien;
            this.HoTen = HoTen;
            this.SoDienThoai = SoDienThoai;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.LoaiTaiKhoan = LoaiTaiKhoan;
        }
    }
}
