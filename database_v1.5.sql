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

CREATE TABLE ���������(
    ��� INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    ��� NVARCHAR(50) NOT NULL,
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
	������������� INT NOT NULL,
	������������� INT NOT NULL,
	���C����� INT NOT NULL,
	������������� INT NOT NULL,
    ����� NVARCHAR(50) NOT NULL,
	���� DATE NOT NULL,

	FOREIGN KEY (�������������) REFERENCES ���������(���),
	FOREIGN KEY (�������������) REFERENCES ���������(���),
	FOREIGN KEY (���C�����) REFERENCES �����(���),
	FOREIGN KEY (�������������) REFERENCES ���������(���)
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
)