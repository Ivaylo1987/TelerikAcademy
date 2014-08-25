USE StoreprocedureTests
GO

CREATE PROC usp_PeopleFullNames
AS
	SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM Persons
GO

EXEC usp_PeopleFullNames