CREATE DATABASE ОтделЗакупокКомпьютернойТехникиКолледжа;
GO
USE ОтделЗакупокКомпьютернойТехникиКолледжа;
GO
CREATE TABLE Должность(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Название NVARCHAR(50) NOT NULL,
);
GO
CREATE TABLE ЭлектроннаяПочта(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    АдресПочты NVARCHAR(50) NOT NULL,
);
GO
CREATE TABLE Телефон(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Номер NVARCHAR(20) NOT NULL,
);
GO
CREATE TABLE Адрес(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Название NVARCHAR(100) NOT NULL,
);
GO
CREATE TABLE ЕдиницаИзмерения(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Название NVARCHAR(50) NOT NULL,
);
GO
CREATE TABLE Организация(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Название NVARCHAR(100) NOT NULL,
);
GO
CREATE TABLE УровеньДоступа(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Название NVARCHAR(30) NOT NULL,
);
GO
CREATE TABLE Статус(
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Название NVARCHAR(30) NOT NULL,
);
GO
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

	CONSTRAINT FK_Сотрудник_Должность FOREIGN KEY (КодДолжности) 
	REFERENCES Должность(Код),
	CONSTRAINT FK_Сотрудник_УровеньДоступа FOREIGN KEY (КодУровняДоступа) 
	REFERENCES УровеньДоступа(Код),
	CONSTRAINT FK_Сотрудник_Телефон FOREIGN KEY (КодТелефона) 
	REFERENCES Телефон(Код),
	CONSTRAINT FK_Сотрудник_Организация FOREIGN KEY (КодОрганизации) 
	REFERENCES Организация(Код),
	CONSTRAINT FK_Сотрудник_ЭлектроннаяПочта FOREIGN KEY (КодЭлектроннойПочты) 
	REFERENCES ЭлектроннаяПочта(Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE Поставщик (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    КодТелефона INT NOT NULL,
	КодАдреса INT NOT NULL,
	КодЭлектроннойПочты INT,
	НаименованиеФирмы NVARCHAR(100) NOT NULL,
    
	CONSTRAINT FK_Поставщик_Телефон FOREIGN KEY (КодТелефона) 
	REFERENCES Телефон(Код),
	CONSTRAINT FK_Поставщик_Адрес FOREIGN KEY (КодАдреса) 
	REFERENCES Адрес(Код),
	CONSTRAINT FK_Поставщик_ЭлектроннаяПочта FOREIGN KEY (КодЭлектроннойПочты) 
	REFERENCES ЭлектроннаяПочта(Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE Склад (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	КодТелефона INT NOT NULL,
	КодАдреса INT NOT NULL,
	Наименование NVARCHAR(100) NOT NULL,

	CONSTRAINT FK_Склад_Телефон FOREIGN KEY (КодТелефона) 
	REFERENCES Телефон(Код),
	CONSTRAINT FK_Склад_Адрес FOREIGN KEY (КодАдреса) 
	REFERENCES Адрес(Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE Заказ (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	КодСтатуса INT NOT NULL,
	КодCклада INT NOT NULL,
	КодСотрудника INT NOT NULL,
	КодПоставщика INT NOT NULL,
	Оплачено BIT NOT NULL,
    Номер NVARCHAR(50) NOT NULL,
	Дата DATE NOT NULL,

	CONSTRAINT FK_Заказ_Сотрудник FOREIGN KEY (КодСотрудника) 
	REFERENCES Сотрудник(Код),
	CONSTRAINT FK_Заказ_Склад FOREIGN KEY (КодCклада) 
	REFERENCES Склад(Код),
	CONSTRAINT FK_Заказ_Статус FOREIGN KEY (КодСтатуса) 
	REFERENCES Статус(Код),
	CONSTRAINT FK_Заказ_Поставщик FOREIGN KEY (КодПоставщика) 
	REFERENCES Поставщик(Код)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE Товар (
    Код INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	КодЕденицыИзмерения INT NOT NULL,
	КодЗаказа INT NOT NULL,
	Название NVARCHAR(50) NOT NULL,
    Количество INT NOT NULL,
    Цена DECIMAL(10, 2) NOT NULL,

	CONSTRAINT FK_Товар_ЕдиницаИзмерения FOREIGN KEY (КодЕденицыИзмерения) REFERENCES ЕдиницаИзмерения(Код),
	CONSTRAINT FK_Товар_Заказ FOREIGN KEY (КодЗаказа) REFERENCES Заказ(Код),
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
INSERT [dbo].[Адрес] ([Название]) VALUES (N'ул. Спартака, 39, Тверь, Тверская обл., 170001')
INSERT [dbo].[Адрес] ([Название]) VALUES (N'ул. Спартака, 42-б, 3 этаж, Тверь, Тверская обл., 170001')
GO
INSERT [dbo].[Должность] ([Название]) VALUES (N'Менеджер')
INSERT [dbo].[Должность] ([Название]) VALUES (N'Заведующий отделом')
GO
INSERT [dbo].[ЕдиницаИзмерения] ([Название]) VALUES (N'шт.')
INSERT [dbo].[ЕдиницаИзмерения] ([Название]) VALUES (N'уп.')
GO
GO


INSERT [dbo].[Статус] ( [Название]) VALUES ( N'На согласовании')
INSERT [dbo].[Статус] ( [Название]) VALUES ( N'Согласован')
INSERT [dbo].[Статус] ([Название]) VALUES ( N'Подтвержден')
INSERT [dbo].[Статус] ([Название]) VALUES ( N'Закрыт')
GO


INSERT [dbo].[УровеньДоступа] ( [Название]) VALUES (N'Администратор')
INSERT [dbo].[УровеньДоступа] ( [Название]) VALUES (N'Пользователь')

GO


INSERT [dbo].[ЭлектроннаяПочта] ( [АдресПочты]) VALUES (N'college@gmail.com')
INSERT [dbo].[ЭлектроннаяПочта] ( [АдресПочты]) VALUES (N'supplier@gmail.com')
INSERT [dbo].[ЭлектроннаяПочта] ( [АдресПочты]) VALUES ( N'employee@gmail.com')

GO


INSERT [dbo].[Телефон] ([Номер]) VALUES ( N'84822750985')
INSERT [dbo].[Телефон] ( [Номер]) VALUES ( N'84822422601')
INSERT [dbo].[Телефон] ( [Номер]) VALUES ( N'84824352623')
INSERT [dbo].[Телефон] ( [Номер]) VALUES ( N'89201451352')
INSERT [dbo].[Телефон] ([Номер]) VALUES ( N'89202351366')

GO


INSERT [dbo].[Организация] ([Название]) VALUES ( N'ТПЭК')

GO


INSERT [dbo].[Поставщик] ( [КодТелефона], [КодАдреса], [КодЭлектроннойПочты], [НаименованиеФирмы]) VALUES ( 1, 2, 2, N'ТЕХТВЕРЬ')

GO

INSERT [dbo].[Склад] ( [КодТелефона], [КодАдреса], [Наименование]) VALUES ( 3, 1, N'Склад техники')

GO


INSERT [dbo].[Сотрудник] ([КодДолжности], [КодУровняДоступа], [КодОрганизации], [КодТелефона], [КодЭлектроннойПочты], [Логин], [Пароль], [Фамилия], [Имя], [Отчество]) VALUES ( 1, 2, 1, 4, 3, N'manager', N'truemanager', N'Иванов', N'Сергей', N'Федорович')
INSERT [dbo].[Сотрудник] ([КодДолжности], [КодУровняДоступа], [КодОрганизации], [КодТелефона], [КодЭлектроннойПочты], [Логин], [Пароль], [Фамилия], [Имя], [Отчество]) VALUES ( 2, 1, 1, 5, NULL, N'admin', N'trueadmin', N'Федоров', N'Сергей', N'Иванович')



GO
INSERT [dbo].[Заказ] ([КодСтатуса], [КодCклада], [КодСотрудника], [КодПоставщика], [Оплачено], [Номер], [Дата]) VALUES ( 1, 1, 1, 1, 0, N'000001', CAST(N'2023-03-04' AS Date))
GO


INSERT [dbo].[Товар] ( [КодЕденицыИзмерения],  [КодЗаказа], [Название], [Количество], [Цена]) VALUES (1, 1, N'Компьютерная мышь', 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[Товар] ( [КодЕденицыИзмерения],  [КодЗаказа], [Название], [Количество], [Цена]) VALUES (1, 1, N'Компьютерная клавиатура', 3, CAST(500.00 AS Decimal(10, 2)))

