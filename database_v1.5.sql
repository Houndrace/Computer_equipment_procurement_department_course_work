CREATE DATABASE ОтделЗакупокКомпьютернойТехникиКолледжа;
GO
USE ОтделЗакупокКомпьютернойТехникиКолледжа;
GO
CREATE TABLE Должность(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Наименование NVARCHAR(50) NOT NULL,
);

CREATE TABLE ЭлектроннаяПочта(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    АдресПочты NVARCHAR(50) NOT NULL,
);

CREATE TABLE Телефон(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Номер NVARCHAR(20) NOT NULL,
);

CREATE TABLE Адрес(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    НазваниеАдреса NVARCHAR(100) NOT NULL,
);

CREATE TABLE ВидОплаты(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Вид NVARCHAR(50) NOT NULL,
);

CREATE TABLE ЕдиницаИзмерения(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Наименование NVARCHAR(50) NOT NULL,
);

CREATE TABLE Организация(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Наименование NVARCHAR(100) NOT NULL,
);

CREATE TABLE УровеньДоступа(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Название NVARCHAR(30) NOT NULL,
);

CREATE TABLE Сотрудник(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	КодДолжности INT NOT NULL,
	КодУровняДоступа INT NOT NULL,
	КодОрганизации INT NOT NULL,
	КодТелефона INT NOT NULL,
	КодЭлектроннойПочты INT,
    Логин NVARCHAR(50) NOT NULL,
    Пароль NVARCHAR(50) NOT NULL,
    Фамилия NVARCHAR(50) NOT NULL,
    Имя NVARCHAR(50) NOT NULL,
    Отчество NVARCHAR(50),

	FOREIGN KEY (КодДолжности) REFERENCES Должность(Код),
	FOREIGN KEY (КодУровняДоступа) REFERENCES УровеньДоступа(Код),
	FOREIGN KEY (КодТелефона) REFERENCES Телефон(Код),
	FOREIGN KEY (КодОрганизации) REFERENCES Организация(Код),
	FOREIGN KEY (КодЭлектроннойПочты) REFERENCES ЭлектроннаяПочта(Код)
);

CREATE TABLE Поставщик (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    КодТелефона INT NOT NULL,
	КодАдреса INT NOT NULL,
	КодЭлектроннойПочты INT,
	НаименованиеФирмы NVARCHAR(100) NOT NULL,
    

	FOREIGN KEY (КодТелефона) REFERENCES Телефон(Код),
	FOREIGN KEY (КодАдреса) REFERENCES Адрес(Код),
	FOREIGN KEY (КодЭлектроннойПочты) REFERENCES ЭлектроннаяПочта(Код)
);

CREATE TABLE Склад (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	КодТелефона INT NOT NULL,
	КодАдреса INT NOT NULL,
	Наименование NVARCHAR(100) NOT NULL,

	FOREIGN KEY (КодТелефона) REFERENCES Телефон(Код),
	FOREIGN KEY (КодАдреса) REFERENCES Адрес(Код)
);

CREATE TABLE Заказ (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	КодСотрудника INT NOT NULL,
	КодПоставщика INT NOT NULL,
	КодCклада INT NOT NULL,
	КодВидаОплаты INT NOT NULL,
    Номер NVARCHAR(50) NOT NULL,
	Дата DATE NOT NULL,

	FOREIGN KEY (КодСотрудника) REFERENCES Сотрудник(Код),
	FOREIGN KEY (КодПоставщика) REFERENCES Поставщик(Код),
	FOREIGN KEY (КодCклада) REFERENCES Склад(Код),
	FOREIGN KEY (КодВидаОплаты) REFERENCES ВидОплаты(Код)
);

CREATE TABLE Товар (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	КодЕденицыИзмерения INT NOT NULL,
	Название NVARCHAR(50) NOT NULL,
    Количество INT NOT NULL,
    Цена DECIMAL(10, 2) NOT NULL,

	FOREIGN KEY (КодЕденицыИзмерения) REFERENCES ЕдиницаИзмерения(Код)
);

CREATE TABLE ЗаказТовар (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    КодЗаказа INT NOT NULL,
	КодТовара INT NOT NULL,

	FOREIGN KEY (КодЗаказа) REFERENCES Заказ(Код),
	FOREIGN KEY (КодТовара) REFERENCES Товар(Код)
)