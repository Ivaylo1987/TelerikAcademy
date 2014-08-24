SELECT e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName as [Manager Name]
FROM Employees as e
	JOIN Employees as m
		ON e.ManagerID = m.EmployeeID