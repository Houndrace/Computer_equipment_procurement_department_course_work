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

CREATE TABLE Статус(
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
	КодСтатуса INT NOT NULL,
	КодСотрудника INT NOT NULL,
	КодПоставщика INT NOT NULL,
	КодCклада INT NOT NULL,
	Оплачено BIT NOT NULL,
    Номер NVARCHAR(50) NOT NULL,
	Дата DATE NOT NULL,

	FOREIGN KEY (КодСотрудника) REFERENCES Сотрудник(Код),
	FOREIGN KEY (КодСтатуса) REFERENCES Статус(Код),
	FOREIGN KEY (КодПоставщика) REFERENCES Поставщик(Код),
	FOREIGN KEY (КодCклада) REFERENCES Склад(Код)
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
);

INSERT [dbo].[Адрес] ([Код], [НазваниеАдреса]) VALUES (1, N'ул. Спартака, 39, Тверь, Тверская обл., 170001')
INSERT [dbo].[Адрес] ([Код], [НазваниеАдреса]) VALUES (2, N'ул. Спартака, 42-б, 3 этаж, Тверь, Тверская обл., 170001')
SET IDENTITY_INSERT [dbo].[Адрес] OFF
GO
SET IDENTITY_INSERT [dbo].[Должность] ON 

INSERT [dbo].[Должность] ([Код], [Наименование]) VALUES (1, N'Менеджер')
INSERT [dbo].[Должность] ([Код], [Наименование]) VALUES (2, N'Заведующий отделом')
SET IDENTITY_INSERT [dbo].[Должность] OFF
GO
SET IDENTITY_INSERT [dbo].[ЕдиницаИзмерения] ON 

INSERT [dbo].[ЕдиницаИзмерения] ([Код], [Наименование]) VALUES (1, N'шт.')
SET IDENTITY_INSERT [dbo].[ЕдиницаИзмерения] OFF
GO
SET IDENTITY_INSERT [dbo].[Заказ] ON 

INSERT [dbo].[Заказ] ([Код], [КодСтатуса], [КодСотрудника], [КодПоставщика], [КодCклада], [Оплачено], [Номер], [Дата]) VALUES (1, 1, 1, 1, 1, 0, N'000001', CAST(N'2023-03-04' AS Date))
SET IDENTITY_INSERT [dbo].[Заказ] OFF
GO
SET IDENTITY_INSERT [dbo].[ЗаказТовар] ON 

INSERT [dbo].[ЗаказТовар] ([Код], [КодЗаказа], [КодТовара]) VALUES (1, 1, 1)
INSERT [dbo].[ЗаказТовар] ([Код], [КодЗаказа], [КодТовара]) VALUES (2, 1, 2)
SET IDENTITY_INSERT [dbo].[ЗаказТовар] OFF
GO
SET IDENTITY_INSERT [dbo].[Организация] ON 

INSERT [dbo].[Организация] ([Код], [Наименование]) VALUES (1, N'Колледж')
SET IDENTITY_INSERT [dbo].[Организация] OFF
GO
SET IDENTITY_INSERT [dbo].[Поставщик] ON 

INSERT [dbo].[Поставщик] ([Код], [КодТелефона], [КодАдреса], [КодЭлектроннойПочты], [НаименованиеФирмы]) VALUES (1, 1, 2, 2, N'ТЕХТВЕРЬ')
SET IDENTITY_INSERT [dbo].[Поставщик] OFF
GO
SET IDENTITY_INSERT [dbo].[Склад] ON 

INSERT [dbo].[Склад] ([Код], [КодТелефона], [КодАдреса], [Наименование]) VALUES (1, 3, 1, N'Компьютерный склад')
SET IDENTITY_INSERT [dbo].[Склад] OFF
GO
SET IDENTITY_INSERT [dbo].[Сотрудник] ON 

INSERT [dbo].[Сотрудник] ([Код], [КодДолжности], [КодУровняДоступа], [КодОрганизации], [КодТелефона], [КодЭлектроннойПочты], [Логин], [Пароль], [Фамилия], [Имя], [Отчество]) VALUES (1, 1, 2, 1, 4, 3, N'manager', N'truemanager', N'Иванов', N'Сергей', N'Федорович')
SET IDENTITY_INSERT [dbo].[Сотрудник] OFF
GO
SET IDENTITY_INSERT [dbo].[Статус] ON 

INSERT [dbo].[Статус] ([Код], [Название]) VALUES (1, N'На согласовании')
INSERT [dbo].[Статус] ([Код], [Название]) VALUES (2, N'Согласован')
INSERT [dbo].[Статус] ([Код], [Название]) VALUES (3, N'Подтвержден')
INSERT [dbo].[Статус] ([Код], [Название]) VALUES (4, N'Закрыт')
SET IDENTITY_INSERT [dbo].[Статус] OFF
GO
SET IDENTITY_INSERT [dbo].[Телефон] ON 

INSERT [dbo].[Телефон] ([Код], [Номер]) VALUES (1, N'84822750985')
INSERT [dbo].[Телефон] ([Код], [Номер]) VALUES (2, N'84822422601')
INSERT [dbo].[Телефон] ([Код], [Номер]) VALUES (3, N'84824352623')
INSERT [dbo].[Телефон] ([Код], [Номер]) VALUES (4, N'89201451352')
SET IDENTITY_INSERT [dbo].[Телефон] OFF
GO
SET IDENTITY_INSERT [dbo].[Товар] ON 

INSERT [dbo].[Товар] ([Код], [КодЕденицыИзмерения], [Название], [Количество], [Цена]) VALUES (1, 1, N'Компьютерная мышь', 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Товар] ([Код], [КодЕденицыИзмерения], [Название], [Количество], [Цена]) VALUES (2, 1, N'Клавиатура', 2, CAST(600.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Товар] OFF
GO
SET IDENTITY_INSERT [dbo].[УровеньДоступа] ON 

INSERT [dbo].[УровеньДоступа] ([Код], [Название]) VALUES (1, N'Администратор')
INSERT [dbo].[УровеньДоступа] ([Код], [Название]) VALUES (2, N'Пользователь')
SET IDENTITY_INSERT [dbo].[УровеньДоступа] OFF
GO
SET IDENTITY_INSERT [dbo].[ЭлектроннаяПочта] ON 

INSERT [dbo].[ЭлектроннаяПочта] ([Код], [АдресПочты]) VALUES (1, N'college@gmail.com')
INSERT [dbo].[ЭлектроннаяПочта] ([Код], [АдресПочты]) VALUES (2, N'supplier@gmail.com')
INSERT [dbo].[ЭлектроннаяПочта] ([Код], [АдресПочты]) VALUES (3, N'employee@gmail.com')
SET IDENTITY_INSERT [dbo].[ЭлектроннаяПочта] OFF