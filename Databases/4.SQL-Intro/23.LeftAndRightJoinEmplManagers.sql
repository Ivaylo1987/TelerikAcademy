SELECT e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName as [Manager Name]
FROM Employees as e
	LEFT JOIN Employees as m
		ON e.ManagerID = m.EmployeeID
		
SELECT m.FirstName, m.LastName, e.FirstName + ' ' + e.LastName as [Manager Name]
FROM Employees as m
	RIGHT JOIN Employees as e
		ON e.ManagerID = m.EmployeeID