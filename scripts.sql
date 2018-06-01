use master
go

create database QLHocSinh
go

use QLHocSinh
go

create Table CanBoGiaoVien(
	MaCanBoGiaoVien nvarchar(20) primary key,
	HoTen nvarchar(100),
	DiaChi nvarchar(100),
	SoDienThoai nvarchar(20),
	TaiKhoan nvarchar(50),
	MatKhau nvarchar(50),
	LoaiTaiKhoan nvarchar(20)
)
go

create Table MonHoc(
	MaMon nvarchar(20) primary key,
	TenMon nvarchar(100),
	SoTiet int
)
go

create Table Lop(
	MaLop nvarchar(20) primary key,
	TenLop nvarchar(100),
	NienKhoa nvarchar(50),
	SiSo int,
	GiaoVienChuNhiem nvarchar(20),
	constraint fk_Lop_CanBoGiaoVien foreign key(GiaoVienChuNhiem)
		references CanBoGiaoVien(MaCanBoGiaoVien) on update cascade on delete cascade
)
go

create Table HoSoHocSinh(
	MaHocSinh nvarchar(20) primary key,
	HoTen nvarchar(100),
	NgaySinh Date,
	GioiTinh nvarchar(20),
	DiaChi nvarchar(100),
	DiemVaoTruong float,
	HoTenBoMe nvarchar(100),
	SoDienThoai nvarchar(20),
	MaLop nvarchar(20),
	constraint fk_HoSoHocSinh_Lop foreign key(MaLop)
		references Lop(MaLop) on update cascade on delete cascade
)
go

create Table Diem(
	MaHocSinh nvarchar(20),
	MaMonHoc nvarchar(20),
	DiemTB_Ky1 float,
	DiemTB_Ky2 float,
	constraint fk_MaHocSinh_MaMonHoc primary key(MaHocSinh, MaMonHoc),
	constraint fk_Diem_HoSoHocSinh foreign key(MaHocSinh)
		references HoSoHocSinh(MaHocSinh) on update cascade on delete cascade,
	constraint fk_Diem_MonHoc foreign key(MaMonHoc)
		references MonHoc(MaMon) on update cascade on delete cascade
)
go

create Table PhanCongGiangDay(
	MaLop nvarchar(20),
	MaMon nvarchar(20),
	MaCanBoGiaoVien nvarchar(20),
	NgayPhanCong Date,
	constraint fk_MaLop_MaMon_MaCanBoGiaoVien primary key(MaLop, MaMon, MaCanBoGiaoVien),
	constraint fk_PhanCongGiangDay_Lop foreign key(MaLop)
		references Lop(MaLop) on update cascade on delete cascade,
	constraint fk_PhanCongGiangDay_MonHoc foreign key(MaMon)
		references MonHoc(MaMon) on update cascade on delete cascade,
	constraint fk_PhanCongGiangDay_CanBoGiaoVien foreign key(MaCanBoGiaoVien)
		references CanBoGiaoVien(MaCanBoGiaoVien)
)
go
create proc dsGiaoVienLop(@maLop nvarchar(20))
as
begin
	select PhanCongGiangDay.MaCanBoGiaoVien, CanBoGiaoVien.HoTen, MonHoc.TenMon, NgayPhanCong, CanBoGiaoVien.SoDienThoai
	from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien = CanBoGiaoVien.MaCanBoGiaoVien
	inner join MonHoc on MonHoc.MaMon = PhanCongGiangDay.MaMon
	where PhanCongGiangDay.MaLop = @maLop
end
go

insert into CanBoGiaoVien values('CB0001', 'Admin', 'Admin', '1111', 'admin', '123456', 'Admin')