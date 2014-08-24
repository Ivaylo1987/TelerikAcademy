SELECT COUNT(*) AS [Number Employees with manager]
FROM Employees
WHERE ManagerID IS NOT NULL