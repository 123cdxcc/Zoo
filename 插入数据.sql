--插入动物--
INSERT INTO Animal(name, species, birth, sex, [state]) values('王八苏', '乌龟', '2000-1-1', '雌', '健康')
INSERT INTO Animal(name, species, birth, sex, [state]) values('王八刘', '乌龟', '2000-1-2', '雌', '健康')
INSERT INTO Animal(name, species, birth, sex, [state]) values('王八刘', '乌龟', '2000-1-3', '雌', '健康')
GO

--插入食物--
INSERT INTO Food(name, total, birth, expirationDate) values('白菜苏', 100, '2000-2-2', '2021-2-2')
INSERT INTO Food(name, total, birth, expirationDate) values('白菜刘', 100, '2000-2-2', '2021-2-2')
INSERT INTO Food(name, total, birth, expirationDate) values('白菜刘', 100, '2000-2-2', '2021-2-2')

--插入部门--
INSERT INTO Department(name, [address], telephone) values('饲养部', '希曼岛', '15211556262')
INSERT INTO Department(name, [address], telephone) values('采购部', '王八岛', '15211556262')

--插入职工--
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('小鸡王', '男', '老板', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('小鸡刘', '男', '员工', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('小鸡张', '男', '员工', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('小鸡苏', '男', '员工', '2000-1-1', 1000, '123456', 1)


INSERT INTO Food(name, total, birth, expirationDate) values('蓝莓', 100, '2000-1-1', '2001-1-1')
/*
CREATE TABLE Food(
	id int primary key IDENTITY(4000000,1),
	name nvarchar(20) not null,
	total float default 0.0,
	birth datetime,
	expirationDate datetime,
)
*/