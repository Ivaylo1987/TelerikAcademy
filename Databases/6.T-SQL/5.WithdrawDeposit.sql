USE StoreprocedureTests
GO

CREATE PROC WithdrawMoney(@accountId int, @money money) 
AS
	UPDATE Accounts
	SET Balance = Balance - @money
	WHERE AccountId = @accountId
GO

CREATE PROC DepositMoney(@accountId int, @money money) 
AS
	UPDATE Accounts
	SET Balance = Balance + @money
	WHERE AccountId = @accountId
GO

EXEC WithdrawMoney 1, 500

EXEC DepositMoney 1, 500