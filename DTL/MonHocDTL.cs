using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DTL
{
    public class MonHocDTL
    {
        CSDL csdl = new CSDL();

        //Trả về tất cả dữ liệu trong bảng MonHoc.
        public DataTable All() {
            string query = "select * from MonHoc";
            SqlCommand cmd = new SqlCommand(query);
            return csdl.ExecuteQuery(cmd);
        }

        //Trả về dữ liệu trong bảng MonHoc theo mã môn học.
        public DataTable Get(string maMonHoc) {
            string query = "select * from MonHoc where MaMon = @MaMonHoc";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
            return csdl.ExecuteQuery(cmd);
        }

        public DataTable Search(string maMonHoc)
        {
            string query = "select * from MonHoc where MaMon = @MaMonHoc";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
            return csdl.ExecuteQuery(cmd);
        }

        public int Insert(MonHoc mh) {
            string query = "insert into MonHoc values(@MaMonHoc, @TenMonHoc, @SoTiet)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaMonHoc", mh.MaMon);
            cmd.Parameters.AddWithValue("@TenMonHoc", mh.TenMon);
            cmd.Parameters.AddWithValue("@SoTiet", mh.SoTiet);
            return csdl.ExecuteNonQuery(cmd);
        }

        public int Update(MonHoc mh) {
            string query = "update MonHoc set TenMon = @TenMonHoc, SoTiet= @SoTiet where MaMon= @MaMonHoc";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaMonHoc", mh.MaMon);
            cmd.Parameters.AddWithValue("@TenMonHoc", mh.TenMon);
            cmd.Parameters.AddWithValue("@SoTiet", mh.SoTiet);
            return csdl.ExecuteNonQuery(cmd);   
        }

        public int Delete(string maMonHoc)
        {
            string query = "delete from MonHoc where MaMon = @MaMonHoc";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
            return csdl.ExecuteNonQuery(cmd);
        }
    }
}
