using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class PhanCongGiangDay
    {
        public string MaLop { get; set; }
        public string MaMon { get; set; }
        public string MaCanBoGiaoVien { get; set; }
        public DateTime NgayPhanCong { get; set; }

        public PhanCongGiangDay() { }

        public PhanCongGiangDay(string MaLop, string MaMon, string MaCanBoGiaoVien, DateTime NgayPhanCong) {
            this.MaLop = MaLop;
            this.MaMon = MaMon;
            this.MaCanBoGiaoVien = MaCanBoGiaoVien;
            this.NgayPhanCong = NgayPhanCong;
        }

        public PhanCongGiangDay(DataRow row) {
            this.MaLop = row["MaLop"].ToString();
            this.MaMon = row["MaMon"].ToString();
            this.MaCanBoGiaoVien = row["MaCanBoGiaoVien"].ToString();
            this.NgayPhanCong = (DateTime)row["NgayPhanCong"];
        }
    }
}
