using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhanCongGiangDay
    {
        public string MaLop { get; set; }
        public string MaMon { get; set; }
        public string MaCanBoGiaoVien { get; set; }
        public DateTime NgayPhanCong { get; set; }

        public PhanCongGiangDay() { }

        public PhanCongGiangDay(string MaLop, string MaMon, string MaCanBoGiaoVien, DateTime NgayPhanCong)
        {
            this.MaLop = MaLop;
            this.MaMon = MaMon;
            this.MaCanBoGiaoVien = MaCanBoGiaoVien;
            this.NgayPhanCong = NgayPhanCong;
        }
    }
}
