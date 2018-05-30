using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DTL;
using System.Data;

namespace BUS
{
    public class MonHocBUS
    {
        MonHocDTL monHocDTL = new MonHocDTL();

        public DataTable All() {
            return monHocDTL.All();
        }

        public MonHoc Get(string maMonHoc) {
            DataTable dt = monHocDTL.Get(maMonHoc);
            MonHoc monHoc = new MonHoc(dt.Rows[0]);
            return monHoc;
        }

        public bool Insert(MonHoc mh) {
            return monHocDTL.Insert(mh) > 0;
        }

        public bool Update(MonHoc mh) {
            return monHocDTL.Update(mh) > 0;
        }

        public bool Delete(string maMonHoc) {
            return monHocDTL.Delete(maMonHoc) > 0;
        }

        public bool Exist(string maMonHoc) {
            DataTable dt = monHocDTL.Get(maMonHoc);
            return dt.Rows.Count > 0;
        }
    }
}
