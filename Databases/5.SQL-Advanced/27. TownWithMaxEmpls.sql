SELECT TOP 1 t.Name, COUNT(e.EmployeeID) AS [Number Of Employees]
FROM Towns AS t
	JOIN Addresses AS a
		ON t.TownID = a.TownID
	JOIN Employees AS e
		ON e.AddressID = a.AddressID
GROUP BY t.Name
ORDER BY [Number Of Employees] DESC