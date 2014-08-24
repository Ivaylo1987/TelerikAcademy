SELECT d.Name, e.JobTitle, MIN(e.Salary) AS [Minimum Salary], e.FirstName
FROM Employees AS e
	JOIN Departments AS d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, e.FirstName