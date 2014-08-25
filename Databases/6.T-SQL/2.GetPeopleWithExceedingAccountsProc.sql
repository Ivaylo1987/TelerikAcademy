USE StoreprocedureTests
GO

CREATE PROC usp_GetPeopleWithExceedingAccounts(@amount int)
AS
	SELECT
		p.FirstName + ' ' + p.LastName AS [Full Name],
		a.Blance as [Balance]
	FROM Accounts AS a
		JOIN Persons as p
			ON a.PersonId = p.PersonId
	WHERE a.Blance >= @amount
GO

EXEC usp_GetPeopleWithExceedingAccounts 3000