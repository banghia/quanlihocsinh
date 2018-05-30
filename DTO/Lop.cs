using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string NienKhoa { get; set; }
        public int SiSo { get; set; }
        public string GiaoVienChuNhiem { get; set; }

        public Lop() { }

        public Lop(string MaLop, string TenLop, string NienKhoa, int SiSo, string GiaoVienChuNhiem)
        {
            this.MaLop = MaLop;
            this.TenLop = TenLop;
            this.NienKhoa = NienKhoa;
            this.SiSo = SiSo;
            this.GiaoVienChuNhiem = GiaoVienChuNhiem;
        }

        public Lop(DataRow row)
        {
            this.MaLop = row["MaLop"].ToString();
            this.TenLop = row["TenLop"].ToString();
            this.NienKhoa = row["NienKhoa"].ToString();
            this.SiSo = Int32.Parse(row["SiSo"].ToString());
            this.GiaoVienChuNhiem = row["GiaoVienChuNhiem"].ToString();
        }

    }
}
