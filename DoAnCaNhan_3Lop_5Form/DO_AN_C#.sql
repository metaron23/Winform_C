﻿INSERT INTO LOP (MaLop,TenLop,CVHT)
VALUES	('K19CDQ',N'CAO ĐẲNG QUẢN TRỊ MẠNG',N'LÊ VĂN TÁM'),
		('K19CDT',N'CAO ĐẲNG HỆ THỐNG THÔNG TIN',N'QUÁCH TUẤN NGỌC'),
		('K19HTT',N'HỆ THỐNG THÔNG TIN',N'ÔNG VĂN THÔNG'),
		('K19QTM',N'QUẢN TRỊ MẠNG',N'TRẦN MAI KHUÊ'),
		('K19TPM',N'CÔNG NGHỆ PHẦN MỀM',N'KIỀU MAI LÝ'),
		('K19CDM',N'CAO ĐẲNG CÔNG NGHỆ PHẦN MỀM',N'PHẠM VĂN ẤT');
INSERT INTO MONHOC (MaMH,TenMH,SoTC)
VALUES	('CSDL',N'CƠ SỞ DỮ LIỆU',3),
		('CTDL',N'CẤU TRÚC DỮ LIỆU',3),
		('TIDC',N'TIN ĐẠI CƯƠNG',3),
		('TIUD',N'TIN ỨNG DỤNG',3),
		('TORR',N'TOÁN RỜI RẠC',3);
INSERT INTO SINHVIEN (MaSV,TenSV,Phai,NgaySinh,DiaChi,DienThoai,MaLop)
VALUES	('SV01',N'PHAN TRUNG HIẾU','True','1994-06-12',N'22 ÔNG ÍCH KHIÊM - ĐÀ NẴNG','0917890078','K19TPM'),
		('SV02',N'DƯƠNG YẾN NGỌC','False','1994-09-10',N'190 PHAN THANH - ĐÀ NẴNG','','K19TPM'),
		('SV03',N'NGUYỄN KHƯƠNG TRUNG','True','1992-10-10',N'30 HUỲNH NGỌC HUỆ - ĐÀ NẴNG','0913245532','K19QTM'),
		('SV04',N'NGUYỄN NGỌC SÁU','True','1993-03-21',N'52 HOÀ KHÁNH NAM','','K19QTM'),
		('SV05',N'TRẦN THỊ NGỌC LAN','False','1994-01-01',N'THÔN 7 - ĐẠI LỘC - QUẢNG NAM','09072345318','K19QTM');
INSERT INTO DIEM (MASV, MAMH, DiemLan1,DiemLan2)
VALUES	('SV01','CSDL',9,8),
		('SV01','CTDL',4,6.5),
		('SV01','TIDC',8.5,5),
		('SV02','TORR',3,7.5),
		('SV03','CTDL',4,8.5),
		('SV03','TIUD',9.5,7.5),
		('SV03','TORR',6.5,6),
		('SV04','CSDL',9,8),
		('SV05','CTDL',8.5,9),
		('SV05','TORR',4,7.5);