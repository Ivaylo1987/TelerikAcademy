USE TelerikAcademy
GO

CREATE TABLE #EmplProjectsTemp(
	EmployeeId INT NOT NULL,
	ProjectId INT NOT NULL,
	CONSTRAINT PK_EmployeesProjects PRIMARY KEY CLUSTERED (EmployeeID, ProjectID)
)
GO

INSERT INTO #EmplProjectsTemp (EmployeeId, ProjectId)
	SELECT ep.EmployeeID, ep.ProjectID
	FROM EmployeesProjects AS ep
GO

DROP TABLE EmployeesProjects

CREATE TABLE EmployeesProjects(
	EmployeeId INT NOT NULL,
	ProjectId INT NOT NULL,
	CONSTRAINT PK_EmployeesProjects PRIMARY KEY CLUSTERED (EmployeeID, ProjectID)
)
GO

INSERT INTO EmployeesProjects
	SELECT temp.EmployeeId, temp.ProjectId
	FROM #EmplProjectsTemp as temp
GO