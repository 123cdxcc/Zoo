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


INSERT INTO Food(name, total, birth, expirationDate) values('��ݮ', 100, '2000-1-1', '2001-1-1')
/*
CREATE TABLE Food(
	id int primary key IDENTITY(4000000,1),
	name nvarchar(20) not null,
	total float default 0.0,
	birth datetime,
	expirationDate datetime,
)
*/