using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DTL
{
    public class HoSoHocSinhDTL
    {
        CSDL csdl = new CSDL();

        // trả về dữ liệu trong 1 bảng
        public DataTable All()
        {
            string que = "select * from HoSoHocSinh";
            SqlCommand cmd = new SqlCommand(que);
            return csdl.ExecuteQuery(cmd);
        }

        public DataTable Get(string maHocSinh)
        {
            string que = "select * from HoSoHocSinh where MaHocSinh = @MaHocSinh";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
            return csdl.ExecuteQuery(cmd);
        }

        public int Insert(HoSoHocSinh hoSoHocSinh)
        {
            string que = "insert into HoSoHocSinh values(@MaHocSinh, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DiemVaoTruong, @HoTenBoMe, @SoDienThoai, @MaLop)";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaHocSinh", hoSoHocSinh.MaHocSinh);
            cmd.Parameters.AddWithValue("@HoTen", hoSoHocSinh.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", hoSoHocSinh.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", hoSoHocSinh.GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", hoSoHocSinh.DiaChi);
            cmd.Parameters.AddWithValue("@DiemVaoTruong", hoSoHocSinh.DiemVaoTruong);
            cmd.Parameters.AddWithValue("@HoTenBoMe", hoSoHocSinh.HoTenBoMe);
            cmd.Parameters.AddWithValue("@SoDienThoai", hoSoHocSinh.SoDienThoai);
            cmd.Parameters.AddWithValue("@MaLop", hoSoHocSinh.MaLop);
            return csdl.ExecuteNonQuery(cmd);
        }

        public int Update(HoSoHocSinh hoSoHocSinh)
        {
            string que = "update HoSoHocSinh set HoTen= @HoTen, NgaySinh= @NgaySinh, GioiTinh= @GioiTinh, DiaChi= @DiaChi, DiemVaoTruong= @DiemVaoTruong, HoTenBoMe = @HoTenBoMe, SoDienThoai = @SoDienThoai, MaLop = @MaLop where MaHocSinh = @MaHocSinh";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaHocSinh", hoSoHocSinh.MaHocSinh);
            cmd.Parameters.AddWithValue("@HoTen", hoSoHocSinh.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", hoSoHocSinh.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", hoSoHocSinh.GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", hoSoHocSinh.DiaChi);
            cmd.Parameters.AddWithValue("@DiemVaoTruong", hoSoHocSinh.DiemVaoTruong);
            cmd.Parameters.AddWithValue("@HoTenBoMe", hoSoHocSinh.HoTenBoMe);
            cmd.Parameters.AddWithValue("@SoDienThoai", hoSoHocSinh.SoDienThoai);
            cmd.Parameters.AddWithValue("@MaLop", hoSoHocSinh.MaLop);
            return csdl.ExecuteNonQuery(cmd);
        }

        public int Delete(string maHocSinh)
        {
            string que = "delete from HoSoHocSinh where MaHocSinh = @MaHocSinh";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
            return csdl.ExecuteNonQuery(cmd);
        }
    }
}
