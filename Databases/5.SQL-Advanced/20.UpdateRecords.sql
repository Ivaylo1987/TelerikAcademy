USE TelerikAcademy
GO

UPDATE Users
SET [Password] = 'default'
WHERE UserName = 'Mariyka'

UPDATE Users
SET GroupId = 1
WHERE UserName = 'Kircho'

UPDATE Users
SET [Password] = NULL
WHERE UserName = 'Stoycho'