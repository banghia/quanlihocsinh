using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTL;
using System.Data;
using DTO;

namespace BUS
{
    public class PhanCongGiangDayBUS
    {
        PhanCongGiangDayDTL pcgdDTL = new PhanCongGiangDayDTL();

        public DataTable All() {
            return pcgdDTL.All();
        }

        public DataTable Search(string maLop, string maMonHoc, string maGiaoVien)
        {
            return pcgdDTL.Search(maLop, maMonHoc, maGiaoVien);
        }

        public bool Insert(PhanCongGiangDay pcgd) {
            return pcgdDTL.Insert(pcgd) > 0;
        }

        public bool Exist(string maLop, string maMon, string maGiaoVien) { 
            DataTable dt = pcgdDTL.Get(maLop, maMon, maGiaoVien);
            return dt.Rows.Count > 0;
        }
    }
}
