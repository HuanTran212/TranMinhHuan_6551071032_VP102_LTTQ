Create database DuLieu;

use DuLieu;

create table SinhVien(
	MaSinhVien nvarchar(10) primary key,
	TenSinhVien nText not null,
	DiemTrungBinh nvarchar(8) not null,
);

insert into SinhVien(MaSinhVien, TenSinhVien, DiemTrungBinh) values 
('SV001', N'Huan', 3.0),
('SV002', N'B', 3.2);
Go