SELECT m.FirstName, m.LastName, COUNT(e.ManagerID) AS [Number Of Employees]
FROM Employees AS m
	JOIN Employees AS e
		ON m.EmployeeID = e.ManagerID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.ManagerID) = 5