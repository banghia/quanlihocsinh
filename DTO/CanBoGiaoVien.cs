using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class CanBoGiaoVien
    {
        public string MaCanBoGiaoVien { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string LoaiTaiKhoan { get; set; }

        public CanBoGiaoVien() { }

        public CanBoGiaoVien(string MaCanBoGiaoVien, string HoTen, string SoDienThoai,
           string DiaChi, string TaiKhoan, string MatKhau, string LoaiTaiKhoan)
        {
            this.MaCanBoGiaoVien = MaCanBoGiaoVien;
            this.HoTen = HoTen;
            this.SoDienThoai = SoDienThoai;
            this.DiaChi = DiaChi;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.LoaiTaiKhoan = LoaiTaiKhoan;
        }

        public CanBoGiaoVien(DataRow row)
        {
            this.MaCanBoGiaoVien = row["MaCanBoGiaoVien"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.TaiKhoan = row["TaiKhoan"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.LoaiTaiKhoan = row["LoaiTaiKhoan"].ToString();
        }
    }
}
