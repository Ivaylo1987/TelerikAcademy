SELECT COUNT(*) AS [Number Employees With no Manager]
FROM Employees
WHERE ManagerID IS NULL