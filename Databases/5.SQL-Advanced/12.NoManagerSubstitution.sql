SELECT e.FirstName, e.LastName, ISNULL(m.FirstName , 'No boss for this one') AS [Manager Name]
FROM Employees AS e
	LEFT JOIN Employees AS m
		ON e.ManagerID = m.EmployeeID