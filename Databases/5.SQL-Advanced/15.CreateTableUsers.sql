USE [TelerikAcademy]
GO

CREATE TABLE [Users](
	[UserId] int IDENTITY(1,1) NOT NULL,
	[UserName] nvarchar(50) NOT NULL UNIQUE,
	[Password] nvarchar(50) NULL,
	[FirstName] nvarchar(50) NULL,
	[LastName] nvarchar(50) NOT NULL,
	[LastLoginTime] datetime NOT NULL,
	CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId])
)
GO

ALTER TABLE [Users] ADD CHECK (LEN([Password]) >= 5)
GO