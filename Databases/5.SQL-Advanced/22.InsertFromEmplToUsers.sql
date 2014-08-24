USE TelerikAcademy
GO

INSERT INTO Users (FirstName, LastName, UserName, [Password])
	SELECT DISTINCT
		FirstName,
		LastName,
		LOWER(SUBSTRING(FirstName, 1, 1) + LastName),
		LOWER(SUBSTRING(FirstName, 1, 1) + LastName + 'pwd')
	FROM Employees
GO