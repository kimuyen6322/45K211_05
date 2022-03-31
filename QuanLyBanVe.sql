use NhaxeKhanhTruyen
go
--TaiKhoan
Create table TaiKhoan
(
TenTK varchar (50),
MatKhau varchar (10),
primary key (TenTK)
)
--Xe
create table Xe
(IDXe nvarchar(50),
LoaiXe nvarchar(10),
SoLuongGhe int,
TenTaiXe nvarchar(50),
SoDienThoai varchar(10),
BienSo nvarchar(10),
primary key (IDXe)
)
go
--Lịch trình
create table LichTrinh
(IDLichTrinh nvarchar(50),
 ThoiGianDi datetime,
 ThoiGianDen datetime,
 NoiXuatPhat nvarchar(50),
 NoiDen nvarchar(50),
 primary key(IDLichTrinh)
)
go
--Vé 
create table Ve
(IDVe nvarchar(50),
 LoaiVe nvarchar(10),
 IDXe nvarchar(50),
 IDLichTrinh nvarchar(50),
 GiaVe float,
 TinhTrangVe nvarchar(50),
 primary key(IDVe,IDXe),
 foreign key (IDLichTrinh) references LichTrinh,
 foreign key (IDXe) references Xe
)
go
--Donhang
create table DonHang (IDDonHang nvarchar(50), 
					IDVe nvarchar(50),
					IDXe nvarchar(50),
					IDLichTrinh nvarchar(50),
					TenKH nvarchar(50),
					SDT nvarchar(10),
					ThoiGianDon date,
					DiemDon nvarchar(50),
					DiemTra nvarchar(50),
					TongTien int,
					TinhTrang nvarchar(50),
					primary key(IDDonHang),
					foreign key (IDVe) references Ve,
					foreign key (IDLichTrinh) references LichTrinh,
					foreign key (IDXe) references Xe
					)
