using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DTL;

namespace BUS
{
    public class CanBoGiaoVienBUS
    {
        CanBoGiaoVienDTL canBoGiaoVienDTL = new CanBoGiaoVienDTL();

        public DataTable All()
        {
            return canBoGiaoVienDTL.All();
        }

        public CanBoGiaoVien Get(string maCanBoGiaoVien)
        {
            DataTable dt = canBoGiaoVienDTL.Get(maCanBoGiaoVien);
            CanBoGiaoVien canBoGiaoVien = new CanBoGiaoVien(dt.Rows[0]);
            return canBoGiaoVien;
        }

        public bool Insert(CanBoGiaoVien CBGV)
        {
            return canBoGiaoVienDTL.Insert(CBGV) > 0;
        }

        public bool Update(CanBoGiaoVien CBGV)
        {
            return canBoGiaoVienDTL.Update(CBGV) > 0;
        }

        public bool Delete(CanBoGiaoVien CBGV)
        {
            return canBoGiaoVienDTL.Delete(CBGV) > 0;
        }

        public bool Exist(string maCanBoGiaoVien)
        {
            DataTable dt = canBoGiaoVienDTL.Get(maCanBoGiaoVien);
            return dt.Rows.Count > 0;
        }
    }
}
