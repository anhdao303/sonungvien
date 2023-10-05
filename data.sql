use master
go
if exists (select * from sys.databases where name = 'SonUngVien')
begin
	drop database SonUngVien
end
go

create database SonUngVien
go
use SonUngVien
go
create table Menu
(
	id int not null IDENTITY(1,1) PRIMARY KEY,
	[name] nvarchar (50),
	link varchar(MAX),
	meta varchar(MAX),
	hide bit,
	[order] int,
	datebegin datetime
)

create table Logo
(
	id int not null IDENTITY (1,1) PRIMARY KEY,
	[name] nvarchar (50),
	[image] varchar (MAX),
	link varchar(MAX),
	meta varchar(MAX),
	hide bit,
	[order] int,
	datebegin datetime
)

create table Footer
( 
	id int not null IDENTITY (1,1) PRIMARY KEY,
	[name] nvarchar(50),
	description ntext,
	link varchar(MAX),
	meta varchar(MAX),
	hide bit,
	[order] int,
	datebegin datetime
)

create table Banner
(
	id int not null IDENTITY (1,1) PRIMARY KEY,
	[name] nvarchar(50),
	[image] varchar (MAX),
	[message] varchar(MAX),
	description ntext,
	link varchar(MAX),
	meta varchar(MAX),
	hide bit,
	[order] int,
	datebegin datetime
)

create table Category
( 
	id int not null IDENTITY(1,1) PRIMARY KEY,
	[name] nvarchar(50),
	[image] varchar(MAX),
	numJob int,
	link varchar(MAX),
	meta varchar(MAX),
	hide bit,
	[order] int,
	datebegin datetime
)

create table Product
(
	id int not null IDENTITY(1,1) PRIMARY KEY,
	[name] nvarchar(50),
	price float,
	[description] nvarchar(MAX),
	[image] varchar(MAX),
	meta varchar(MAX),
	link varchar(MAX),
	hide bit,
	[order] int,
	datebegin datetime,
	categoryId int
)