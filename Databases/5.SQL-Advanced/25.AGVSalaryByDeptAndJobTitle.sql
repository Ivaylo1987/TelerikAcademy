SELECT d.Name, e.JobTitle, AVG(e.Salary) AS [Average Salary]
FROM Employees AS e
	JOIN Departments AS d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle