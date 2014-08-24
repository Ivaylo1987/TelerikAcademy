USE TelerikAcademy
GO

BEGIN TRAN

 -- drop constraint - Other dorp constraintsare needed too but no time to fix them all
ALTER TABLE Employees
   DROP CONSTRAINT [FK_Employees_Departments] 
GO

ALTER TABLE Employees
   ADD CONSTRAINT [FK_Employees_Departments_CascadeDelete]
   FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID) ON DELETE CASCADE
GO

DELETE FROM Employees
	SELECT *
	FROM Employees e
		INNER JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'

ROLLBACK TRAN