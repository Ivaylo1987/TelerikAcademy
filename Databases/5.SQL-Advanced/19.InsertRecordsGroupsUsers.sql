USE TelerikAcademy
GO

INSERT INTO [Users] ([UserName], [Password], [FirstName], [LastName])
	VALUES  (N'Kircho', N'azSumKircho', N'Kiro', N'Stoyanov'),
		    (N'Stoycho', N'azSumStoycho', N'Stycho', N'Petkov'),
		    (N'Mariyka', N'azSumMariya', N'Mariya', N'Kostova')

INSERT INTO [Users] ([UserName], [FirstName], [LastName], [GroupId])
	VALUES  (N'Mariyka', N'Mariya', N'Kostova', 3)
GO

INSERt [Groups]
	VALUES  (N'Accountant'),
			(N'Operations'),
			(N'PreSales')
GO