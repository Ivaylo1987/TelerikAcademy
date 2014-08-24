USE [TelerikAcademy]
GO

CREATE TABLE [Groups](
	[GroupId] int IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(100) NOT NULL,
	CONSTRAINT [PK_Groups] PRIMARY KEY ([GroupId]),
	CONSTRAINT UQ_Name UNIQUE([Name])
)
GO