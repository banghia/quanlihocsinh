using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class HoSoHocSinh
    {
        public string MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public float DiemVaoTruong { get; set; }
        public string HoTenBoMe { get; set; }
        public string SoDienThoai { get; set; }
        public string MaLop { get; set; }

        public HoSoHocSinh() { }

        public HoSoHocSinh(string MaHocSinh, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, float DiemVaoTruong, string HoTenBoMe, string SoDienThoai, string MaLop)
        {
            this.MaHocSinh = MaHocSinh;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.DiemVaoTruong = DiemVaoTruong;
            this.HoTenBoMe = HoTenBoMe;
            this.SoDienThoai = SoDienThoai;
            this.MaLop = MaLop;

        }

        public HoSoHocSinh(DataRow row)
        {
            this.MaHocSinh = row["MaHocSinh"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.DiemVaoTruong = float.Parse(row["DiemVaoTruong"].ToString());
            this.HoTenBoMe = row["HoTenBoMe"].ToString();
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.MaLop = row["MaLop"].ToString();
        }
    }
}
