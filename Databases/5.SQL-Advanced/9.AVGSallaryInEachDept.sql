SELECT d.Name AS [Department Name], AVG(e.Salary) AS [Average Sallary]
FROM Departments AS d
	JOIN Employees AS e
		ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name
ORDER BY [Average Sallary]