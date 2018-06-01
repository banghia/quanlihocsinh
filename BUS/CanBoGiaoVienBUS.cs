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

        public DataTable AllAdmin()
        {
            return canBoGiaoVienDTL.AllAdmin();
        }

        public DataTable AllGiaoVien()
        {
            return canBoGiaoVienDTL.AllGiaoVien();
        }

        public CanBoGiaoVien Get(string maCanBoGiaoVien)
        {
            DataTable dt = canBoGiaoVienDTL.Get(maCanBoGiaoVien);
            CanBoGiaoVien canBoGiaoVien = new CanBoGiaoVien(dt.Rows[0]);
            return canBoGiaoVien;
        }

        public DataTable Search(string maCanBoGiaoVien)
        {
            if (String.IsNullOrEmpty(maCanBoGiaoVien)) {
                return All();
            }
            return canBoGiaoVienDTL.Search(maCanBoGiaoVien);
        }

        public bool Insert(CanBoGiaoVien canBoGiaoVien)
        {
            return canBoGiaoVienDTL.Insert(canBoGiaoVien) > 0;
        }

        public bool Update(CanBoGiaoVien canBoGiaoVien)
        {
            return canBoGiaoVienDTL.Update(canBoGiaoVien) > 0;
        }

        public bool Delete(string maCanBoGiaoVien)
        {
            return canBoGiaoVienDTL.Delete(maCanBoGiaoVien) > 0;
        }

        public bool Exist(string maCanBoGiaoVien)
        {
            DataTable dt = canBoGiaoVienDTL.Get(maCanBoGiaoVien);
            return dt.Rows.Count > 0;
        }

        public bool ExistAccount(string taiKhoan)
        {
            DataTable dt = canBoGiaoVienDTL.GetAccount(taiKhoan);
            return dt.Rows.Count > 0;
        }
    }
}
