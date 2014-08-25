USE TelerikAcademy
GO

CREATE FUNCTION IsComposedFromLetters(@letters nvarchar(50), @word nvarchar(50)) 
RETURNS bit 
AS 
BEGIN
	DECLARE @isComposed bit = 1
	DECLARE @i int = 1

	WHILE @i <= LEN(@word)
	BEGIN
		IF CHARINDEX(SUBSTRING(@word, @i, 1), @letters) = 0
		BEGIN
			SET @isComposed = 0
			BREAK
		END

		SET @i = @i + 1
	END

	RETURN @isComposed
END

GO

SELECT e.FirstName, t.Name
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
WHERE dbo.IsComposedFromLetters('oistmiahf', t.Name) = 1