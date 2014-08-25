USE StoreprocedureTests
GO

CREATE PROC usp_GiveInverestTo(@accountId int, @inerest int)
AS
	DECLARE @balance money
	DECLARE @newBalance money
	SET @balance = (SELECT Balance FROM Accounts a WHERE a.AccountId = @accountId)

	PRINT @balance
	SET @newBalance = dbo.ufn_CalcSumWithInterest(@balance, @inerest, 1)
	PRINT @newBalance

	UPDATE Accounts
	SET Balance = @newBalance
	WHERE AccountId = @accountId
GO

EXEC usp_GiveInverestTo 1, 10