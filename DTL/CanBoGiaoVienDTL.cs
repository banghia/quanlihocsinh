using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DTL
{
    public class CanBoGiaoVienDTL
    {
        CSDL csdl = new CSDL();
        // trả về dữ liệu trong 1 bảng
        public DataTable All()
        {
            string que = "select *from CanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(que);
            return csdl.ExecuteQuery(cmd);
        }

        public DataTable Get(string maCanBoGiaoVien)
        {
            string que = "select * from CanBoGiaoVien where MaCanBoGiaoVien = @MaCanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", maCanBoGiaoVien);
            return csdl.ExecuteQuery(cmd);
        }

        public int Insert(CanBoGiaoVien canBoGiaoVien)
        {
            string que = "insert into CanBoGiaoVien values(@MaCanBoGiaoVien, @HoTen, @DiaChi, @SoDienThoai, @TaiKhoan, @MatKhau, @LoaitaiKhoan)";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", canBoGiaoVien.MaCanBoGiaoVien);
            cmd.Parameters.AddWithValue("@HoTen", canBoGiaoVien.HoTen);
            cmd.Parameters.AddWithValue("@DiaChi", canBoGiaoVien.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", canBoGiaoVien.SoDienThoai);
            cmd.Parameters.AddWithValue("@TaiKhoan", canBoGiaoVien.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", canBoGiaoVien.MatKhau);
            cmd.Parameters.AddWithValue("@LoaiTaiKhoan", canBoGiaoVien.LoaiTaiKhoan);
            return csdl.ExecuteNonQuery(cmd);
        }

        public int Update(CanBoGiaoVien canBoGiaoVien)
        {
            string que = "update CanBoGiaoVien set HoTen= @HoTen, DiaChi= @DiaChi, SoDienThoai= @SoDienThoai, TaiKhoan= @TaiKhoan, MatKhau= @MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan where MaCanBoGiaoVien = @MaCanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", canBoGiaoVien.MaCanBoGiaoVien);
            cmd.Parameters.AddWithValue("@HoTen", canBoGiaoVien.HoTen);
            cmd.Parameters.AddWithValue("@DiaChi", canBoGiaoVien.DiaChi);
            cmd.Parameters.AddWithValue("@SoDienThoai", canBoGiaoVien.SoDienThoai);
            cmd.Parameters.AddWithValue("@TaiKhoan", canBoGiaoVien.TaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", canBoGiaoVien.MatKhau);
            cmd.Parameters.AddWithValue("@LoaiTaiKhoan", canBoGiaoVien.LoaiTaiKhoan);
            return csdl.ExecuteNonQuery(cmd);
        }

        public int Delete(CanBoGiaoVien canBoGiaoVien)
        {
            string que = "delete from CanBoGiaoVien where MaCanBoGiaoVien = @MaCanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(que);
            cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", canBoGiaoVien.MaCanBoGiaoVien);
            return csdl.ExecuteNonQuery(cmd);
        }
    }
}
