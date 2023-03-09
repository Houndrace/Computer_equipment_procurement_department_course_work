CREATE DATABASE ���������������������������������������;
GO
USE ���������������������������������������;
GO
CREATE TABLE ���������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(50) NOT NULL,
);
GO
CREATE TABLE ����������������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ���������� NVARCHAR(50) NOT NULL,
);
GO
CREATE TABLE �������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ����� NVARCHAR(20) NOT NULL,
);
GO
CREATE TABLE �����(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(100) NOT NULL,
);
GO
CREATE TABLE ����������������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(50) NOT NULL,
);
GO
CREATE TABLE �����������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(100) NOT NULL,
);
GO
CREATE TABLE ��������������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(30) NOT NULL,
);
GO
CREATE TABLE ������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    �������� NVARCHAR(30) NOT NULL,
);
GO
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

	CONSTRAINT FK_���������_��������� FOREIGN KEY (������������) 
	REFERENCES ���������(���),
	CONSTRAINT FK_���������_�������������� FOREIGN KEY (����������������) 
	REFERENCES ��������������(���),
	CONSTRAINT FK_���������_������� FOREIGN KEY (�����������) 
	REFERENCES �������(���),
	CONSTRAINT FK_���������_����������� FOREIGN KEY (��������������) 
	REFERENCES �����������(���),
	CONSTRAINT FK_���������_���������������� FOREIGN KEY (�������������������) 
	REFERENCES ����������������(���)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE ��������� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ����������� INT NOT NULL,
	��������� INT NOT NULL,
	������������������� INT,
	����������������� NVARCHAR(100) NOT NULL,
    
	CONSTRAINT FK_���������_������� FOREIGN KEY (�����������) 
	REFERENCES �������(���),
	CONSTRAINT FK_���������_����� FOREIGN KEY (���������) 
	REFERENCES �����(���),
	CONSTRAINT FK_���������_���������������� FOREIGN KEY (�������������������) 
	REFERENCES ����������������(���)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE ����� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	����������� INT NOT NULL,
	��������� INT NOT NULL,
	������������ NVARCHAR(100) NOT NULL,

	CONSTRAINT FK_�����_������� FOREIGN KEY (�����������) 
	REFERENCES �������(���),
	CONSTRAINT FK_�����_����� FOREIGN KEY (���������) 
	REFERENCES �����(���)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE ����� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	���������� INT NOT NULL,
	���C����� INT NOT NULL,
	������������� INT NOT NULL,
	������������� INT NOT NULL,
	�������� BIT NOT NULL,
    ����� NVARCHAR(50) NOT NULL,
	���� DATE NOT NULL,

	CONSTRAINT FK_�����_��������� FOREIGN KEY (�������������) 
	REFERENCES ���������(���),
	CONSTRAINT FK_�����_����� FOREIGN KEY (���C�����) 
	REFERENCES �����(���),
	CONSTRAINT FK_�����_������ FOREIGN KEY (����������) 
	REFERENCES ������(���),
	CONSTRAINT FK_�����_��������� FOREIGN KEY (�������������) 
	REFERENCES ���������(���)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE ����� (
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	������������������� INT NOT NULL,
	��������� INT NOT NULL,
	�������� NVARCHAR(50) NOT NULL,
    ���������� INT NOT NULL,
    ���� DECIMAL(10, 2) NOT NULL,

	CONSTRAINT FK_�����_���������������� FOREIGN KEY (�������������������) REFERENCES ����������������(���),
	CONSTRAINT FK_�����_����� FOREIGN KEY (���������) REFERENCES �����(���),
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
INSERT [dbo].[�����] ([��������]) VALUES (N'��. ��������, 39, �����, �������� ���., 170001')
INSERT [dbo].[�����] ([��������]) VALUES (N'��. ��������, 42-�, 3 ����, �����, �������� ���., 170001')
GO
INSERT [dbo].[���������] ([��������]) VALUES (N'��������')
INSERT [dbo].[���������] ([��������]) VALUES (N'���������� �������')
GO
INSERT [dbo].[����������������] ([��������]) VALUES (N'��.')
INSERT [dbo].[����������������] ([��������]) VALUES (N'��.')
GO
GO


INSERT [dbo].[������] ( [��������]) VALUES ( N'�� ������������')
INSERT [dbo].[������] ( [��������]) VALUES ( N'����������')
INSERT [dbo].[������] ([��������]) VALUES ( N'�����������')
INSERT [dbo].[������] ([��������]) VALUES ( N'������')
GO


INSERT [dbo].[��������������] ( [��������]) VALUES (N'�������������')
INSERT [dbo].[��������������] ( [��������]) VALUES (N'������������')

GO


INSERT [dbo].[����������������] ( [����������]) VALUES (N'college@gmail.com')
INSERT [dbo].[����������������] ( [����������]) VALUES (N'supplier@gmail.com')
INSERT [dbo].[����������������] ( [����������]) VALUES ( N'employee@gmail.com')

GO


INSERT [dbo].[�������] ([�����]) VALUES ( N'84822750985')
INSERT [dbo].[�������] ( [�����]) VALUES ( N'84822422601')
INSERT [dbo].[�������] ( [�����]) VALUES ( N'84824352623')
INSERT [dbo].[�������] ( [�����]) VALUES ( N'89201451352')
INSERT [dbo].[�������] ([�����]) VALUES ( N'89202351366')

GO


INSERT [dbo].[�����������] ([��������]) VALUES ( N'����')

GO


INSERT [dbo].[���������] ( [�����������], [���������], [�������������������], [�����������������]) VALUES ( 1, 2, 2, N'��������')

GO

INSERT [dbo].[�����] ( [�����������], [���������], [������������]) VALUES ( 3, 1, N'����� �������')

GO


INSERT [dbo].[���������] ([������������], [����������������], [��������������], [�����������], [�������������������], [�����], [������], [�������], [���], [��������]) VALUES ( 1, 2, 1, 4, 3, N'manager', N'truemanager', N'������', N'������', N'���������')
INSERT [dbo].[���������] ([������������], [����������������], [��������������], [�����������], [�������������������], [�����], [������], [�������], [���], [��������]) VALUES ( 2, 1, 1, 5, NULL, N'admin', N'trueadmin', N'�������', N'������', N'��������')



GO
INSERT [dbo].[�����] ([����������], [���C�����], [�������������], [�������������], [��������], [�����], [����]) VALUES ( 1, 1, 1, 1, 0, N'000001', CAST(N'2023-03-04' AS Date))
GO


INSERT [dbo].[�����] ( [�������������������],  [���������], [��������], [����������], [����]) VALUES (1, 1, N'������������ ����', 2, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[�����] ( [�������������������],  [���������], [��������], [����������], [����]) VALUES (1, 1, N'������������ ����������', 3, CAST(500.00 AS Decimal(10, 2)))

