SELECT t.Name AS [Town Name], d.Name AS [Department Name], COUNT(*) AS [Number Of Employees]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY t.Name, d.Name
ORDER BY [Number Of Employees] DESC