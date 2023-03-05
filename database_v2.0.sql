CREATE DATABASE ���������������������������������������;
GO
USE ���������������������������������������;
GO
CREATE TABLE ���������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ������������ NVARCHAR(50) NOT NULL,
);

CREATE TABLE ����������������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ���������� NVARCHAR(50) NOT NULL,
);

CREATE TABLE �������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ����� NVARCHAR(20) NOT NULL,
);

CREATE TABLE �����(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������������� NVARCHAR(100) NOT NULL,
);

CREATE TABLE ����������������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ������������ NVARCHAR(50) NOT NULL,
);

CREATE TABLE �����������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ������������ NVARCHAR(100) NOT NULL,
);

CREATE TABLE ��������������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(30) NOT NULL,
);

CREATE TABLE ������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(30) NOT NULL,
);

CREATE TABLE ���������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	������������ INT NOT NULL,
	���������������� INT NOT NULL,
	�������������� INT NOT NULL,
	����������� INT NOT NULL,
	������������������� INT,
    ����� NVARCHAR(50) NOT NULL,
    ������ NVARCHAR(50) NOT NULL,
    ������� NVARCHAR(50) NOT NULL,
    ��� NVARCHAR(50) NOT NULL,
    �������� NVARCHAR(50),

	FOREIGN KEY (������������) REFERENCES ���������(���),
	FOREIGN KEY (����������������) REFERENCES ��������������(���),
	FOREIGN KEY (�����������) REFERENCES �������(���),
	FOREIGN KEY (��������������) REFERENCES �����������(���),
	FOREIGN KEY (�������������������) REFERENCES ����������������(���)
);

CREATE TABLE ��������� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ����������� INT NOT NULL,
	��������� INT NOT NULL,
	������������������� INT,
	����������������� NVARCHAR(100) NOT NULL,
    

	FOREIGN KEY (�����������) REFERENCES �������(���),
	FOREIGN KEY (���������) REFERENCES �����(���),
	FOREIGN KEY (�������������������) REFERENCES ����������������(���)
);

CREATE TABLE ����� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	����������� INT NOT NULL,
	��������� INT NOT NULL,
	������������ NVARCHAR(100) NOT NULL,

	FOREIGN KEY (�����������) REFERENCES �������(���),
	FOREIGN KEY (���������) REFERENCES �����(���)
);

CREATE TABLE ����� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	���������� INT NOT NULL,
	������������� INT NOT NULL,
	������������� INT NOT NULL,
	���C����� INT NOT NULL,
	�������� BIT NOT NULL,
    ����� NVARCHAR(50) NOT NULL,
	���� DATE NOT NULL,

	FOREIGN KEY (�������������) REFERENCES ���������(���),
	FOREIGN KEY (����������) REFERENCES ������(���),
	FOREIGN KEY (�������������) REFERENCES ���������(���),
	FOREIGN KEY (���C�����) REFERENCES �����(���)
);

CREATE TABLE ����� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	������������������� INT NOT NULL,
	�������� NVARCHAR(50) NOT NULL,
    ���������� INT NOT NULL,
    ���� DECIMAL(10, 2) NOT NULL,

	FOREIGN KEY (�������������������) REFERENCES ����������������(���)
);

CREATE TABLE ���������� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ��������� INT NOT NULL,
	��������� INT NOT NULL,

	FOREIGN KEY (���������) REFERENCES �����(���),
	FOREIGN KEY (���������) REFERENCES �����(���)
);

INSERT [dbo].[�����] ([���], [��������������]) VALUES (1, N'��. ��������, 39, �����, �������� ���., 170001')
INSERT [dbo].[�����] ([���], [��������������]) VALUES (2, N'��. ��������, 42-�, 3 ����, �����, �������� ���., 170001')
SET IDENTITY_INSERT [dbo].[�����] OFF
GO
SET IDENTITY_INSERT [dbo].[���������] ON 

INSERT [dbo].[���������] ([���], [������������]) VALUES (1, N'��������')
INSERT [dbo].[���������] ([���], [������������]) VALUES (2, N'���������� �������')
SET IDENTITY_INSERT [dbo].[���������] OFF
GO
SET IDENTITY_INSERT [dbo].[����������������] ON 

INSERT [dbo].[����������������] ([���], [������������]) VALUES (1, N'��.')
SET IDENTITY_INSERT [dbo].[����������������] OFF
GO
SET IDENTITY_INSERT [dbo].[�����] ON 

INSERT [dbo].[�����] ([���], [����������], [�������������], [�������������], [���C�����], [��������], [�����], [����]) VALUES (1, 1, 1, 1, 1, 0, N'000001', CAST(N'2023-03-04' AS Date))
SET IDENTITY_INSERT [dbo].[�����] OFF
GO
SET IDENTITY_INSERT [dbo].[����������] ON 

INSERT [dbo].[����������] ([���], [���������], [���������]) VALUES (1, 1, 1)
INSERT [dbo].[����������] ([���], [���������], [���������]) VALUES (2, 1, 2)
SET IDENTITY_INSERT [dbo].[����������] OFF
GO
SET IDENTITY_INSERT [dbo].[�����������] ON 

INSERT [dbo].[�����������] ([���], [������������]) VALUES (1, N'�������')
SET IDENTITY_INSERT [dbo].[�����������] OFF
GO
SET IDENTITY_INSERT [dbo].[���������] ON 

INSERT [dbo].[���������] ([���], [�����������], [���������], [�������������������], [�����������������]) VALUES (1, 1, 2, 2, N'��������')
SET IDENTITY_INSERT [dbo].[���������] OFF
GO
SET IDENTITY_INSERT [dbo].[�����] ON 

INSERT [dbo].[�����] ([���], [�����������], [���������], [������������]) VALUES (1, 3, 1, N'������������ �����')
SET IDENTITY_INSERT [dbo].[�����] OFF
GO
SET IDENTITY_INSERT [dbo].[���������] ON 

INSERT [dbo].[���������] ([���], [������������], [����������������], [��������������], [�����������], [�������������������], [�����], [������], [�������], [���], [��������]) VALUES (1, 1, 2, 1, 4, 3, N'manager', N'truemanager', N'������', N'������', N'���������')
SET IDENTITY_INSERT [dbo].[���������] OFF
GO
SET IDENTITY_INSERT [dbo].[������] ON 

INSERT [dbo].[������] ([���], [��������]) VALUES (1, N'�� ������������')
INSERT [dbo].[������] ([���], [��������]) VALUES (2, N'����������')
INSERT [dbo].[������] ([���], [��������]) VALUES (3, N'�����������')
INSERT [dbo].[������] ([���], [��������]) VALUES (4, N'������')
SET IDENTITY_INSERT [dbo].[������] OFF
GO
SET IDENTITY_INSERT [dbo].[�������] ON 

INSERT [dbo].[�������] ([���], [�����]) VALUES (1, N'84822750985')
INSERT [dbo].[�������] ([���], [�����]) VALUES (2, N'84822422601')
INSERT [dbo].[�������] ([���], [�����]) VALUES (3, N'84824352623')
INSERT [dbo].[�������] ([���], [�����]) VALUES (4, N'89201451352')
SET IDENTITY_INSERT [dbo].[�������] OFF
GO
SET IDENTITY_INSERT [dbo].[�����] ON 

INSERT [dbo].[�����] ([���], [�������������������], [��������], [����������], [����]) VALUES (1, 1, N'������������ ����', 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[�����] ([���], [�������������������], [��������], [����������], [����]) VALUES (2, 1, N'����������', 2, CAST(600.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[�����] OFF
GO
SET IDENTITY_INSERT [dbo].[��������������] ON 

INSERT [dbo].[��������������] ([���], [��������]) VALUES (1, N'�������������')
INSERT [dbo].[��������������] ([���], [��������]) VALUES (2, N'������������')
SET IDENTITY_INSERT [dbo].[��������������] OFF
GO
SET IDENTITY_INSERT [dbo].[����������������] ON 

INSERT [dbo].[����������������] ([���], [����������]) VALUES (1, N'college@gmail.com')
INSERT [dbo].[����������������] ([���], [����������]) VALUES (2, N'supplier@gmail.com')
INSERT [dbo].[����������������] ([���], [����������]) VALUES (3, N'employee@gmail.com')
SET IDENTITY_INSERT [dbo].[����������������] OFF