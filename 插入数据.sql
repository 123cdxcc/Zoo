--���붯��--
INSERT INTO Animal(name, species, birth, sex, [state]) values('������', '�ڹ�', '2000-1-1', '��', '����')
INSERT INTO Animal(name, species, birth, sex, [state]) values('������', '�ڹ�', '2000-1-2', '��', '����')
INSERT INTO Animal(name, species, birth, sex, [state]) values('������', '�ڹ�', '2000-1-3', '��', '����')
GO

--����ʳ��--
INSERT INTO Food(name, total, birth, expirationDate) values('�ײ���', 100, '2000-2-2', '2021-2-2')
INSERT INTO Food(name, total, birth, expirationDate) values('�ײ���', 100, '2000-2-2', '2021-2-2')
INSERT INTO Food(name, total, birth, expirationDate) values('�ײ���', 100, '2000-2-2', '2021-2-2')

--���벿��--
INSERT INTO Department(name, [address], telephone) values('������', 'ϣ����', '15211556262')
INSERT INTO Department(name, [address], telephone) values('�ɹ���', '���˵�', '15211556262')

--����ְ��--
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('С����', '��', '�ϰ�', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('С����', '��', 'Ա��', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('С����', '��', 'Ա��', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('С����', '��', 'Ա��', '2000-1-1', 1000, '123456', 1)
/*
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

*/