USE [tempdb]
GO

DROP DATABASE IF EXISTS [AccountDotnet]
GO

CREATE DATABASE [AccountDotnet]
GO

USE [AccountDotnet]
GO

DROP TABLE IF EXISTS [Account]
GO
CREATE TABLE [Account] (
	[id] INT IDENTITY(1, 1),
	[username] VARCHAR(64),
	[password] VARCHAR(256),

	PRIMARY KEY ([id])
)
GO

INSERT INTO [Account] ([username], [password]) VALUES
('username1', 'password'),
('username2', 'password')
GO