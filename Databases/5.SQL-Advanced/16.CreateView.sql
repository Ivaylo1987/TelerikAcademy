USE TelerikAcademy 
GO

CREATE VIEW V_UsersFromUsertable AS
--You should put logins from today in the table to get result
SELECT *
FROM  Users AS u
WHERE DAY(u.LastLoginTime) = DAY(GETDATE())

GO