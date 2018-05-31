using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DTL
{
    public class LopDTL
    {
        CSDL csdl = new CSDL();
        
        // Trả về tất cả dl trong bảng Lop
        public DataTable All()
        {
            string query = "select MaLop, TenLop, NienKhoa, SiSo, HoTen as GiaoVienChuNhiem from Lop inner join CanBoGiaoVien on Lop.GiaoVienChuNhiem = CanBoGiaoVien.MaCanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(query);
            return csdl.ExecuteQuery(cmd);
        }

        public DataTable Get(string maLop)
        {
            string query = "select * from Lop where MaLop = @MaLop";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            return csdl.ExecuteQuery(cmd);
        }

        public int Insert(Lop lop)
        {
            string query = "insert into Lop values(@MaLop, @TenLop, @NienKhoa, @SiSo, @GiaoVienChuNhiem)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
            cmd.Parameters.AddWithValue("@NienKhoa", lop.NienKhoa);
            cmd.Parameters.AddWithValue("@SiSo", lop.SiSo);
            cmd.Parameters.AddWithValue("@GiaoVienChuNhiem", lop.GiaoVienChuNhiem);
            return csdl.ExecuteNonQuery(cmd);
        }

        public int Update(Lop lop)
        {
            string query = " update Lop set TenLop= @TenLop, NienKhoa= @NienKhoa, SiSo= @SiSo, GiaoVienChuNhiem = @GiaoVienChuNhiem where MaLop= @MaLop";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);
            cmd.Parameters.AddWithValue("@NienKhoa", lop.NienKhoa);
            cmd.Parameters.AddWithValue("@SiSo", lop.SiSo);
            cmd.Parameters.AddWithValue("@GiaoVienChuNhiem", lop.GiaoVienChuNhiem);
            cmd.Parameters.AddWithValue("MaLop", lop.MaLop);
            return csdl.ExecuteNonQuery(cmd);
        }

        public int Delete(string maLop)
        {
            string query = " delete from Lop where MaLop = @MaLop";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            return csdl.ExecuteNonQuery(cmd);
        }

    }
}
