create database DA2_CHAM_CONG_NHAN_VIEN
go

use DA2_CHAM_CONG_NHAN_VIEN
go
create table dbo.ATTENDANCE
(
	id bigint NOT nULL,
	Name nvarchar(50) NOT nULL,
	Phone nvarchar(14) nOT Null,
	Email nvarchar(50) NOT Null,
	Base bigint Not null,
	Jan int,
	Jan_act int,
	Jan_Sal bigint,
	Feb int,
	Feb_act int,
	Feb_Sal bigint,
	Mar int,
	Mar_act int,
	Mar_Sal bigint,
	Apr int,
	Apr_act int,
	Apr_Sal bigint,
	May int,
	May_act int,
	May_Sal bigint,
	Jun int,
	Jun_act int,
	Jun_Sal bigint,
	Jul int,
	Jul_act int,
	Jul_Sal int,
	Aug int,
	Aug_act int,
	Aug_Sal bigint,
	Sep int,
	Sep_act int,
	Sep_Sal bigint,
	Octo int,
	Oct_act int,
	Oct_Sal bigint,
	Nov int,
	Nov_act int,
	Nov_Sal bigint,
	Dece int,
	Dec_act int,
	Dec_Sal bigint,
)
create table dbo.LATE
(
	id bigint,
	name nvarchar(50),
	Late_Jan int,
	Late_Feb int,
	Late_Mar int,
	Late_Apr int,
	Late_May int,
	Late_Jun int,
	Late_Jul int,
	Late_Aug int,
	Late_Sep int,
	Late_Oct int,
	Late_Nov int,
	Late_Dec int,
)
insert into CHAM_CONG_TINH_LUONG values (123456, 'NGUYEN THANH DAT', '0978479721', 'Dat.NguyenThanh2@vn.bosch.com', 14000000);
go
