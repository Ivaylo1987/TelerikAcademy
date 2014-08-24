SELECT e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName as [Manager Name],
a.AddressText as [Employee Address]
FROM Employees as e
	JOIN Employees as m
		ON e.ManagerID = m.EmployeeID
	JOIN Addresses as a
		ON e.AddressID = a.AddressID