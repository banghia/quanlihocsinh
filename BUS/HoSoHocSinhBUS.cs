using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTL;
using DTO;
using System.Data;

namespace BUS
{
    public class HoSoHocSinhBUS
    {
        HoSoHocSinhDTL hshsDTL = new HoSoHocSinhDTL();

        public DataTable All()
        {
            return hshsDTL.All();
        }

        public HoSoHocSinh Get(string maHocSinh)
        {
            DataTable dt = hshsDTL.Get(maHocSinh);
            HoSoHocSinh hshs = new HoSoHocSinh(dt.Rows[0]);
            return hshs;
        }

        public bool Insert(HoSoHocSinh hshs)
        {
            return hshsDTL.Insert(hshs) > 0;
        }

        public bool Update(HoSoHocSinh hshs)
        {
            return hshsDTL.Update(hshs) > 0;
        }

        public bool Delete(string hshs)
        {
            return hshsDTL.Delete(hshs) > 0;
        }

        public bool Exist(string maHocSinh)
        {
            DataTable dt = hshsDTL.Get(maHocSinh);
            return dt.Rows.Count > 0;
        }
    }
}
