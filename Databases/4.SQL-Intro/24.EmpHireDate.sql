SELECT e.FirstName, e.LastName, e.HireDate, d.Name
FROM Employees AS e
	JOIN Departments AS d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN('Sales', 'Finance')
AND YEAR(e.HireDate) BETWEEN 1995 AND 2005 