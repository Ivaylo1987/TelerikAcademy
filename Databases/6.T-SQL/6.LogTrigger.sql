USE StoreprocedureTests
GO

CREATE TABLE Logs ( 
	LogId int IDENTITY(1,1) NOT NULL, 
	OldBalance money NULL, 
	NewBalance money NULL,
	AccountId int NOT NULL
	CONSTRAINT PK_LogsId PRIMARY KEY CLUSTERED(LogId)
	CONSTRAINT FK_Accounts_Logs FOREIGN KEY (AccountId) REFERENCES Accounts(AccountId)
)

GO 


CREATE TRIGGER tr_LogChange ON Accounts FOR INSERT, UPDATE
AS
	DECLARE @accountId int;
	SET @accountId = (SELECT AccountId FROM inserted)

	INSERT INTO Logs (OldBalance, NewBalance, AccountId)
	VALUES (
			(SELECT Balance FROM deleted),
			(SELECT Balance FROM inserted),
			@accountId)
GO

UPDATE Accounts
SET Balance = 1000
WHERE AccountId = 1