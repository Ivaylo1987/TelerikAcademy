SELECT AVG(e.Salary) AS [Average Salary]
FROM Employees AS e
	JOIN Departments AS d
		ON e.DepartmentID = d.DepartmentID AND d.DepartmentID = 1