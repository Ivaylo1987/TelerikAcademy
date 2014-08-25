CREATE DATABASE StoreprocedureTests
GO

USE StoreprocedureTests
GO

CREATE TABLE Persons(
	PersonId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName  NVARCHAR(50) NOT NULL,
	SSN  NVARCHAR(50) NULL,
)
GO

CREATE TABLE Accounts(
	AccountId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	PersonId INT NOT NULL FOREIGN KEY REFERENCES [Persons](PersonId),
	Balance  MONEY NULL,
)
GO

INSERT INTO Persons(FirstName, LastName)
	VALUES ('Petko', 'Petkov'),
		   ('Ani', 'Vladimirova'),
		   ('Ivaylo', 'Stoyanov'),
		   ('Dimitar', 'Cvetkov')
GO

INSERT INTO Accounts(PersonId, Blance)
	VALUES (1, 1000),
		   (2, 2300),
		   (3, 9000),
		   (4, 3300),
		   (1, 300),
		   (2, 1300)
GO