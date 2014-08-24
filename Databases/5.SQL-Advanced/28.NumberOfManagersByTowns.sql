SELECT t.Name, COUNT(e.ManagerID) AS [Number Of Mnagers]
FROM Towns AS t
	JOIN Addresses AS a
		ON t.TownID = a.TownID
	JOIN Employees AS e
		ON e.AddressID = a.AddressID
GROUP BY t.Name, e.ManagerID
ORDER BY [Number Of Mnagers] DESC