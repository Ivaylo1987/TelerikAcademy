USE [TelerikAcademy]
GO

CREATE TABLE [WorkHours] (
	[WorkHoursId] int IDENTITY(1,1) NOT NULL,
	[Date] date NOT NULL,
	[Task] nvarchar(50) NOT NULL,
	[Hours] int NULL,
	[Comments] text NULL,
	[EmployeeId] int NOT NULL,
	CONSTRAINT [Hours] CHECK ([Hours] > 0 AND [Hours] <= 24),
	CONSTRAINT [PK_WorkHours] PRIMARY KEY CLUSTERED ([WorkHoursId]),
	CONSTRAINT [FK_WorkHours_Employees] FOREIGN KEY ([EmployeeId]) 
    REFERENCES [Employees] ([EmployeeID])
)
GO

CREATE TABLE [WorkHoursLogs] (
	[WorkHoursLogId] int IDENTITY(1,1) NOT NULL,
	[WorkHoursld] int NOT NULL,
	[Date] date NOT NULL,
	[OldValue] nvarchar(50) NOT NULL,
	[NewValue] nvarchar(50) NOT NULL,
	[Command] nvarchar(50) NOT NULL,
	CONSTRAINT [PK_WorkHoursLogs] PRIMARY KEY CLUSTERED ([WorkHoursLogId]),
	CONSTRAINT [FK_WorkHoursLogs_WorkHours] FOREIGN KEY ([WorkHoursld]) 
    REFERENCES [WorkHours] ([WorkHoursId])
)
GO