using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    }
}
