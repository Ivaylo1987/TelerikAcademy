SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary, d.Name
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE e.Salary =
	(SELECT MIN(Salary)
	 FROM Employees em
	 WHERE e.DepartmentID = em.DepartmentID)