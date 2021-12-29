--²åÈë¶¯Îï--
INSERT INTO Animal(name, species, birth, sex, [state]) values('Íõ°ËËÕ', 'ÎÚ¹ê', '2000-1-1', '´Æ', '½¡¿µ')
INSERT INTO Animal(name, species, birth, sex, [state]) values('Íõ°ËÁõ', 'ÎÚ¹ê', '2000-1-2', '´Æ', '½¡¿µ')
INSERT INTO Animal(name, species, birth, sex, [state]) values('Íõ°ËÁõ', 'ÎÚ¹ê', '2000-1-3', '´Æ', '½¡¿µ')
GO

--²åÈëÊ³Îï--
INSERT INTO Food(name, total, birth, expirationDate) values('°×²ËËÕ', 100, '2000-2-2', '2021-2-2')
INSERT INTO Food(name, total, birth, expirationDate) values('°×²ËÁõ', 100, '2000-2-2', '2021-2-2')
INSERT INTO Food(name, total, birth, expirationDate) values('°×²ËÁõ', 100, '2000-2-2', '2021-2-2')

--²åÈë²¿ÃÅ--
INSERT INTO Department(name, [address], telephone) values('ËÇÑø²¿', 'Ï£Âüµº', '15211556262')
INSERT INTO Department(name, [address], telephone) values('²É¹º²¿', 'Íõ°Ëµº', '15211556262')

--²åÈëÖ°¹¤--
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('Ð¡¼¦Íõ', 'ÄÐ', 'ÀÏ°å', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('Ð¡¼¦Áõ', 'ÄÐ', 'Ô±¹¤', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('Ð¡¼¦ÕÅ', 'ÄÐ', 'Ô±¹¤', '2000-1-1', 1000, '123456', 1)
INSERT INTO Worker(name, sex, position, birth, wage, [password], did) values('Ð¡¼¦ËÕ', 'ÄÐ', 'Ô±¹¤', '2000-1-1', 1000, '123456', 1)
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