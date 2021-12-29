CREATE DATABASE ZooManagementSystem
GO

--����
CREATE TABLE Animal(
	id int primary key IDENTITY(1000000,1),
	name nvarchar(10) not null,
	species nvarchar(20),
	birth datetime,
	sex nvarchar(2),
	[state] nvarchar(5)
)
go
--ʳ��
CREATE TABLE Food(
	id int primary key IDENTITY(4000000,1),
	name nvarchar(20) not null,
	total float default 0.0,
	birth datetime,
	expirationDate datetime,
)
go
--������
CREATE TABLE Supplier(
	id int primary key IDENTITY(3000000,1),
	name nvarchar(20) not null
)
go
--����
CREATE TABLE Department(
	id int primary key IDENTITY(1,1),
	name nvarchar(20) not null,
	[address] nvarchar(20),
	telephone nvarchar(20),
)
go
--ְ��
CREATE TABLE Worker(
	id int primary key IDENTITY(2021000,1),
	name nvarchar(10) not null,
	sex nvarchar(2),
	position nvarchar(10),
	birth datetime check((YEAR(GETDATE()) - YEAR(birth)) >= 18),
	wage money,
	[password] nvarchar(20),
	did int,
	foreign key (did) references Department(id),
)
go
--Ͷʳ
CREATE TABLE Feed(
	aid int,
	wid int,
	fid int,
	[time] datetime,
	total float default 0.0,
	foreign key (aid) references Animal(id),
	foreign key (wid) references Worker(id),
	foreign key (fid) references Food(id),
)
go
--�ɹ�
CREATE TABLE Purchase(
	[sid] int,
	fid int,
	wid int,
	[time] datetime,
	cost money default 0.0,
	number float default 0.0,
	foreign key (wid) references Worker(id),
	foreign key (fid) references Food(id),
	foreign key ([sid]) references supplier(id)
)
go
--����
CREATE TABLE Care(
	aid int,
	wid int,
	startTime datetime not null,
	endTime datetime not null
)