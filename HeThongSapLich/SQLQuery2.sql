create database SapLich
go

use SapLich
go

create table giangVien
(
	maGiangVien varchar(10) primary key,
	ten nvarchar(100) not null,
	khoa nvarchar(100) not null default N'Công nghệ thông tin',
	gioiTinh nvarchar(10) not null default 'Nam',
	gmail varchar(100)
)
go

create table taiKhoan
(
	taiKhoan varchar(100) primary key,
	matKhau varchar(100) not null default '1',
	loaiTaiKhoan varchar(10) not null default 'GiangVien',
	maGiangVien varchar(10) references giangvien(maGiangVien)
)
go

create table hocKy
(
	maHocKy varchar(10) primary key,
	tenHocKy nvarchar(100) not null,
	thoiGianBatDau date not null,
	thoiGianKetThuc date not null
)
go

create table GacThi
(
	maGiangVien varchar(10) references giangVien(maGiangVien) primary key,
	soBuoiGac tinyint not null default 0,
	maHocKy varchar(10) references hocKy(maHocKy),
)
go

create table Mon
(
	maMon varchar(10) primary key,
	ten nvarchar(100) not null
)
go

create table Lop
(
	maLop varchar(10) primary key
)
go

create table LopHocPhan
(
	maLHP varchar(20) primary key,
	maLop varchar(10) references Lop(maLop),
	maMon varchar(10) references Mon(maMon),
	siSo tinyint not null default 0,
)
go

create table Phong
(
	maPhong varchar(10 ) primary key,
	sucChua tinyint not null default 10
)
go

create table LichThi
(
	maLichThi varchar(10) primary key,
	maPhong varchar(10) references Phong(maPhong),
	maGiangVien varchar(10) references GiangVien(maGiangVien),
	maLHP varchar(20) references LopHocPhan(maLHP),
	ngayThi date not null,
	caThi varchar(10) not null,
	maHocKy varchar(10) references HocKy(maHocKy)
)
go


INSERT INTO PHONG 
	VALUES ('C1.1', default), ('C1.2', default), ('C1.3', default), ('C1.4', default), ('C1.5', default),
		   ('C2.1', default), ('C2.2', default), ('C2.3', default), ('C2.4', default), ('C2.5', default),
		   ('C3.1', default), ('C3.2', default), ('C3.3', default), ('C3.4', default), ('C3.5', default),
		   ('C4.1', default), ('C4.2', default), ('C4.3', default), ('C4.4', default), ('C4.5', default),  
		   ('C5.1', default), ('C5.2', default), ('C5.3', default), ('C5.4', default), ('C5.5', default);
go

INSERT INTO GIANGVIEN (maGiangVien, ten, khoa)
	VALUES  ('1CNTT', N'Nguyễn Văn A', default),
			('2CNTT', N'Nguyễn Văn B', default),
			('3CNTT', N'Nguyễn Văn C', default),
			('4CNTT', N'Nguyễn Văn D', default),
			('5CNTT', N'Nguyễn Văn E', default),
			('6CNTT', N'Nguyễn Văn F', default)
go

INSERT INTO LOP
	VALUES ('KTPM0117'), ('KTPM0217'),
		   ('HTTT0117'), ('HTTT0217'),
		   ('KHMT0117'), ('KHMT0217')
go

INSERT INTO MON
	VALUES ('001', N'Phần mềm mã nguồn mở'), ('002' , N'Lập trình an toàn'),
		   ('003' , N'Lập trình Java 1'), ('004' , N'Kiến trúc phần mềm'),
		   ('005' , N'Ngôn ngữ mô hình hóa UML')
go

INSERT INTO LOPHOCPHAN
	VALUES ('010100091403', 'KTPM0217', '001', default), ('010100091402', 'KTPM0117', '001', default),
		   ('010100139202', 'HTTT0117', '002', default), ('010100139201', 'KHMT0217', '002', default),
		   ('010100091202', 'KHMT0117', '003', default), ('010100091201', 'HTTT0217', '003', default), 
		   ('010100138202', 'KTPM0217', '004', default), ('010100138201', 'KTPM0117', '004', default), 
		   ('010100214302', 'KHMT0217', '005', default), ('010100214301', 'KHMT0117', '005', default)
go

delete hocky
go
INSERT INTO HOCKY
	VALUES ('001', N'Học kỳ 1 (2018-2019)',  '09/09/2018', '01/16/2019')
go

select format (thoigianBatDau, 'dd-MM-yyyy') as date
from hocKy

--SELECT FORMAT (thoiGianBatDau, 'dd-MM-yy') as date
--from hocKy
--GO

--convert(varchar, @ngayLap, 103)

INSERT INTO LichThi (maLichThi, maPhong, maLHP, ngayThi, caThi, maHocKy)
	VALUES ('001','C1.1', '010100091403', '01/07/2019', 3, '001'), ('006','C1.2', '010100091402', '01/07/2019', 3, '001'),
		   ('002','C4.2', '010100139202', '01/04/2019', 1, '001'), ('007','C4.3', '010100139201', '01/04/2019', 1, '001'),
		   ('003','C4.5', '010100091202', '01/02/2019', 2, '001'), ('008','C4.4', '010100091201', '01/02/2019', 2, '001'),
		   ('004','C5.2', '010100138202', '12/26/2018', 1, '001'), ('009','C5.3', '010100138201', '12/26/2018', 1, '001'),
		   ('005','C3.3', '010100214302', '12/25/2018', 4, '001'), ('010','C3.4', '010100214301', '12/25/2018', 4, '001')
go

INSERT INTO taiKhoan 
	VALUES ('admin', default, 'admin', '1CNTT'), ('giangvien', default, 'giangvien', '2CNTT')
go

INSERT INTO GACTHI
	VALUES ('1CNTT', DEFAULT, '001'),
			('2CNTT', DEFAULT, '001'),
			('3CNTT', DEFAULT, '001'),
			('4CNTT', DEFAULT, '001'),
			('5CNTT', DEFAULT, '001'),
			('6CNTT', DEFAULT, '001')
GO

create proc USP_Login
@userName varchar(100), @password varchar(100)
as
	Select * from taikhoan where taiKhoan = @userName and matKhau = @password
go

select * from giangVien

alter table giangvien
add gioiTinh nvarchar(10) not null default 'Nam'

select * from gacthi
SELECT * FROM GIANGVIEN
select * from hocky
select * from LichThi