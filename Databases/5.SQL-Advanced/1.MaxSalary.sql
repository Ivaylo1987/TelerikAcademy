SELECT e.FirstName, e.LastName, e.Salary
FROM Employees e
WHERE e.Salary = (SELECT MAX(Salary) FROM Employees)