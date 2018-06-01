using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTL;
using DTO;
using System.Data;

namespace BUS
{
    public class LopBUS
    {
        LopDTL lopDTL = new LopDTL();

        public DataTable All()
        {
            return lopDTL.All();
        }

        public Lop Get(string maLop)
        {
            DataTable dt = lopDTL.Get(maLop);
            Lop lop = new Lop(dt.Rows[0]);
            return lop;
        }

        public DataTable Search(string maLop)
        {
            if (String.IsNullOrEmpty(maLop)) {
                return All();
            }
            return lopDTL.Search(maLop);
        }

        public bool Insert(Lop lop)
        {
            return lopDTL.Insert(lop) > 0;
        }

        public bool Update(Lop lop)
        {
            return lopDTL.Update(lop) > 0;
        }

        public bool Delete(string maLop)
        {
            return lopDTL.Delete(maLop) > 0;
        }

        public bool Exist(string maLop)
        {
            DataTable dt = lopDTL.Get(maLop);
            return dt.Rows.Count > 0;
        }
    }
}
