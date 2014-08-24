SELECT AVG(e.Salary) AS [Average Salary In Sales]
FROM Employees AS e
	JOIN Departments AS d
		ON e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'