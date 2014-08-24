USE TelerikAcademy
GO

UPDATE Users
SET [Password] = NULL
WHERE LastLoginTime <= '10.03.2010'
