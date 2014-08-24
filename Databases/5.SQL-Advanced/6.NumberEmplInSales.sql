SELECT COUNT(*) AS [Number of Employees in Sales]
FROM Employees AS e
	JOIN Departments AS d
		ON e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'