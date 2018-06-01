using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DTL
{
    public class PhanCongGiangDayDTL
    {
        CSDL csdl = new CSDL();

        public DataTable All()
        {
            string query = "select * from PhanCongGiangDay";
            SqlCommand cmd = new SqlCommand(query);
            return csdl.ExecuteQuery(cmd);
        }

        public DataTable Get(string maLop, string maMonHoc, string maGiaoVien)
        {
            string query = "select * from PhanCongGiangDay where MaMon = @MaMonHoc and MaLop = @MaLop and MaCanBoGiaoVien = @MaCanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", maGiaoVien);
            return csdl.ExecuteQuery(cmd);
        }

        public DataTable Search(string maLop, string maMonHoc, string maGiaoVien)
        {
            string query = "select * from PhanCongGiangDay";
            string tmp = " where ";
            if (!String.IsNullOrEmpty(maLop)) {
                query += tmp + " MaLop = @MaLop ";
                tmp = " and ";
            }
            if (!String.IsNullOrEmpty(maMonHoc))
            {
                query += tmp + " MaMon = @MaMonHoc ";
                tmp = " and ";
            }
            if (!String.IsNullOrEmpty(maGiaoVien))
            {
                query += tmp + " MaCanBoGiaoVien = @MaCanBoGiaoVien ";
            }
            SqlCommand cmd = new SqlCommand(query);
            if (!String.IsNullOrEmpty(maLop)) cmd.Parameters.AddWithValue("@MaLop", maLop);
            if (!String.IsNullOrEmpty(maMonHoc)) cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
            if (!String.IsNullOrEmpty(maGiaoVien)) cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", maGiaoVien);
            return csdl.ExecuteQuery(cmd);
        }

        public int Insert(PhanCongGiangDay pcgd)
        {
            string query = "insert into PhanCongGiangDay values(@MaLop, @MaMon, @MaCanBoGiaoVien, @NgayPhanCong)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaLop", pcgd.MaLop);
            cmd.Parameters.AddWithValue("@MaMon", pcgd.MaMon);
            cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", pcgd.MaCanBoGiaoVien);
            cmd.Parameters.AddWithValue("@NgayPhanCong", pcgd.NgayPhanCong);
            return csdl.ExecuteNonQuery(cmd);
        }

    }
}
